using ManaWorksVacancy.Application.Dtos.WorkTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Commands.WorkTypes;

public record CreateWorkTypeCommand(CreateWorkTypeDto createWorkTypeDto) : IRequest<WorkType>;
