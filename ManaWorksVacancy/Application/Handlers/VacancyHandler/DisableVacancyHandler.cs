using ManaWorksVacancy.Application.Commands.Vacancies;
using ManaWorksVacancy.Application.Interfaces;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.VacancyHandler;

public class DisableVacancyHandler : IRequestHandler<DisableVacancyCommand, int>
{
    private readonly IVacancyRepository _repository;

    public DisableVacancyHandler(IVacancyRepository repository)
    {
        _repository = repository;
    }
    public async Task<int> Handle(DisableVacancyCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        await _repository.DisableAsync(request.id, cancellationToken);
        return request.id;
    }
}