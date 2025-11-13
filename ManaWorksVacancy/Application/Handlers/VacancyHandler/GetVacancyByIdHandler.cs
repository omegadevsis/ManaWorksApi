using ManaWorksVacancy.Application.Dtos.Vacancies;
using ManaWorksVacancy.Application.Extensions;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.Vacancies;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.VacancyHandler;

public class GetVacancyByIdHandler : IRequestHandler<GetVacancyByIdQuery, VacancyDto>
{
    private readonly IVacancyRepository _repository;

    public GetVacancyByIdHandler(IVacancyRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<VacancyDto> Handle(GetVacancyByIdQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.GetVacancyByIdAsync(request.id, cancellationToken);
    }
}