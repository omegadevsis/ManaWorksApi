using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using ManaWorksAuth.Domain.Entities;
using ManaWorksAuth.Application.Interfaces;

public class UserCreatedConsumer : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly ILogger<UserCreatedConsumer> _logger;
    private readonly string _hostname = "localhost";
    private readonly string _queueName = "user-created";
    private IConnection _connection;
    private IModel _channel;

    public UserCreatedConsumer(IServiceScopeFactory scopeFactory, ILogger<UserCreatedConsumer> logger)
    {
        _scopeFactory = scopeFactory;
        _logger = logger;
        var factory = new ConnectionFactory() { HostName = _hostname };
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();
        _channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var user = JsonSerializer.Deserialize<User>(message);

            using var scope = _scopeFactory.CreateScope();
            var authRepository = scope.ServiceProvider.GetRequiredService<IAuthRepository>();
            await authRepository.AddUserAsync(user);

            _logger.LogInformation("Usuário {UserId} processado com sucesso.", user.UserId);
        };

        _channel.BasicConsume(queue: _queueName, autoAck: true, consumer: consumer);

        return Task.CompletedTask;
    }

    public override void Dispose()
    {
        _channel?.Close();
        _connection?.Close();
        base.Dispose();
    }
}