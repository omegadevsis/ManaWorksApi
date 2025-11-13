namespace ManaWorksCandidate.Domain.Entities;

public class CandidateEducation
{
    public int CandidateEducationId { get; set; }
    public int CandidateId { get; set; }
    public int EducationTypeId { get; set; }
    public string Name { get; set; }
    public DateTime Conclusion { get; set; }
    public EducationType EducationType { get; set; }
}