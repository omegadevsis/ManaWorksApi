using ManaWorksVacancy.Application.Dtos.Vacancies;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Queries.Vacancies;

public record GetVacancyByIdQuery(int id) : IRequest<VacancyDto>;
