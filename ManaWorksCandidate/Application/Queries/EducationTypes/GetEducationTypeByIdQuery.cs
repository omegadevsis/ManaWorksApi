using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Queries.EducationTypes;

public record GetEducationTypeByIdQuery(int id) : IRequest<EducationType?>;
