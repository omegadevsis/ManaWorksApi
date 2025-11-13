using ManaWorksVacancy.Application.Commands.Vacancies;
using ManaWorksVacancy.Application.Dtos.Vacancies;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.VacancyHandler;

public class UpdateVacancyHandler : IRequestHandler<UpdateVacancyCommand, Vacancy>
{
    private readonly IVacancyRepository _repository;

    public UpdateVacancyHandler(IVacancyRepository repository)
    {
        _repository = repository;
    }

    public async Task<Vacancy> Handle(UpdateVacancyCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.UpdateAsync(request.UpdateVacancyDto, cancellationToken);
    }
}