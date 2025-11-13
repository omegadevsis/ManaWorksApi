using ManaWorksCandidate.Application.Dtos.CandidateAddresses;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateAddresses;

public static class CandidateAddressExtension
{
    public static CandidateAddressDto toDto(this CandidateAddress candidateAddress)
    {
        if (candidateAddress == null) return null;

        return new CandidateAddressDto
        {
            Address = candidateAddress.Address,
            City = candidateAddress.City,
            Country = candidateAddress.Country,
            State = candidateAddress.State,
            ZipCode = candidateAddress.ZipCode,
            CandidateId = candidateAddress.CandidateId,
            Complement = candidateAddress.Complement,
            Neighborhood = candidateAddress.Neighborhood,
            Number = candidateAddress.Number,
        };
    }

    public static CandidateAddress toDomain(this CandidateAddressDto candidateAddressDto)
    {
        if (candidateAddressDto == null) return null;
        
        return new CandidateAddress()
        {
            Address = candidateAddressDto.Address,
            City = candidateAddressDto.City,
            Country = candidateAddressDto.Country,
            State = candidateAddressDto.State,
            ZipCode = candidateAddressDto.ZipCode,
            CandidateId = candidateAddressDto.CandidateId,
            Complement = candidateAddressDto.Complement,
            Neighborhood = candidateAddressDto.Neighborhood,
            Number = candidateAddressDto.Number,
        };
    }
}