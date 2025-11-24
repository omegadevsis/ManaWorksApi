using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Interfaces.Candidate;

public interface IExperienceTimeRepository
{
    Task<List<ExperienceTime>> GetAllExperienceTimes(CancellationToken cancellationToken);
}