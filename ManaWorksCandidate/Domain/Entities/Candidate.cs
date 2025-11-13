namespace ManaWorksCandidate.Domain.Entities;

public class Candidate
{
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int Childrens { get; set; }
    public bool Disponibility { get; set; }
    public bool AvailableWeekend { get; set; }
    public string Status { get; set; }
    public CandidateAddress CandidateAddress { get; set; }
    public CandidateContact CandidateContact { get; set; }
    public CandidateDocument CandidateDocument { get; set; }
    public CandidateObjective CandidateObjective { get; set; }
    public CandidateEducation CandidateEducation { get; set; }
    public List<CandidateCourse> CandidateCourseList { get; set; }
    public List<CandidateExperience> CandidateExperienceList { get; set; }
}