using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Commands.Candidates;

public record DisableCandidateCommand(int id) : IRequest<CandidateDto>;
