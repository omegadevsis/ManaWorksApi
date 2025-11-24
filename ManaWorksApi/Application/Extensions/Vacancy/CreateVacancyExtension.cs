using ManaWorksApi.Application.Dtos.Vacancies;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Extensions;

public static class CreateVacancyExtension
{
    public static CreateVacancyDto ToCreateDto(this Vacancy vacancy)
    {
        if (vacancy == null) return null;

        return new CreateVacancyDto
        {
            WorkTypeId = vacancy.WorkTypeId,
            ContractTypeId = vacancy.ContractTypeId,
            JourneyTypeId = vacancy.JourneyTypeId,
            UserId = vacancy.UserId,
            Title = vacancy.Title,
            Description = vacancy.Description,
            Requirements = vacancy.Requirements,
            CreatedAt = vacancy.CreatedAt,
            //Hour = vacancy.Hour,
            // OpenDate = vacancy.OpenDate,
            // CloseDate = vacancy.CloseDate,
            Status = vacancy.Status,
        };
    }
    
    public static Vacancy ToCreateEntity(this CreateVacancyDto dto)
    {
        if (dto == null) return null;

        return new Vacancy
        {
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
            Status = dto.Status
        };
    }
    
    
}