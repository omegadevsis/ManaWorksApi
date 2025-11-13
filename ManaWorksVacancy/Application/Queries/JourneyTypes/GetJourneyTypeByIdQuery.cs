using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Queries.JourneyTypes;

public record GetJourneyTypeByIdQuery(int id) : IRequest<JourneyType>;
