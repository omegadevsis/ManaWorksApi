using ManaWorksApi.Application.Commands.Permissao;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.PermissaoHandler;

public class UpdatePermissaoHandler : IRequestHandler<UpdatePermissaoCommand, Unit>
{
    private readonly IPermissaoRepository _repository;

    public UpdatePermissaoHandler(IPermissaoRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Unit> Handle(UpdatePermissaoCommand request, CancellationToken cancellationToken)
    {
        var permissao = await _repository.GetByIdAsync(request.permissaoId);
        if (permissao == null)
            throw new KeyNotFoundException("Usuário não encontrado");

        //usuario.Atualizar(request.Nome, request.Email);
        await _repository.UpdateAsync(permissao);
        return Unit.Value;
    }
}