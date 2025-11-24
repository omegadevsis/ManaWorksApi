namespace ManaWorksApi.Domain.Entities.Candidate;

public class CandidateFunction
{
    public int CandidateFunctionId { get; set; }
    public int CandidateId { get; set; }
    public int FunctionId { get; set; }
    public int ExperienceTimeId { get; set; }
    public FunctionWork FunctionWork { get; set; }
    public ExperienceTime ExperienceTime { get; set; }
}