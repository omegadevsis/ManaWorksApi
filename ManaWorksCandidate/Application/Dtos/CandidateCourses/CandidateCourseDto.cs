using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Dtos.CandidateCourses;

public class CandidateCourseDto
{
    public int CandidateId { get; set; }
    public string Name { get; set; }
    public string Intitution { get; set; }
    public DateTime Conclusion { get; set; }
}