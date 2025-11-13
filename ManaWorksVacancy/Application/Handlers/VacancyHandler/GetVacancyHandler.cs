using ManaWorksVacancy.Application.Dtos.Vacancies;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.Vacancies;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.VacancyHandler;

public class GetVacancyHandler : IRequestHandler<GetAllVacanciesQuery, List<VacancyDto>>
{
    private readonly IVacancyRepository _repository;

    public GetVacancyHandler(IVacancyRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<VacancyDto>> Handle(GetAllVacanciesQuery request, CancellationToken cancellationToken = default)
    {
        return await _repository.GetVacancies(request.status, cancellationToken);
    }
}