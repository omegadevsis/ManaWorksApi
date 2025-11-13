using ManaWorksVacancy.Application.Dtos.ContractTypes;
using ManaWorksVacancy.Application.Dtos.WorkTypes;
using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Extensions.ContractTypes;

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