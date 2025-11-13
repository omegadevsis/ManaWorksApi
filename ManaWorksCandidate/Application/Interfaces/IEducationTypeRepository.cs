using ManaWorksCandidate.Application.Dtos.Educations;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Interfaces;

public interface IEducationTypeRepository
{
    Task<List<EducationType>> GetAllEducationTypes(CancellationToken cancellationToken);
    Task<EducationType> GetEducationTypeById(int id, CancellationToken cancellationToken);
    Task<EducationType> AddAsync(CreateEducationTypeDto educationTypeDto, CancellationToken cancellationToken);
}