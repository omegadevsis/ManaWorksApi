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

public static class CreateCandidateExtension
{
    public static CreateCandidateDto CreateToDto(this Candidate candidate)
    {
        if (candidate == null) return null;

        return new CreateCandidateDto
        {
            Name = candidate.Name,
            Birthday = candidate.Birthday,
            Childrens = candidate.Childrens,
            Status = candidate.Status,
            CreatedAt = candidate.CreatedAt,
            CandidateStatusId = candidate.CandidateStatusId,
            SocialProfile = candidate.SocialProfile,
            MaritalId = candidate.MaritalId,
            CandidateSelection = candidate.CandidateSelection,
            CandidateFunctionsList = candidate.CandidateFunctionList,
            CandidateAddressDto = candidate.CandidateAddress.toDto(),
            CandidateContactDto = candidate.CandidateContact.toDto(),
            CandidateDocumentDto = candidate.CandidateDocument.ToDto(),
            CandidateEducationDtoList = candidate.CandidateEducationList.ToListDto(),
            CandidateObjectiveDto = candidate.CandidateObjective.ToDto(),
            CandidateCourseDtoList = candidate.CandidateCourseList.ToListDto(),
            CandidateExperienceDtoList = candidate.CandidateExperienceList.ToListDto(),
        };
    }

    public static Candidate CreateToDomain(this CreateCandidateDto candidateDto)
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
            SocialProfile = candidateDto.SocialProfile,
            MaritalId = candidateDto.MaritalId,
            CandidateSelection = candidateDto.CandidateSelection,
            CandidateFunctionList = candidateDto.CandidateFunctionsList,
            CandidateAddress = candidateDto.CandidateAddressDto.toDomain(),
            CandidateContact = candidateDto.CandidateContactDto.toDomain(),
            CandidateDocument = candidateDto.CandidateDocumentDto.ToDomain(),
            CandidateObjective = candidateDto.CandidateObjectiveDto.ToDomain(),
            CandidateCourseList = candidateDto.CandidateCourseDtoList.ToListDomain(),
            CandidateExperienceList = candidateDto.CandidateExperienceDtoList.ToListDomain(),
        };
    }
}