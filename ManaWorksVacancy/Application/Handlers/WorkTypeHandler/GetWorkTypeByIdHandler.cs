using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.WorkTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.WorkTypeHandler;

public class GetWorkTypeByIdHandler : IRequestHandler<GetWorkTypeByIdQuery, WorkType>
{
    private readonly IWorkTypeRepository _repository;

    public GetWorkTypeByIdHandler(IWorkTypeRepository repository)
    {
        _repository = repository;
    }


    public async Task<WorkType> Handle(GetWorkTypeByIdQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetWorkTypesByIdAsync(request.id, cancellationToken);
    }
}