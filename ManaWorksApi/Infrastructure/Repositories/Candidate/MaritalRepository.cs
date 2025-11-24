using ManaWorksApi.Application.Interfaces.Candidate;
using ManaWorksApi.Domain.Entities.Candidate;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Candidate;

public class MaritalRepository: IMaritalRepository
{
    private readonly AppDbContext _context;

    public MaritalRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Marital>> GetAllMaritals(CancellationToken cancellationToken)
    {
        return await _context.maritals.ToListAsync(cancellationToken);
    }
}