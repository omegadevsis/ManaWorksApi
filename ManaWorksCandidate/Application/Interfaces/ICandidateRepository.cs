using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Interfaces;

public interface ICandidateRepository
{
    Task<List<CandidateDto>> GetAllCandidates(string status, CancellationToken cancellationToken);
    Task<CandidateDto> GetCandidateById(int id, CancellationToken cancellationToken);
    Task<Candidate> AddAsync(CreateCandidateDto candidateDto, CancellationToken cancellationToken);
    Task<CandidateDto> DisableAsync(int id, CancellationToken cancellationToken);
}