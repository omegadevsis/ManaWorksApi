using ManaWorksCandidate.Application.Dtos.CandidateEducations;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateEducations;

public static class CandidateEducationExtension
{
    public static CandidateEducationDto ToDto(this CandidateEducation candidateEducation)
    {
        if (candidateEducation == null) return null;

        return new CandidateEducationDto
        {
            CandidateId = candidateEducation.CandidateId,
            Name = candidateEducation.Name,
            Conclusion = candidateEducation.Conclusion,
            EducationTypeId = candidateEducation.EducationTypeId,
        };  
    }

    public static CandidateEducation ToDomain(this CandidateEducation candidateEducation)
    {
        if (candidateEducation == null) return null;

        return new CandidateEducation
        {
            CandidateId = candidateEducation.CandidateId,
            Name = candidateEducation.Name,
            Conclusion = candidateEducation.Conclusion,
            EducationTypeId = candidateEducation.EducationTypeId
        };
    }

    public static List<CandidateEducationDto> ToListDto(this List<CandidateEducation> candidateEducations)
    {
        if (candidateEducations == null) return null;
        
        return candidateEducations.Select(ToDto).ToList();
    }
}