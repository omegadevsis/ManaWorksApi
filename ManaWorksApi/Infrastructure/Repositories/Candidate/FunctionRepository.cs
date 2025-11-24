using ManaWorksApi.Application.Interfaces.Candidate;
using ManaWorksApi.Domain.Entities.Candidate;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Candidate;

public class FunctionRepository: IFunctionRepository
{
    private readonly AppDbContext _context;

    public FunctionRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<FunctionWork>> GetAllFunctions(CancellationToken cancellationToken)
    {
        return await _context.functionworks.ToListAsync(cancellationToken);
    }
}