using ManaWorksApi.Application.Commands.Perfil;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Handlers.Perfil;

public class CreatePerfilHandler : IRequestHandler<CreatePerfilCommand, int>
{
    private readonly IPerfilRepository _repository;

    public CreatePerfilHandler(IPerfilRepository repository)
    {
        _repository = repository;
    }
    public async Task<int> Handle(CreatePerfilCommand request, CancellationToken cancellationToken)
    {
        var perfil = new ManaWorksApi.Domain.Entities.Perfil(0, request.perfilGrupoId, request.perfilNome );
        await _repository.AddAsync(perfil);
        return perfil.PerfilId;
    }
}