using ManaWorksApi.Application.Commands.Permissao;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.PermissaoHandler;

public class DeletePermissaoHandler : IRequestHandler<DeletePermissaoCommand, Unit>
{
    private readonly IPermissaoRepository _repository;

    public DeletePermissaoHandler(IPermissaoRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Unit> Handle(DeletePermissaoCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.id);
        return Unit.Value;
    }
}