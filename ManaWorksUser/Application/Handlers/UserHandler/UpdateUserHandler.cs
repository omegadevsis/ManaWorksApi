using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Domain.Entities;
using ManaWorksUser.Infrastructure.Messaging;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Handlers.Users;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, User>
{
    private readonly IUserRepository _repository;
    private readonly UserCreatedPublisher _publisher;
    public UpdateUserHandler(IUserRepository repository, UserCreatedPublisher publisher)
    {
        _repository = repository;
        _publisher = publisher;
    }

    public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetUserByIdAsync(request.userId);
        if (user == null)
            throw new KeyNotFoundException("Usuário não encontrado");

        user.UpdateUser(request.name, request.login, request.profileId);
        await _repository.UpdateAsync(user);
        _publisher.Publish(user);
        return user;
    }
}