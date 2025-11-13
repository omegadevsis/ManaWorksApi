using ManaWorksVacancy.Application.Dtos.Vacancies;
using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Interfaces;

public interface IVacancyRepository
{
    Task<List<VacancyDto>> GetVacancies(string status, CancellationToken cancellationToken);
    Task<VacancyDto?> GetVacancyByIdAsync(int id, CancellationToken cancellationToken);
    Task<Vacancy> AddAsync(CreateVacancyDto? vacancy, CancellationToken cancellationToken);
    Task<Vacancy> UpdateAsync(UpdateVacancyDto? vacancy, CancellationToken cancellationToken);
    Task DeleteAsync(int id, CancellationToken cancellationToken);
    Task DisableAsync(int id, CancellationToken cancellationToken);
}