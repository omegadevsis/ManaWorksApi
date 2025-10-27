using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Application.Queries.Users;
using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Handlers.UserHandler;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository _repository;

    public GetAllUsersHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<User?>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllUsersAsync();
    }
}