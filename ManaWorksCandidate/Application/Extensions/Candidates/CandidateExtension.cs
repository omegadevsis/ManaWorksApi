
using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Application.Extensions.CandidateAddresses;
using ManaWorksCandidate.Application.Extensions.CandidateContacts;
using ManaWorksCandidate.Application.Extensions.CandidateCourses;
using ManaWorksCandidate.Application.Extensions.CandidateDocuments;
using ManaWorksCandidate.Application.Extensions.CandidateEducations;
using ManaWorksCandidate.Application.Extensions.CandidateExperiences;
using ManaWorksCandidate.Application.Extensions.CandidateObjectives;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.Candidates;

public static class CandidateExtension
{
    public static CandidateDto ToDto(this Candidate candidate)
    {
        if (candidate == null) return null;

        return new CandidateDto
        {
            Name = candidate.Name,
            Birthday = candidate.Birthday,
            Childrens = candidate.Childrens,
            Disponibility = candidate.Disponibility,
            AvailableWeekend = candidate.AvailableWeekend,
            CandidateAddressDto = candidate.CandidateAddress.toDto(),
            CandidateContactDto = candidate.CandidateContact.toDto(),
            CandidateDocumentDto = candidate.CandidateDocument.ToDto(),
            CandidateEducationDto = candidate.CandidateEducation.ToDto(),
            CandidateObjectiveDto = candidate.CandidateObjective.ToDto(),
            CandidateCourseDtoList = candidate.CandidateCourseList.ToListDto(),
            CandidateExperienceDtoList = candidate.CandidateExperienceList.ToListDto(),
        };
    }

    public static Candidate ToDomain(this CandidateDto candidateDto)
    {
        if (candidateDto == null) return null;
        
        return new Candidate
        {
            Name = candidateDto.Name,
            Birthday = candidateDto.Birthday,
            Childrens = candidateDto.Childrens,
            Disponibility = candidateDto.Disponibility,
            AvailableWeekend = candidateDto.AvailableWeekend,
            CandidateAddress = candidateDto.CandidateAddressDto.toDomain(),
            CandidateContact = candidateDto.CandidateContactDto.toDomain(),
            CandidateDocument = candidateDto.CandidateDocumentDto.ToDomain(),
            CandidateObjective = candidateDto.CandidateObjectiveDto.ToDomain(),
            CandidateCourseList = candidateDto.CandidateCourseDtoList.ToListDomain(),
            CandidateExperienceList = candidateDto.CandidateExperienceDtoList.ToListDomain(),
        };
    }
    
    public static List<CandidateDto> ToListDto(this List<Candidate> candidates)
    {
        if(candidates == null) return null;
        
        var dtoList = new List<CandidateDto>(candidates.Count);

        foreach (var candidate in candidates)
        {
            dtoList.Add(candidate.ToDto());
        }
        
        return dtoList;
    }
}