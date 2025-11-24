using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Interfaces.Candidate;

public interface IMaritalRepository
{
    Task<List<Marital>> GetAllMaritals(CancellationToken cancellationToken);
}