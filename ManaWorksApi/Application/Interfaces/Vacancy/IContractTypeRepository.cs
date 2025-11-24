using ManaWorksApi.Application.Dtos.ContractTypes;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IContractTypeRepository
{
    Task<List<ContractType>> GetContractTypes(CancellationToken cancellationToken);
    Task<ContractType?> GetContractTypesByIdAsync(int id, CancellationToken cancellationToken);
    Task<ContractType> AddAsync(CreateContractTypeDto? contractType, CancellationToken cancellationToken);
}