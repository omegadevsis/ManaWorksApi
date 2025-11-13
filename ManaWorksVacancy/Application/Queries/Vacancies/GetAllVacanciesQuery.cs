using ManaWorksVacancy.Application.Dtos.Vacancies;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Queries.Vacancies;

public record GetAllVacanciesQuery(string status) : IRequest<List<VacancyDto?>>;