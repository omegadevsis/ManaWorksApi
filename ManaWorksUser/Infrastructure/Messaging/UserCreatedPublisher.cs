using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using ManaWorksUser.Domain.Entities;

namespace ManaWorksUser.Infrastructure.Messaging;

public class UserCreatedPublisher
{
    private readonly string _hostname = "localhost";
    private readonly string _queueName = "user-created";

    public void Publish(User user)
    {
        var factory = new ConnectionFactory() { HostName = _hostname };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

        var message = JsonSerializer.Serialize(user);
        var body = Encoding.UTF8.GetBytes(message);

        channel.BasicPublish(exchange: "", routingKey: _queueName, basicProperties: null, body: body);
    }
}