using ManaWorksCandidate.Application.Dtos.CandidateCourses;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateCourses;

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
            Intitution = candidateCourse.Intitution
        };
    }

    public static CandidateCourse ToDomain(this CandidateCourseDto candidateCourseDto)
    {
        if (candidateCourseDto == null) return null;

        return new CandidateCourse
        {
            Name = candidateCourseDto.Name,
            Conclusion = candidateCourseDto.Conclusion,
            Intitution = candidateCourseDto.Intitution,
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