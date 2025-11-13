using ManaWorksVacancy.Application.Dtos.WorkTypes;
using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Extensions.WorkTypes;

public static class CreateWorkTypeExtension
{
    public static CreateWorkTypeDto ToCreateDto(this WorkType workType)
    {
        if (workType == null) return null;

        return new CreateWorkTypeDto
        {
            Name = workType.Name,
        };
    }

    public static WorkType ToCreateEntity(this CreateWorkTypeDto workType)
    {
        if (workType == null) return null;

        return new WorkType
        {
            Name = workType.Name,
        };
    }
}