using ManaWorksVacancy.Application.Commands.WorkTypes;
using ManaWorksVacancy.Application.Dtos.ContractTypes;
using ManaWorksVacancy.Application.Dtos.WorkTypes;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.WorkTypeHandler;

public class CreateWorkTypeHandler : IRequestHandler<CreateWorkTypeCommand, WorkType>
{
    private readonly IWorkTypeRepository _repository;

    public CreateWorkTypeHandler(IWorkTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<WorkType> Handle(CreateWorkTypeCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.AddAsync(request.createWorkTypeDto, cancellationToken);
    }
}