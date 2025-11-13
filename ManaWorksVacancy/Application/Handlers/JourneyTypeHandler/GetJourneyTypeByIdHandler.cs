using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.JourneyTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.JourneyTypeHandler;

public class GetJourneyTypeByIdHandler : IRequestHandler<GetJourneyTypeByIdQuery, JourneyType>
{
    private readonly IJourneyTypeRepository _repository;

    public GetJourneyTypeByIdHandler(IJourneyTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<JourneyType> Handle(GetJourneyTypeByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetJourneyTypesByIdAsync(request.id, cancellationToken);
    }
}