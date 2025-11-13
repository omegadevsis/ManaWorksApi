using ManaWorksCandidate.Application.Dtos.CandidateDocuments;
using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Domain.Entities;

namespace ManaWorksCandidate.Application.Extensions.CandidateDocuments;

public static class CandidateDocumentExtension
{
    public static CandidateDocumentDto ToDto(this CandidateDocument candidateDocument)
    {
        if (candidateDocument == null) return null;

        return new CandidateDocumentDto
        {
            CandidateId = candidateDocument.CandidateId,
            Cpf = candidateDocument.Cpf,
            Rg = candidateDocument.Rg,
        };
    }

    public static CandidateDocument ToDomain(this CandidateDocumentDto candidateDto)
    {
        if (candidateDto == null) return null;

        return new CandidateDocument
        {
            CandidateId = candidateDto.CandidateId,
            Cpf = candidateDto.Cpf,
            Rg = candidateDto.Rg,
        };
    }
    
    public static List<CandidateDocumentDto> ToListDto(this List<CandidateDocument> candidates)
    {
        if(candidates == null) return null;
        
        var dtoList = new List<CandidateDocumentDto>(candidates.Count);

        foreach (var candidate in candidates)
        {
            dtoList.Add(candidate.ToDto());
        }
        
        return dtoList;
    }
}