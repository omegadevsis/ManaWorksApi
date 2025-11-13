namespace ManaWorksCandidate.Application.Dtos.CandidateExperiences;

public class CandidateExperienceDto
{
    public int CandidateId { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
    public string Enterprise { get; set; }
    public string Activity { get; set; }
    public string ReasonLeaving { get; set; }
}