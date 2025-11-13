namespace ManaWorksCandidate.Application.Dtos.CandidateContacts;

public class CandidateContactDto
{
    public int CandidateContactId { get; set; }
    public int CandidateId { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}