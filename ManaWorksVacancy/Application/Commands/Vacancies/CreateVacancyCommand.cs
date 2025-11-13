using ManaWorksVacancy.Application.Dtos;
using ManaWorksVacancy.Application.Dtos.Vacancies;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Commands.Vacancies;

public record CreateVacancyCommand(CreateVacancyDto CreateVacancyDto) : IRequest<Vacancy>;