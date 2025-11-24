using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Interfaces.Candidate;

public interface IFunctionRepository
{
    Task<List<FunctionWork>> GetAllFunctions(CancellationToken cancellationToken);
}