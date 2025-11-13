using ManaWorksCandidate.Application.Dtos.CandidateContacts;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateContacts;

public static class CandidateContactExtension
{
    public static CandidateContactDto toDto(this CandidateContact candidateContact)
    {
        if (candidateContact == null) return null;

        return new CandidateContactDto
        {
            Phone = candidateContact.Phone,
            Email = candidateContact.Email,
            CandidateId = candidateContact.CandidateId,
        };  
    }

    public static CandidateContact toDomain(this CandidateContactDto candidateContactDto)
    {
        if (candidateContactDto == null) return null;

        return new CandidateContact
        {
            Phone = candidateContactDto.Phone,
            Email = candidateContactDto.Email,
            CandidateId = candidateContactDto.CandidateId,
        };
    }
}