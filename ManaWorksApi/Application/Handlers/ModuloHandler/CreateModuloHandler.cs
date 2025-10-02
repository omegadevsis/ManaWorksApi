using ManaWorksApi.Application.Commands.Modulo;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Handlers.ModuloHandler;

public class CreateModuloHandler : IRequestHandler<CreateModuloCommand, int>
{
    private readonly IModuloRepository _repository;

    public CreateModuloHandler(IModuloRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<int> Handle(CreateModuloCommand request, CancellationToken cancellationToken)
    {
        var modulo = new Modulo(request.moduloId, request.moduloNome);
        await _repository.AddAsync(modulo);
        return request.moduloId;
    }
}