using ManaWorksVacancy.Application.Dtos.JourneyTypes;

using ManaWorksVacancy.Domain.Entities;

namespace ManaWorksVacancy.Application.Extensions.JourneyTypes;

public static class CreateJourneyTypeExtension
{
    public static CreateJourneyTypeDto ToCreateDto(this JourneyType journeyType)
    {
        if (journeyType == null) return null;

        return new CreateJourneyTypeDto
        {
            Name = journeyType.Name,
        };
    }

    public static JourneyType ToCreateEntity(this CreateJourneyTypeDto journeyType)
    {
        if (journeyType == null) return null;

        return new JourneyType()
        {
            Name = journeyType.Name,
        };
    }
}