using Confluent.Kafka;
using ManaWorksAuth.Application.Interfaces;
using ManaWorksAuth.Domain.Entities;
using System.Text.Json;

namespace ManaWorksAuth.Infrastructure.Messaging;
public class UserCreatedConsumer : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly IConsumer<Ignore, string> _consumer;
    private readonly ILogger<UserCreatedConsumer> _logger;
    private readonly string _topic = "user-created";

    public UserCreatedConsumer(
        IConfiguration configuration,
        IServiceScopeFactory scopeFactory,
        ILogger<UserCreatedConsumer> logger)
    {
        _scopeFactory = scopeFactory;
        _logger = logger;

        var consumerConfig = new ConsumerConfig
        {
            BootstrapServers = configuration["Kafka:BootstrapServers"],
            GroupId = configuration["Kafka:GroupId"] ?? "auth-service-group",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = true
        };

        _consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _consumer.Subscribe(_topic);
        _logger.LogInformation("Consumer iniciado e ouvindo tópico {Topic}", _topic);

        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var consumeResult = _consumer.Consume(stoppingToken);
                    if (consumeResult?.Message?.Value is null)
                        continue;

                    var user = JsonSerializer.Deserialize<User>(consumeResult.Message.Value);

                    if (user == null)
                    {
                        _logger.LogWarning("Mensagem inválida recebida: {Value}", consumeResult.Message.Value);
                        continue;
                    }

                    using var scope = _scopeFactory.CreateScope();
                    var authRepository = scope.ServiceProvider.GetRequiredService<IAuthRepository>();

                    await authRepository.AddUserAsync(user);

                    _logger.LogInformation("Usuário {UserId} processado com sucesso.", user.UserId);
                }
                catch (ConsumeException ex)
                {
                    _logger.LogError(ex, "Erro ao consumir mensagem de Kafka.");
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Erro ao desserializar mensagem.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Erro inesperado ao processar mensagem.");
                }
            }
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("Cancelamento solicitado. Finalizando consumer...");
        }
        finally
        {
            _consumer.Close();
            _consumer.Dispose();
            _logger.LogInformation("Consumer encerrado.");
        }
    }
}