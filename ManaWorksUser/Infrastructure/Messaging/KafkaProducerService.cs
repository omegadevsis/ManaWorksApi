using Confluent.Kafka;
using ManaWorksUser.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ManaWorksUser.Infrastructure.Messaging
{
    public class KafkaProducerService : IKafkaProducerService
    {
        private readonly IProducer<Null, string> _producer;
        private readonly string _bootstrapServers;

        public KafkaProducerService(IConfiguration configuration)
        {
            _bootstrapServers = configuration.GetValue<string>("Kafka:BootstrapServers");
            var config = new ProducerConfig { BootstrapServers = _bootstrapServers };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public async Task ProduceAsync(string topic, string message)
        {
            await _producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
        }
    }
}