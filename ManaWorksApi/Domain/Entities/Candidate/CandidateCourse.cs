namespace ManaWorksApi.Domain.Entities.Candidate;

public class CandidateCourse
{
    public int CandidateCourseId { get; set; }
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public string Institution { get; set; }
    public DateTime Conclusion { get; set; }
}