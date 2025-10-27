using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Handlers.Users;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserRepository _repository;
    private readonly ICriptographyService _criptographyService;
    public CreateUserHandler(IUserRepository repository,ICriptographyService criptographyService)
    {
        _repository = repository;
        _criptographyService = criptographyService;
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User(0, request.name, request.login,_criptographyService.EncryptString(request.password), request.profileId, request.status);
        await _repository.AddAsync(user);
        return user.UserId;
    }
}