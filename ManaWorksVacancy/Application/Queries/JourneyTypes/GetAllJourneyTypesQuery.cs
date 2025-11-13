using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Queries.JourneyTypes;

public record GetAllJourneyTypesQuery() : IRequest<List<JourneyType>>;