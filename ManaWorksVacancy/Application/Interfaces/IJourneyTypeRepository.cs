using ManaWorksVacancy.Application.Dtos.JourneyTypes;
using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Interfaces;

public interface IJourneyTypeRepository
{
    Task<List<JourneyType>> GetJourneyTypes(CancellationToken cancellationToken);
    Task<JourneyType?> GetJourneyTypesByIdAsync(int id, CancellationToken cancellationToken);
    Task<JourneyType?> AddAsync(CreateJourneyTypeDto? journeyType, CancellationToken cancellationToken);
}