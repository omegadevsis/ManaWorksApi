using ManaWorksApi.Application.Commands.Perfil;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Perfil;

public class DeletePerfilHandler : IRequestHandler<DeletePerfilCommand, Unit>
{
    private readonly IPerfilRepository _repository;

    public DeletePerfilHandler(IPerfilRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Unit> Handle(DeletePerfilCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.id);
        return Unit.Value;
    }
}