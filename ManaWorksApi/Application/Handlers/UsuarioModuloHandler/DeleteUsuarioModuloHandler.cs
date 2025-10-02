using ManaWorksApi.Application.Commands.UsuarioModulo;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.UsuarioModuloHandler;

public class DeleteUsuarioModuloHandler : IRequestHandler<DeleteUsuarioModuloCommand, Unit>
{
    private readonly IUsuarioModuloRepository _repository;
    public DeleteUsuarioModuloHandler(IUsuarioModuloRepository repository)
    {
        _repository = repository;
    }
    public async Task<Unit> Handle(DeleteUsuarioModuloCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.id);
        return Unit.Value;
    }
}