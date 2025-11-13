
using ManaWorksCandidate.Application.Dtos.CandidateExperiences;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateExperiences;

public static class CandidateExperienceExtension
{
    public static CandidateExperienceDto ToDto(this CandidateExperience candidateExperience)
    {
        if (candidateExperience == null) return null;

        return new CandidateExperienceDto
        {
            CandidateId = candidateExperience.CandidateId,
            Activity = candidateExperience.Activity,
            ReasonLeaving = candidateExperience.ReasonLeaving,
            PeriodStart = candidateExperience.PeriodStart,
            PeriodEnd = candidateExperience.PeriodEnd,
            Enterprise = candidateExperience.Enterprise
        };  
    }

    public static CandidateExperience ToDomain(this CandidateExperienceDto candidateExperienceDto)
    {
        if (candidateExperienceDto == null) return null;

        return new CandidateExperience
        {
            CandidateId = candidateExperienceDto.CandidateId,
            Activity = candidateExperienceDto.Activity,
            ReasonLeaving = candidateExperienceDto.ReasonLeaving,
            PeriodStart = candidateExperienceDto.PeriodStart,
            PeriodEnd = candidateExperienceDto.PeriodEnd,
            Enterprise = candidateExperienceDto.Enterprise
        };
    }

    public static List<CandidateExperienceDto> ToListDto(this List<CandidateExperience> candidateExperiences)
    {
        if (candidateExperiences == null) return null;
        return candidateExperiences.Select(ToDto).ToList();
    }
    
    public static List<CandidateExperience> ToListDomain(this List<CandidateExperienceDto> candidates)
    {
        if(candidates == null) return null;
        
        return candidates.Select(ToDomain).ToList();
    }
}