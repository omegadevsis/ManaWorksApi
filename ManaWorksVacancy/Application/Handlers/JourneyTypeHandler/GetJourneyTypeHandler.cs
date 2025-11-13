using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.JourneyTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.JourneyTypeHandler;

public class GetJourneyTypeHandler : IRequestHandler<GetAllJourneyTypesQuery, List<JourneyType>>
{
    private readonly IJourneyTypeRepository _repository;

    public GetJourneyTypeHandler(IJourneyTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<JourneyType>> Handle(GetAllJourneyTypesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetJourneyTypes(cancellationToken);
    }
}