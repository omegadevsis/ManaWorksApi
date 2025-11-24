using ManaWorksApi.Application.Dtos.Vacancies;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Extensions;

public static class UpdateVacancyExtension
{
    public static UpdateVacancyDto ToUpdateDto(this Vacancy vacancy)
    {
        if (vacancy == null) return null;

        return new UpdateVacancyDto
        {
            WorkTypeId = vacancy.WorkTypeId,
            ContractTypeId = vacancy.ContractTypeId,
            JourneyTypeId = vacancy.JourneyTypeId,
            UserId = vacancy.UserId,
            Title = vacancy.Title,
            Description = vacancy.Description,
            Requirements = vacancy.Requirements,
            CreatedAt = vacancy.CreatedAt,
            // Hour = vacancy.Hour,
            // OpenDate = vacancy.OpenDate,
            // CloseDate = vacancy.CloseDate,
            Status = vacancy.Status,
            VacancyId = vacancy.VacancyId
        };
    }

    public static Vacancy ToVacancyEntity(this UpdateVacancyDto dto)
    {
        if (dto == null) return null;

        return new Vacancy
        {
            VacancyId = dto.VacancyId,
            WorkTypeId = dto.WorkTypeId,
            ContractTypeId = dto.ContractTypeId,
            JourneyTypeId = dto.JourneyTypeId,
            UserId = dto.UserId,
            Title = dto.Title,
            Description = dto.Description,
            Requirements = dto.Requirements,
            CreatedAt = dto.CreatedAt,
            // Hour = dto.Hour,
            // OpenDate = dto.OpenDate,
            // CloseDate = dto.CloseDate,
            Status = dto.Status,
        };
    }
}