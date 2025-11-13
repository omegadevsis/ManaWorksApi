using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Application.Queries.Candidates;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.Candidates;

public class GetAllCandidateHandler : IRequestHandler<GetAllCandidatesQuery, List<CandidateDto>>
{
    private readonly ICandidateRepository _repository;

    public GetAllCandidateHandler(ICandidateRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<List<CandidateDto>> Handle(GetAllCandidatesQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetAllCandidates(request.status, cancellationToken);
    }
}