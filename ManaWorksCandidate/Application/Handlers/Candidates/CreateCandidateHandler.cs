using ManaWorksCandidate.Application.Commands.Candidates;
using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Application.Extensions.Candidates;
using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.Candidates;

public class CreateCandidateHandler : IRequestHandler<CreateCandidateCommand, Candidate>
{
    private readonly ICandidateRepository _repository;

    public CreateCandidateHandler(ICandidateRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Candidate?> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(request.candidate, cancellationToken);
        return request.candidate.CreateToDomain();
    }
}