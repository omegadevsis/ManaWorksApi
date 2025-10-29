using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Domain.Entities;
using ManaWorksUser.Infrastructure.Messaging;
using MediatorLib.Requests;
using System.Text.Json;

namespace ManaWorksUser.Application.Handlers.Users;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserRepository _repository;
    private readonly ICriptographyService _criptographyService;
    private readonly UserCreatedPublisher _publisher;

    public CreateUserHandler(IUserRepository repository, ICriptographyService criptographyService, UserCreatedPublisher publisher)
    {
        _repository = repository;
        _criptographyService = criptographyService;
        _publisher = publisher;
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User(0, request.name, request.login, _criptographyService.EncryptString(request.password), request.profileId, request.status);
        await _repository.AddAsync(user);

        _publisher.Publish(user);

        return user.UserId;
    }
}