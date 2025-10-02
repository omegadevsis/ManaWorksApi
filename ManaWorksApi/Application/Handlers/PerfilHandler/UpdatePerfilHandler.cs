using ManaWorksApi.Application.Commands.Perfil;
using ManaWorksApi.Application.Interfaces;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Perfil;

public class UpdatePerfilHandler : IRequestHandler<UpdatePerfilCommand, Unit>
{
    private readonly IPerfilRepository _repository;

    public UpdatePerfilHandler(IPerfilRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Unit> Handle(UpdatePerfilCommand request, CancellationToken cancellationToken)
    {
        var perfil = await _repository.GetByIdAsync(request.perfilId);
        if (perfil == null)
            throw new KeyNotFoundException("Perfil não encontrado");

        //usuario.Atualizar(request.Nome, request.Email);
        await _repository.UpdateAsync(perfil);
        return Unit.Value;
    }
}