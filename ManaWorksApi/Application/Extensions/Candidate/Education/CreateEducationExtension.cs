using ManaWorksApi.Application.Dtos.Educations;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;


namespace ManaWorksApi.Application.Extensions.Education;

public static class CreateEducationExtension
{
    public static CreateEducationTypeDto ToDto(this EducationType education)
    {
        if (education == null) return null;

        return new CreateEducationTypeDto
        {
            Name = education.Name,
        };
    }

    public static EducationType ToDomain(this CreateEducationTypeDto typeDto)
    {
        if (typeDto == null) return null;
        return new EducationType
        {
            Name = typeDto.Name,
        };
    }
}