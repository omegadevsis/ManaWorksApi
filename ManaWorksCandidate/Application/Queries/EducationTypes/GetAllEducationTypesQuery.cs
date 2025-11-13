using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Queries.EducationTypes;

public record GetAllEducationTypesQuery() : IRequest<List<EducationType>>;
