namespace ManaWorksCandidate.Application.Dtos.CandidateEducations;

public class CandidateEducationDto
{
    public int CandidateId { get; set; }
    public int EducationTypeId { get; set; }
    public string Name { get; set; }
    public DateTime Conclusion { get; set; }
}