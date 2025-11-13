using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Commands.Vacancies;

public record DisableVacancyCommand(int id) : IRequest<int>;
