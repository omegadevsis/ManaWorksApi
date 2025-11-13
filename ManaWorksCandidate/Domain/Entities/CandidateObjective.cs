namespace ManaWorksCandidate.Domain.Entities;

public class CandidateObjective
{
    public int CandidateObjectiveId { get; set; }
    public int CandidateId { get; set; }
    public string Period { get; set; }
    public string Description { get; set; }
    public decimal Pretension { get; set; }
    public bool WorkSupermarket { get; set; }
}