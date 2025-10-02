using ManaWorksApi.Application.Commands.UsuarioModulo;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.UsuarioModuloHandler;

public class UpdateUsuarioModuloHandler : IRequestHandler<UpdateUsuarioModuloCommand, Unit>
{
    private readonly IUsuarioModuloRepository _repository;
    public UpdateUsuarioModuloHandler(IUsuarioModuloRepository repository)
    {
        _repository = repository;
    }
    public async Task<Unit> Handle(UpdateUsuarioModuloCommand request, CancellationToken cancellationToken)
    {
        var usuario = await _repository.GetByIdAsync(request.usuarioId);
        if (usuario == null)
            throw new KeyNotFoundException("Usuário não encontrado");
        await _repository.UpdateAsync(usuario);
        return Unit.Value;
    }
}