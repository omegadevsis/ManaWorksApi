using ManaWorksApi.Application.Dtos.ContractTypes;
using ManaWorksApi.Application.Dtos.WorkTypes;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Extensions.ContractTypes;

public static class CreateContractTypeExtension
{
    public static CreateContractTypeDto ToCreateDto(this ContractType contractType)
    {
        if (contractType == null) return null;

        return new CreateContractTypeDto
        {
            Name = contractType.Name,
        };
    }

    public static ContractType ToCreateEntity(this CreateContractTypeDto contractType)
    {
        if (contractType == null) return null;

        return new ContractType
        {
            Name = contractType.Name,
        };
    }
}