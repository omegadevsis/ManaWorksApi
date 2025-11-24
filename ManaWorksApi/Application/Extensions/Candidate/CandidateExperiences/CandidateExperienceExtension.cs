using ManaWorksApi.Application.Dtos.CandidateExperiences;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Extensions.CandidateExperiences;

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
            ExperienceTimeId = candidateExperience.ExperienceTimeId,
            Enterprise = candidateExperience.Enterprise, 
            Position = candidateExperience.Position
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
            ExperienceTimeId = candidateExperienceDto.ExperienceTimeId,
            Enterprise = candidateExperienceDto.Enterprise,
            Position = candidateExperienceDto.Position
        };
    }

    public static List<CandidateExperienceDto> ToListDto(this List<CandidateExperience> candidateExperiences)
    {
        if (candidateExperiences == null) return null;
        return candidateExperiences.Select(ToDto).ToList();
    }

    public static List<CandidateExperience> ToListDomain(this List<CandidateExperienceDto> candidates)
    {
        if (candidates == null) return null;

        return candidates.Select(ToDomain).ToList();
    }
}