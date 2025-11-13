using ManaWorksVacancy.Application.Commands.Vacancies;
using ManaWorksVacancy.Application.Dtos.Vacancies;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.VacancyHandler;

public class CreateVacancyHandler : IRequestHandler<CreateVacancyCommand, Vacancy>
{
    private readonly IVacancyRepository _repository;

    public CreateVacancyHandler(IVacancyRepository repository)
    {
        _repository = repository;
    }

    public async Task<Vacancy> Handle(CreateVacancyCommand request, CancellationToken cancellationToken)
    {
        return await _repository.AddAsync(request.CreateVacancyDto, cancellationToken);
    }
}