namespace ManaWorksApi.Domain.Entities.Candidate;

public class Candidate
{
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int Childrens { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CandidateStatusId { get; set; }
    public int MaritalId { get; set; }
    public Marital Marital { get; set; }
    public string SocialProfile { get; set; }
    public CandidateSelection CandidateSelection { get; set; }
    public CandidateStatus CandidateStatus { get; set; }
    public CandidateAddress CandidateAddress { get; set; }
    public CandidateContact CandidateContact { get; set; }
    public CandidateDocument CandidateDocument { get; set; }
    public CandidateObjective CandidateObjective { get; set; }
    public List<CandidateEducation> CandidateEducationList { get; set; }
    public List<CandidateCourse> CandidateCourseList { get; set; }
    public List<CandidateExperience> CandidateExperienceList { get; set; }
    public List<CandidateFunction> CandidateFunctionList { get; set; }
}