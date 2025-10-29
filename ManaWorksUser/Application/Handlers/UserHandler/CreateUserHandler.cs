using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;
using System.Text.Json;

namespace ManaWorksUser.Application.Handlers.Users;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserRepository _repository;
    private readonly ICriptographyService _criptographyService;
    private readonly IKafkaProducerService _kafkaProducer;

    public CreateUserHandler(IUserRepository repository, ICriptographyService criptographyService, IKafkaProducerService kafkaProducer)
    {
        _repository = repository;
        _criptographyService = criptographyService;
        _kafkaProducer = kafkaProducer;
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User(0, request.name, request.login, _criptographyService.EncryptString(request.password), request.profileId, request.status);
        await _repository.AddAsync(user);

        var message = JsonSerializer.Serialize(user);
        await _kafkaProducer.ProduceAsync("user-created", message);

        return user.UserId;
    }
}