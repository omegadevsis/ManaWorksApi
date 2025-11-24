using ManaWorksApi.Application.Dtos.Educations;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Interfaces.Candidate;

public interface IEducationTypeRepository
{
    Task<List<EducationType>> GetAllEducationTypes(CancellationToken cancellationToken);
    Task<EducationType> GetEducationTypeById(int id, CancellationToken cancellationToken);
    Task<EducationType> AddAsync(CreateEducationTypeDto educationTypeDto, CancellationToken cancellationToken);
}