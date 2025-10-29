using System.Threading.Tasks;

namespace ManaWorksUser.Application.Interfaces
{
    public interface IKafkaProducerService
    {
        Task ProduceAsync(string topic, string message);
    }
}