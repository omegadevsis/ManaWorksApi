using ManaWorksCandidate.Application.Dtos.CandidateExperiences;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateObjectives;

public static class CandidateObjectiveExtension
{
    public static CandidateObjectiveDto ToDto(this CandidateObjective candidateObjective)
    {
        if (candidateObjective == null) return null;

        return new CandidateObjectiveDto
        {
            CandidateId = candidateObjective.CandidateId,
            Description = candidateObjective.Description,
            Period = candidateObjective.Period,
            Pretension = candidateObjective.Pretension,
            WorkSupermarket = candidateObjective.WorkSupermarket
        };
    }

    public static CandidateObjective ToDomain(this CandidateObjectiveDto candidateObjective)
    {
        if (candidateObjective == null) return null;

        return new CandidateObjective
        {
            CandidateId = candidateObjective.CandidateId,
            Description = candidateObjective.Description,
            Period = candidateObjective.Period,
            Pretension = candidateObjective.Pretension,
            WorkSupermarket = candidateObjective.WorkSupermarket
        };
    }
    
    public static List<CandidateObjectiveDto> ToListDto(this List<CandidateObjective> candidateObjectiveList)
    {
        if (candidateObjectiveList == null) return null;

        return candidateObjectiveList.Select(ToDto).ToList();
    }
}