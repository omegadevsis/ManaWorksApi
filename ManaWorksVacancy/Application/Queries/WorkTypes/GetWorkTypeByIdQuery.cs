using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Queries.WorkTypes;

public record GetWorkTypeByIdQuery(int id) : IRequest<WorkType>;
