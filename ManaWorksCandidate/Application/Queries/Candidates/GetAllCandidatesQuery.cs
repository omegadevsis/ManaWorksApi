using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Queries.Candidates;

public record GetAllCandidatesQuery(string status) : IRequest<List<CandidateDto>>;