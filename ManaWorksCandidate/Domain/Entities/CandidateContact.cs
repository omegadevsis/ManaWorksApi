namespace ManaWorksCandidate.Domain.Entities;

public class CandidateContact
{
    public int CandidateContactId { get; set; }
    public int CandidateId { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Candidate Candidate { get; set; }
}