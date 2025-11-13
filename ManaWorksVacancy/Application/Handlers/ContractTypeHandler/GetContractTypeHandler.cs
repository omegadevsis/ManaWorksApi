using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.ContractTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.ContractTypeHandler;

public class GetContractTypeHandler : IRequestHandler<GetAllContractTypesQuery, List<ContractType>>
{
    private readonly IContractTypeRepository _repository;

    public GetContractTypeHandler(IContractTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ContractType>> Handle(GetAllContractTypesQuery request, CancellationToken cancellationToken = default)
    {
        return await _repository.GetContractTypes(cancellationToken);
    }
}