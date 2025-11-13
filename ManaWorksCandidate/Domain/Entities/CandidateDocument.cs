namespace ManaWorksCandidate.Domain.Entities;

public class CandidateDocument
{
    public int CandidateDocumentId { get; set; }
    public int CandidateId { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public Candidate Candidate { get; set; }
}