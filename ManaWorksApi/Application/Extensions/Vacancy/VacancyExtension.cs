using ManaWorksApi.Application.Dtos.Vacancies;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Extensions;

public static class VacancyExtension
{
    public static VacancyDto ToDto(this Vacancy vacancy)
    {
        if(vacancy == null) return null;
        
        return new VacancyDto{
            VacancyId = vacancy.VacancyId,
            WorkTypeId = vacancy.WorkTypeId,
            WorkTypeName = vacancy.WorkType?.Name,
            ContractTypeId = vacancy.ContractTypeId,
            ContractTypeName = vacancy.ContractType?.Name,
            JourneyTypeId = vacancy.JourneyTypeId,
            JourneyTypeName = vacancy.JourneyType?.Name,
            UserId = vacancy.UserId,
            Title = vacancy.Title,
            Description = vacancy.Description,
            Requirements = vacancy.Requirements,
            CreatedAt = vacancy.CreatedAt,
            // Hour = vacancy.Hour,
            // OpenDate = vacancy.OpenDate,
            // CloseDate = vacancy.CloseDate,
            Status = vacancy.Status
        };
    }

    public static Vacancy ToEntity(this VacancyDto dto)
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
            Status = dto.Status
        };  
    }
    
    public static List<VacancyDto> ToListDto(this List<Vacancy> vacancies)
    {
        if(vacancies == null) return null;
        
        var dtoList = new List<VacancyDto>(vacancies.Count);

        foreach (var vacancy in vacancies)
        {
            dtoList.Add(vacancy.ToDto());
        }
        
        return dtoList;
    }
}