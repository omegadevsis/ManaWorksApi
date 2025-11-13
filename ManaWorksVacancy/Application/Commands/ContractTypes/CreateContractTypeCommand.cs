using ManaWorksVacancy.Application.Dtos.ContractTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Commands.ContractTypes;

public record CreateContractTypeCommand(CreateContractTypeDto dto) : IRequest<ContractType>;
