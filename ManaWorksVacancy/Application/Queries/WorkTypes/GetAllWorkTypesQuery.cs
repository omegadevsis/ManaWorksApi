using MediatorLib.Requests;
using ManaWorksVacancy.Domain.Entities;
    
namespace ManaWorksVacancy.Application.Queries.WorkTypes;

public record GetAllWorkTypesQuery() : IRequest<List<WorkType?>>;