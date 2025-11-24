using ManaWorksApi.Application.Dtos.CandidateCourses;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Extensions.CandidateCourses;

public static class CandidateCourseExtension
{
    public static CandidateCourseDto ToDto(this CandidateCourse candidateCourse)
    {
        if (candidateCourse == null) return null;

        return new CandidateCourseDto
        {
            CandidateId = candidateCourse.CandidateId,
            Name = candidateCourse.Name,
            Conclusion = candidateCourse.Conclusion,
            Intitution = candidateCourse.Institution
        };
    }

    public static CandidateCourse ToDomain(this CandidateCourseDto candidateCourseDto)
    {
        if (candidateCourseDto == null) return null;

        return new CandidateCourse
        {
            Name = candidateCourseDto.Name,
            Conclusion = candidateCourseDto.Conclusion,
            Institution = candidateCourseDto.Intitution,
            CandidateId = candidateCourseDto.CandidateId
        };
    }
    
    public static List<CandidateCourseDto> ToListDto(this List<CandidateCourse> candidates)
    {
        if(candidates == null) return null;
        
        return candidates.Select(ToDto).ToList();
    }
    
    public static List<CandidateCourse> ToListDomain(this List<CandidateCourseDto> candidates)
    {
        if(candidates == null) return null;
        
        return candidates.Select(ToDomain).ToList();
    }
}