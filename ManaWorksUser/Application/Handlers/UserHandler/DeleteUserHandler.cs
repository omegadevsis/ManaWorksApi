using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using MediatorLib.Requests;


namespace ManaWorksUser.Application.Handlers.Users;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, int>
{
    private readonly IUserRepository _repository;
    public DeleteUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.userId);
        return request.userId;
    }
}