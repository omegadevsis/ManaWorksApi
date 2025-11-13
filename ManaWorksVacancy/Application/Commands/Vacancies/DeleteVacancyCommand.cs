using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Commands.Vacancies;

public record DeleteVacancyCommand(int id) : IRequest<int>;