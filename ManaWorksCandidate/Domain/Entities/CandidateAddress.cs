namespace ManaWorksCandidate.Domain.Entities;

public class CandidateAddress
{
    public int CandidateAddressId { get; set; }
    public int CandidateId { get; set; }
    public Candidate Candidate { get; set; }
    public string Address { get; set; }
    public string Number { get; set; }
    public string Neighborhood { get; set; }
    public string Complement { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
}