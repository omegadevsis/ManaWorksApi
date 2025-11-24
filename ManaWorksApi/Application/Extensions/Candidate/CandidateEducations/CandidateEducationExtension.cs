using ManaWorksApi.Application.Dtos.CandidateEducations;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Extensions.CandidateEducations;

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

    public static CandidateEducation ToDomain(this CandidateEducationDto candidateEducation)
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

    public static List<CandidateEducation> ToListDomain(this List<CandidateEducationDto> candidateEducations)
    {
        if (candidateEducations == null) return null;
        
        return candidateEducations.Select(ToDomain).ToList();
    }
}
    