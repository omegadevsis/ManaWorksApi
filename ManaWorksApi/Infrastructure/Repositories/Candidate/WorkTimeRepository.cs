using ManaWorksApi.Application.Interfaces.Candidate;
using ManaWorksApi.Domain.Entities.Candidate;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Candidate;

public class WorkTimeRepository: IWorkTimeRepository
{
    private readonly AppDbContext _context;

    public WorkTimeRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<WorkTime>> GetAllWorkTimes(CancellationToken cancellationToken)
    {
        return await _context.worktimes.ToListAsync(cancellationToken);
    }
}