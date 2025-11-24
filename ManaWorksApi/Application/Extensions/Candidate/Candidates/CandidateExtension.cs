using ManaWorksApi.Application.Dtos.Candidates;
using ManaWorksApi.Application.Extensions.CandidateAddresses;
using ManaWorksApi.Application.Extensions.CandidateContacts;
using ManaWorksApi.Application.Extensions.CandidateCourses;
using ManaWorksApi.Application.Extensions.CandidateDocuments;
using ManaWorksApi.Application.Extensions.CandidateEducations;
using ManaWorksApi.Application.Extensions.CandidateExperiences;
using ManaWorksApi.Application.Extensions.CandidateObjectives;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;

namespace ManaWorksApi.Application.Extensions.Candidates;

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
            Status =  candidate.Status,
            CreatedAt = candidate.CreatedAt,
            CandidateStatusId = candidate.CandidateStatusId,
            MaritalId = candidate.MaritalId,
            Marital = candidate.Marital,
            CandidateSelection = candidate.CandidateSelection,
            SocialProfile = candidate.SocialProfile,
            CandidateStatus = candidate.CandidateStatus,
            CandidateAddressDto = candidate.CandidateAddress.toDto(),
            CandidateContactDto = candidate.CandidateContact.toDto(),
            CandidateDocumentDto = candidate.CandidateDocument.ToDto(),
            CandidateEducationDtoList = candidate.CandidateEducationList.ToListDto(),
            CandidateObjectiveDto = candidate.CandidateObjective.ToDto(),
            CandidateCourseDtoList = candidate.CandidateCourseList.ToListDto(),
            CandidateExperienceDtoList = candidate.CandidateExperienceList.ToListDto(),
            CandidateFunctions = candidate.CandidateFunctionList,
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
            Status = candidateDto.Status,
            CreatedAt = candidateDto.CreatedAt,
            CandidateStatusId = candidateDto.CandidateStatusId,
            MaritalId = candidateDto.MaritalId,
            Marital = candidateDto.Marital,
            SocialProfile = candidateDto.SocialProfile,
            CandidateSelection = candidateDto.CandidateSelection,
            CandidateStatus = candidateDto.CandidateStatus,
            CandidateAddress = candidateDto.CandidateAddressDto.toDomain(),
            CandidateContact = candidateDto.CandidateContactDto.toDomain(),
            CandidateDocument = candidateDto.CandidateDocumentDto.ToDomain(),
            CandidateObjective = candidateDto.CandidateObjectiveDto.ToDomain(),
            CandidateCourseList = candidateDto.CandidateCourseDtoList.ToListDomain(),
            CandidateExperienceList = candidateDto.CandidateExperienceDtoList.ToListDomain(),
            CandidateEducationList = candidateDto.CandidateEducationDtoList.ToListDomain(),
            CandidateFunctionList = candidateDto.CandidateFunctions
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