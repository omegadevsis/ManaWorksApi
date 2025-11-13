using ManaWorksCandidate.Application.Interfaces;
using ManaWorksCandidate.Application.Queries.EducationTypes;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Handlers.EducationTypes;

public class GetAllEducationTypeHandler : IRequestHandler<GetAllEducationTypesQuery, List<EducationType>>
{
    private readonly IEducationTypeRepository _repository;

    public GetAllEducationTypeHandler(IEducationTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<EducationType>> Handle(GetAllEducationTypesQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetAllEducationTypes(cancellationToken);
    }
}