using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Application.Queries.Candidates;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.Candidates;

public class GetCandidateByIdHandler : IRequestHandler<GetCandidateByIdQuery, CandidateDto>
{
    private readonly ICandidateRepository _repository;

    public GetCandidateByIdHandler(ICandidateRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<CandidateDto> Handle(GetCandidateByIdQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetCandidateById(request.id, cancellationToken);
    }
}