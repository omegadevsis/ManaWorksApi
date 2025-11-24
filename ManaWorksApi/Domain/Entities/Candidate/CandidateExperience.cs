namespace ManaWorksApi.Domain.Entities.Candidate;

public class CandidateExperience
{
    public int CandidateExperienceId { get; set; }
    public int CandidateId { get; set; }
    public int ExperienceTimeId { get; set; }
    public string Enterprise { get; set; }
    public string Activity { get; set; }
    public string ReasonLeaving { get; set; }
    public string Position { get; set; }
    public ExperienceTime ExperienceTime { get; set; }
}