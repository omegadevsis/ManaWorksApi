namespace ManaWorksCandidate.Domain.Entities;

public class CandidateCourse
{
    public int CandidateCourseId { get; set; }
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public string Intitution { get; set; }
    public DateTime Conclusion { get; set; }
}