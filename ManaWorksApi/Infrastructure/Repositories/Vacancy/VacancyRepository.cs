using ManaWorksApi.Application.Dtos.Vacancies;
using ManaWorksApi.Application.Extensions;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class VacancyRepository : IVacancyRepository
{
    private readonly AppDbContext _context;
    
    public VacancyRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<VacancyDto>> GetVacancies(string status, CancellationToken cancellationToken)
    {
        var vacancies = await _context.vacancies
            .Include(x => x.ContractType)
            .Include(w => w.WorkType)
            .Include(j => j.JourneyType)
            .Where(x => x.Status == status)
            .ToListAsync(cancellationToken);

        return vacancies.ToListDto();
    }

    public async Task<VacancyDto?> GetVacancyByIdAsync(int id, CancellationToken cancellationToken)
    {
        var vacancy = await _context.vacancies
            .FindAsync(id, cancellationToken);
        return vacancy.ToDto();
    }

    public async Task<Vacancy> AddAsync(CreateVacancyDto? vacancy, CancellationToken cancellationToken)
    {
        _context.vacancies.Add(vacancy.ToCreateEntity());
        await _context.SaveChangesAsync(cancellationToken);
        return vacancy.ToCreateEntity();
    }

    public async Task<Vacancy> UpdateAsync(UpdateVacancyDto? vacancy, CancellationToken cancellationToken)
    {
        _context.vacancies.Update(vacancy.ToVacancyEntity());
        await _context.SaveChangesAsync(cancellationToken);
        return vacancy.ToVacancyEntity();
    }

    public async Task DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var vacancy = _context.vacancies.Find(id, cancellationToken);
        _context.vacancies.Remove(vacancy!);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DisableAsync(int id, CancellationToken cancellationToken)
    {
        var vacancy = _context.vacancies.Find(id, cancellationToken);
        vacancy!.Status = "Inactive";
        _context.vacancies.Update(vacancy);
        await _context.SaveChangesAsync(cancellationToken);
    }
}