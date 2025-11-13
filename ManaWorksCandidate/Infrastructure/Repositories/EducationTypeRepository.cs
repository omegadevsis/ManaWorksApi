using ManaWorksCandidate.Application.Dtos.Educations;
using ManaWorksCandidate.Application.Extensions.Education;
using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Domain.Entities;
using ManaWorksCandidate.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksCandidate.Infrastructure.Repositories;

public class EducationTypeRepository : IEducationTypeRepository
{
    private readonly AppDbContext _context;

    public EducationTypeRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<EducationType>> GetAllEducationTypes(CancellationToken cancellationToken)
    {
        return await _context.educationtypes.ToListAsync();
    }

    public async Task<EducationType?> GetEducationTypeById(int id, CancellationToken cancellationToken)
    {
        return await _context.educationtypes.FindAsync(id);
    }

    public async Task<EducationType> AddAsync(CreateEducationTypeDto educationTypeDto, CancellationToken cancellationToken)
    {
        _context.educationtypes.Add(educationTypeDto.ToDomain());
        await _context.SaveChangesAsync();
        return educationTypeDto.ToDomain();
    }
}