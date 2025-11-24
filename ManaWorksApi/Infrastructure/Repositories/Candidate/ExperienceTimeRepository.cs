using ManaWorksApi.Application.Interfaces.Candidate;
using ManaWorksApi.Domain.Entities.Candidate;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Candidate;

public class ExperienceTimeRepository: IExperienceTimeRepository
{
    private readonly AppDbContext _context;

    public ExperienceTimeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ExperienceTime>> GetAllExperienceTimes(CancellationToken cancellationToken)
    {
        return await _context.experiencetimes.ToListAsync(cancellationToken);
    }
}