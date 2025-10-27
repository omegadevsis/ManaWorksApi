using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Application.Queries.Users;
using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Handlers.UserHandler;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
{
    private readonly IUserRepository _repository;

    public GetUserByIdHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetUserByIdAsync(request.id);
    }
}