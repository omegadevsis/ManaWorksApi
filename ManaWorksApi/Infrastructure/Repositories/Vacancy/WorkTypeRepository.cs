using ManaWorksApi.Application.Dtos.WorkTypes;
using ManaWorksApi.Application.Extensions.WorkTypes;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class WorkTypeRepository: IWorkTypeRepository
{
    private readonly AppDbContext _context;

    public WorkTypeRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<WorkType>> GetAllWorkTypes(CancellationToken cancellationToken)
    {
        return await _context.worktypes.ToListAsync(cancellationToken);
    }

    public async Task<WorkType?> GetWorkTypesByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.worktypes.FindAsync(id, cancellationToken);
    }

    public async Task<WorkType?> AddAsync(CreateWorkTypeDto? workType, CancellationToken cancellationToken)
    {
        _context.worktypes.Add(workType.ToCreateEntity());
        await _context.SaveChangesAsync(cancellationToken);
        return workType.ToCreateEntity();
    }
}