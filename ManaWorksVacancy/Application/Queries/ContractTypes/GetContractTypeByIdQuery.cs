using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Queries.ContractTypes;

public record GetContractTypeByIdQuery(int id) : IRequest<ContractType>;
