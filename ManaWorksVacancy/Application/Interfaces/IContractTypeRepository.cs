using ManaWorksVacancy.Application.Dtos.ContractTypes;
using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Interfaces;

public interface IContractTypeRepository
{
    Task<List<ContractType>> GetContractTypes(CancellationToken cancellationToken);
    Task<ContractType?> GetContractTypesByIdAsync(int id, CancellationToken cancellationToken);
    Task<ContractType> AddAsync(CreateContractTypeDto? contractType, CancellationToken cancellationToken);
}