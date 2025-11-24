using ManaWorksApi.Application.Dtos.CandidateCourses;
using ManaWorksApi.Application.Dtos.CandidateDocuments;
using ManaWorksApi.Application.Dtos.CandidateEducations;
using ManaWorksApi.Application.Dtos.CandidateExperiences;
using ManaWorksApi.Application.Dtos.CandidateAddresses;
using ManaWorksApi.Application.Dtos.CandidateContacts;
using ManaWorksApi.Domain.Entities.Candidate;
using Microsoft.AspNetCore.Identity;

namespace ManaWorksApi.Application.Dtos.Candidates;

public class CandidateDto
{
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int Childrens { get; set; }
    public bool Disponibility { get; set; }
    public bool AvailableWeekend { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CandidateStatusId { get; set; }
    public int MaritalId { get; set; }
    public Marital Marital { get; set; }
    public string SocialProfile { get; set; }
    public CandidateSelection CandidateSelection { get; set; }
    public CandidateStatus CandidateStatus { get; set; }
    public CandidateAddressDto CandidateAddressDto { get; set; }
    public CandidateContactDto CandidateContactDto { get; set; }
    public CandidateDocumentDto CandidateDocumentDto { get; set; }
    public CandidateObjectiveDto CandidateObjectiveDto { get; set; }
    public List<CandidateEducationDto> CandidateEducationDtoList { get; set; }
    public List<CandidateCourseDto> CandidateCourseDtoList { get; set; }
    public List<CandidateExperienceDto> CandidateExperienceDtoList { get; set; }
    public List<CandidateFunction> CandidateFunctions { get; set; }
}