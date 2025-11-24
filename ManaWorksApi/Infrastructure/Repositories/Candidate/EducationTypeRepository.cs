using ManaWorksApi.Infrastructure.Persistence;
using ManaWorksApi.Application.Dtos.Educations;
using ManaWorksApi.Application.Extensions.Education;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Application.Interfaces.Candidate;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Candidate;

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