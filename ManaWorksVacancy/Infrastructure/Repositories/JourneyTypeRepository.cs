using ManaWorksVacancy.Application.Dtos.JourneyTypes;
using ManaWorksVacancy.Application.Extensions.JourneyTypes;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Domain.Entities;
using ManaWorksVacancy.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksVacancy.Infrastructure.Repositories;

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