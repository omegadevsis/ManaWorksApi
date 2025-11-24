using ManaWorksApi.Application.Dtos.JourneyTypes;
using ManaWorksApi.Application.Extensions.JourneyTypes;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class JourneyTypeRepository : IJourneyTypeRepository
{
    private readonly AppDbContext _context;

    public JourneyTypeRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<JourneyType>> GetJourneyTypes(CancellationToken cancellationToken)
    {
        return await _context.journeytypes.ToListAsync(cancellationToken);
    }

    public async Task<JourneyType?> GetJourneyTypesByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.journeytypes.FindAsync(id, cancellationToken);
    }

    public async Task<JourneyType> AddAsync(CreateJourneyTypeDto? journeyType, CancellationToken cancellationToken)
    {
        _context.journeytypes.Add(journeyType.ToCreateEntity());
        await _context.SaveChangesAsync(cancellationToken);
        return journeyType.ToCreateEntity();
    }
}