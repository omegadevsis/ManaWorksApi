using ManaWorksVacancy.Application.Dtos.WorkTypes;
using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Interfaces;

public interface IWorkTypeRepository
{
    Task<List<WorkType>> GetAllWorkTypes(CancellationToken cancellationToken);
    Task<WorkType?> GetWorkTypesByIdAsync(int id, CancellationToken cancellationToken);
    Task<WorkType?> AddAsync(CreateWorkTypeDto? workType, CancellationToken cancellationToken);
}