using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Infrastructure.Messaging;
using MediatorLib.Requests;


namespace ManaWorksUser.Application.Handlers.Users;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, int>
{
    private readonly IUserRepository _repository;
    private readonly UserCreatedPublisher _publisher;
    public DeleteUserHandler(IUserRepository repository, UserCreatedPublisher publisher)
    {
        _repository = repository;
        _publisher = publisher;
    }

    public async Task<int> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.userId);
        var user = await _repository.GetUserByIdAsync(request.userId);
        _publisher.Publish(user);
        return request.userId;
    }
}