using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Application.Queries.EducationTypes;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.EducationTypes;

public class GetEducationTypeByIdHandler : IRequestHandler<GetEducationTypeByIdQuery, EducationType>
{
    private readonly IEducationTypeRepository _repository;

    public GetEducationTypeByIdHandler(IEducationTypeRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<EducationType> Handle(GetEducationTypeByIdQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetEducationTypeById(request.id, cancellationToken);
    }
}