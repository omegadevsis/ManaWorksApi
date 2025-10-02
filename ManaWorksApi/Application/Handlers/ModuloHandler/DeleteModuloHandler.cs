using ManaWorksApi.Application.Commands.Modulo;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.ModuloHandler;

public class DeleteModuloHandler : IRequestHandler<DeleteModuloCommand, Unit>
{
    private readonly IModuloRepository _repository;

    public DeleteModuloHandler(IModuloRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Unit> Handle(DeleteModuloCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.id);
        return Unit.Value;
    }
}