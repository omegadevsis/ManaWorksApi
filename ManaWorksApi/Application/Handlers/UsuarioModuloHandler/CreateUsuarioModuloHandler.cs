using ManaWorksApi.Application.Commands.UsuarioModulo;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Handlers.UsuarioModuloHandler;

public class CreateUsuarioModuloHandler : IRequestHandler<CreateUsuarioModuloCommand, Unit>
{
    private readonly IUsuarioModuloRepository _repository;
    public CreateUsuarioModuloHandler(IUsuarioModuloRepository repository)
    {
        _repository = repository;
    }
    public async Task<Unit> Handle(CreateUsuarioModuloCommand request, CancellationToken cancellationToken)
    {
        var usuario = new UsuarioModulo(0, request.moduloId, request.usuarioId);
        await _repository.AddAsync(usuario);
        return Unit.Value;
    }
}