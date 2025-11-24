using ManaWorksApi.Application.Dtos.WorkTypes;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IWorkTypeRepository
{
    Task<List<WorkType>> GetAllWorkTypes(CancellationToken cancellationToken);
    Task<WorkType?> GetWorkTypesByIdAsync(int id, CancellationToken cancellationToken);
    Task<WorkType?> AddAsync(CreateWorkTypeDto? workType, CancellationToken cancellationToken);
}