using ManaWorksApi.Application.Commands.Usuarios;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Usuarios;

public class UpdateUsuarioHandler : IRequestHandler<UpdateUsuarioCommand, Unit>
{
    private readonly IUsuarioRepository _repository;
    public UpdateUsuarioHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
    {
        var usuario = await _repository.GetByIdAsync(request.usuarioId);
        if (usuario == null)
            throw new KeyNotFoundException("Usuário não encontrado");

        //usuario.Atualizar(request.Nome, request.Email);
        await _repository.UpdateAsync(usuario);
        return Unit.Value;
    }
}