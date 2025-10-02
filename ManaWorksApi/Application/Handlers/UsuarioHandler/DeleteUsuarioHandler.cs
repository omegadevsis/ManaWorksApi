using ManaWorksApi.Application.Commands.Usuarios;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Usuarios;

public class DeleteUsuarioHandler : IRequestHandler<DeleteUsuarioCommand, Unit>
{
    private readonly IUsuarioRepository _repository;
    public DeleteUsuarioHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.usuarioId);
        return Unit.Value;
    }
}