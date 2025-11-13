using ManaWorksVacancy.Application.Commands.JourneyTypes;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksVacancy.Application.Handlers.JourneyTypeHandler;

public class CreateJourneyTypeHandler : IRequestHandler<CreateJourneyTypeCommand, JourneyType>
{
    private readonly IJourneyTypeRepository _repository;

    public CreateJourneyTypeHandler(IJourneyTypeRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<JourneyType> Handle(CreateJourneyTypeCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        return await _repository.AddAsync(request.createJourneyTypeDto, cancellationToken);
    }
}