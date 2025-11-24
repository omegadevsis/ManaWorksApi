using ManaWorksApi.Application.Dtos.Candidates;

namespace ManaWorksApi.Application.Interfaces.Candidate;

public interface ICandidateRepository
{
    Task<List<CandidateDto>> GetAllCandidates(CancellationToken cancellationToken);
    Task<CandidateDto> GetCandidateById(int id, CancellationToken cancellationToken);
    Task<ManaWorksApi.Domain.Entities.Candidate.Candidate> AddAsync(CreateCandidateDto candidateDto, CancellationToken cancellationToken);
    Task<CandidateDto> DisableAsync(int id, CancellationToken cancellationToken);
}