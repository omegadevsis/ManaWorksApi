using ManaWorksCandidate.Application.Dtos.CandidateAddresses;
using ManaWorksCandidate.Application.Dtos.CandidateContacts;
using ManaWorksCandidate.Application.Dtos.CandidateCourses;
using ManaWorksCandidate.Application.Dtos.CandidateDocuments;
using ManaWorksCandidate.Application.Dtos.CandidateEducations;
using ManaWorksCandidate.Application.Dtos.CandidateExperiences;

namespace ManaWorksCandidate.Application.Dtos.Candidates;

public class CandidateDto
{
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int Childrens { get; set; }
    public bool Disponibility { get; set; }
    public bool AvailableWeekend { get; set; }
    public CandidateAddressDto CandidateAddressDto { get; set; }
    public CandidateContactDto CandidateContactDto { get; set; }
    public CandidateDocumentDto CandidateDocumentDto { get; set; }
    public CandidateObjectiveDto CandidateObjectiveDto { get; set; }
    public CandidateEducationDto CandidateEducationDto { get; set; }
    public List<CandidateCourseDto> CandidateCourseDtoList { get; set; }
    public List<CandidateExperienceDto> CandidateExperienceDtoList { get; set; }
}