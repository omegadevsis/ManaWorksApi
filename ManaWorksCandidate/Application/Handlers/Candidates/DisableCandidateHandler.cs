using ManaWorksCandidate.Application.Commands.Candidates;
using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Application.Interfaces;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.Candidates;

public class DisableCandidateHandler : IRequestHandler<DisableCandidateCommand, CandidateDto>
{
    private readonly ICandidateRepository _repository;

    public DisableCandidateHandler(ICandidateRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<CandidateDto> Handle(DisableCandidateCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.DisableAsync(request.id, cancellationToken);
    }
}