namespace ManaWorksCandidate.Domain.Entities;

public class CandidateExperience
{
    public int CandidateExperienceId { get; set; }
    public int CandidateId { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
    public string Enterprise { get; set; }
    public string Activity { get; set; }
    public string ReasonLeaving { get; set; }
}