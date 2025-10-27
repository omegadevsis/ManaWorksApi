using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Handlers.Users;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, User>
{
    private readonly IUserRepository _repository;
    public UpdateUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetUserByIdAsync(request.userId);
        if (user == null)
            throw new KeyNotFoundException("Usuário não encontrado");

        user.UpdateUser(request.name, request.login, request.profileId);
        await _repository.UpdateAsync(user);
        return user;
    }
}