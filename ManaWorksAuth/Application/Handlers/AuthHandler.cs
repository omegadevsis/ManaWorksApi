using ManaWorksApi.Application.Commands;
using ManaWorksAuth.Application.Dtos;
using ManaWorksAuth.Application.Interfaces;
using MediatorLib.Requests;

namespace ManaWorksApi.Application.Handlers;

public class AuthHandler : IRequestHandler<AuthCommand, UserAuthResult>
{
    private readonly IAuthRepository _repository;
    private readonly IJwtService _jwtService;

    public AuthHandler(IAuthRepository repository, IJwtService jwtService)
    {
        _repository = repository;
        _jwtService = jwtService;
    }

    public async Task<UserAuthResult> Handle(AuthCommand request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetUser(request.Login, request.Senha);
        if (user == null)
            throw new UnauthorizedAccessException("Login ou senha inválidos.");

        var token = _jwtService.GenerateToken(user.Login, user.Nome, user.UsuarioId);

        return new UserAuthResult()
        {
            Login = user.Login,
            Nome = user.Nome,
            UsuarioId = user.UsuarioId,
            Token = token.Token,
            PerfilId = user.PerfilId,
            PerfilNome = user.PerfilNome,
            Expires = token.Expires
        };
    }
}