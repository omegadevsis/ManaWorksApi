using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.WorkTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.WorkTypeHandler;

public class GetWorkTypeHandler : IRequestHandler<GetAllWorkTypesQuery, List<WorkType>>
{
    private readonly IWorkTypeRepository _repository;

    public GetWorkTypeHandler(IWorkTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<WorkType>> Handle(GetAllWorkTypesQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetAllWorkTypes(cancellationToken);
    }
}