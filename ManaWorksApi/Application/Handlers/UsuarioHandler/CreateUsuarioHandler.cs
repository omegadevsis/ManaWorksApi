using ManaWorksApi.Application.Commands.Usuarios;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Usuarios;

public class CreateUsuarioHandler : IRequestHandler<CreateUsuarioCommand, int>
{
    private readonly IUsuarioRepository _repository;
    private readonly ICriptografiaService _criptografiaService;
    public CreateUsuarioHandler(IUsuarioRepository repository,ICriptografiaService criptografiaService)
    {
        _repository = repository;
        _criptografiaService = criptografiaService;
    }

    public async Task<int> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
    {
        var usuario = new Usuario(0, request.nome, request.login,_criptografiaService.EncryptString(request.senha), request.perfilId, request.status);
        await _repository.AddAsync(usuario);
        return usuario.UsuarioId;
    }
}