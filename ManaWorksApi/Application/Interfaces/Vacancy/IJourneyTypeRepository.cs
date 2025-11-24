using ManaWorksApi.Application.Dtos.JourneyTypes;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IJourneyTypeRepository
{
    Task<List<JourneyType>> GetJourneyTypes(CancellationToken cancellationToken);
    Task<JourneyType?> GetJourneyTypesByIdAsync(int id, CancellationToken cancellationToken);
    Task<JourneyType?> AddAsync(CreateJourneyTypeDto? journeyType, CancellationToken cancellationToken);
}