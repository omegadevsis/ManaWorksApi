using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Interfaces.Candidate;

public interface IWorkTimeRepository
{
    Task<List<WorkTime>> GetAllWorkTimes(CancellationToken cancellationToken);
}