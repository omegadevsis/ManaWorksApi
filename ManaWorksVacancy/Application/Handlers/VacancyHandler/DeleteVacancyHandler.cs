using ManaWorksVacancy.Application.Commands.Vacancies;
using ManaWorksVacancy.Application.Interfaces;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.VacancyHandler;

public class DeleteVacancyHandler : IRequestHandler<DeleteVacancyCommand, int>
{
    private readonly IVacancyRepository _repository;

    public DeleteVacancyHandler(IVacancyRepository repository)
    {
        _repository = repository;
    }
    public async Task<int> Handle(DeleteVacancyCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        await _repository.DeleteAsync(request.id, cancellationToken);
        return request.id;
    }
}


