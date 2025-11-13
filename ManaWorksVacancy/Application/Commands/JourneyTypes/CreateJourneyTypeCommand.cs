using ManaWorksVacancy.Application.Dtos.JourneyTypes;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Commands.JourneyTypes;

public record CreateJourneyTypeCommand(CreateJourneyTypeDto createJourneyTypeDto) : IRequest<JourneyType>;
