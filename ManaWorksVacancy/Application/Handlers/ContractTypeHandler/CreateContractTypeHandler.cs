using ManaWorksVacancy.Application.Commands.ContractTypes;
using ManaWorksVacancy.Application.Dtos.ContractTypes;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.ContractTypeHandler;

public class CreateContractTypeHandler : IRequestHandler<CreateContractTypeCommand, ContractType>
{
    private readonly IContractTypeRepository _repository;

    public CreateContractTypeHandler(IContractTypeRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<ContractType> Handle(CreateContractTypeCommand request, CancellationToken cancellationToken)
    {
        return await _repository.AddAsync(request.dto, cancellationToken);
    }
}