using ManaWorksCandidate.Application.Commands.EducationTypes;
using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.EducationTypes;

public class CreateEducationTypeHandler : IRequestHandler<CreateEducationTypeCommand, EducationType>
{
    private readonly IEducationTypeRepository _repository;

    public CreateEducationTypeHandler(IEducationTypeRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<EducationType> Handle(CreateEducationTypeCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.AddAsync(request.EducationType, cancellationToken);
    }
}