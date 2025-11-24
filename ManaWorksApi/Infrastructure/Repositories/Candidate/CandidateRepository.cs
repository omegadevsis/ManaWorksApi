using ManaWorksApi.Infrastructure.Persistence;
using ManaWorksApi.Application.Dtos.Candidates;
using ManaWorksApi.Application.Extensions.Candidates;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Application.Interfaces.Candidate;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Candidate;

public class CandidateRepository : ICandidateRepository
{
    private readonly AppDbContext _context;

    public CandidateRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CandidateDto>> GetAllCandidates(CancellationToken cancellationToken)
    {
        var candidates = await _context.candidates
            .Include(s => s.CandidateStatus)
            .Include(a => a.CandidateAddress)
            .Include(b => b.CandidateContact)
            .Include(c => c.CandidateCourseList)
            .Include(d => d.CandidateDocument)
            .Include(e => e.CandidateExperienceList)
            .Include(f => f.CandidateEducationList)
            .Include(g => g.CandidateObjective)
            .ToListAsync();

        return candidates.ToListDto();
    }

    public async Task<CandidateDto?> GetCandidateById(int id, CancellationToken cancellationToken)
    {
        var candidate = await _context.candidates
            .Include(a => a.CandidateAddress)
            .Include(b => b.CandidateContact)
            .Include(c => c.CandidateCourseList)
            .Include(d => d.CandidateDocument)
            .Include(e => e.CandidateExperienceList)
            .Include(f => f.CandidateEducationList)
            .Include(g => g.CandidateObjective)
            .FirstOrDefaultAsync(x => x.CandidateId == id);
        
        return candidate.ToDto();
    }

    public async Task<Domain.Entities.Candidate.Candidate> AddAsync(CreateCandidateDto candidateDto, CancellationToken cancellationToken)
    {
        _context.candidates.Add(candidateDto.CreateToDomain());
        await _context.SaveChangesAsync();
        return candidateDto.CreateToDomain();
    }

    public async Task<CandidateDto> DisableAsync(int id, CancellationToken cancellationToken)
    {
        var candidate = await _context.candidates.FindAsync(id);
        if (candidate is null)
        {
            throw new Exception("Candidate not found");
        }
        candidate.Status = "Inactive";
        _context.candidates.Update(candidate);
        await _context.SaveChangesAsync();
        return candidate.ToDto();
    }
}