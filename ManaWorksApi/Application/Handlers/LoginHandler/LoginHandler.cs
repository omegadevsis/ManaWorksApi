using ManaWorksApi.Application.Commands.Login;
using ManaWorksApi.Application.Domain;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Login;

public class LoginHandler : IRequestHandler<LoginCommand, UsuarioLoginResult>
{
    private readonly ILoginRepository _repository;
    private readonly IJwtService _jwtService;
    public LoginHandler(ILoginRepository repository, IJwtService jwtService)
    {
        _repository = repository;
        _jwtService = jwtService;
    }
    public async Task<UsuarioLoginResult> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var usuario = await _repository.GetUser(request.Login, request.Senha);
        if (usuario == null)
            throw new UnauthorizedAccessException("Login ou senha inválidos.");

        var token = _jwtService.GenerateToken(usuario.Login, usuario.Nome, usuario.UsuarioId);

        return new UsuarioLoginResult()
        {
            Login = usuario.Login,
            Nome = usuario.Nome,
            UsuarioId = usuario.UsuarioId,
            Token = token.Token,
            PerfilId = usuario.PerfilId,
            PerfilNome = usuario.PerfilNome,
            Expires = token.Expires
        };
    }
}