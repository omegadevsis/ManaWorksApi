using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.ContractTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.ContractTypeHandler;

public class GetContractTypeByIdHandler : IRequestHandler<GetContractTypeByIdQuery, ContractType?>
{
    private readonly IContractTypeRepository _repository;

    public GetContractTypeByIdHandler(IContractTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<ContractType?> Handle(GetContractTypeByIdQuery request, CancellationToken cancellationToken = default)
    {
        return await _repository.GetContractTypesByIdAsync(request.id, cancellationToken);
    }
}