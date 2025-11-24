namespace ManaWorksApi.Domain.Entities.Candidate;

public class CandidateSelection
{
    public int CandidateSelectionId { get; set; }
    public int CandidateId { get; set; }
    public bool? DisponibilityTime { get; set; }
    public int? WorkTimeId { get; set; }
    public bool? DisponibilityWeekend { get; set; }
    public bool? MarketWorked { get; set; }
    public string? MarketWorkedDescription { get; set; }
    public string? DistanceHome { get; set; }
    public string? FunctionWorked { get; set; }
    public bool? CurrentlyWorking { get; set; }
    public bool? DisponibilityImediate { get; set; }
    public string? KnowingVacancy { get; set; }
    public decimal? Pretension { get; set; }
    public bool? FunctionExperience { get; set; }
    public int? ExperienceTimeId { get; set; }
    public string? RelevanceFormation { get; set; }
    public WorkTime WorkTime { get; set; }
}