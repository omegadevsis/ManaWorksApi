using ManaWorksApi.Application.Commands.Modulo;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Handlers.ModuloHandler;

public class UpdateModuloHandler : IRequestHandler<UpdateModuloCommand, int>
{
    private readonly IModuloRepository _repository;

    public UpdateModuloHandler(IModuloRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<int> Handle(UpdateModuloCommand request, CancellationToken cancellationToken)
    {
        var modulo = await _repository.GetByIdAsync(request.moduloId);
        if (modulo == null)
            throw new KeyNotFoundException("Módulo não atualizado");

        //usuario.Atualizar(request.Nome, request.Email);
        await _repository.UpdateAsync(modulo);
        return request.moduloId;
    }
}