using ManaWorksApi.Application.Commands.Permissao;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Handlers.PermissaoHandler;

public class CreatePermissaoHandler : IRequestHandler<CreatePermissaoCommand, Unit>
{
    private readonly IPermissaoRepository _repository;

    public CreatePermissaoHandler(IPermissaoRepository repository)
    {
        _repository = repository;
    }
    public async Task<Unit> Handle(CreatePermissaoCommand request, CancellationToken cancellationToken)
    {
        var permissao = new Permissao(request.permissaoId, request.permissaoNome, request.permissaoModuloId);
        await _repository.AddAsync(permissao);

        return Unit.Value;
    }
}