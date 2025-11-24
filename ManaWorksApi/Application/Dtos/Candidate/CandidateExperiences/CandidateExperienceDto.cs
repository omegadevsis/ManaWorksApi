namespace ManaWorksApi.Application.Dtos.CandidateExperiences;

public class CandidateExperienceDto
{
    public int CandidateId { get; set; }
    public int ExperienceTimeId { get; set; }
    public string Enterprise { get; set; }
    public string Activity { get; set; }
    public string ReasonLeaving { get; set; }
    public string Position { get; set; }
}