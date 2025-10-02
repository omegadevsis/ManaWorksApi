using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using MediatR;

namespace ManaWorksApi.Application.Commands.Usuarios;

public class ChangeUsuarioPasswordHandler : IRequestHandler<ChangeUsuarioPasswordCommand, Unit>
{
    private readonly IUsuarioRepository _repository;
    private readonly ICriptografiaService _criptografiaService;

    public ChangeUsuarioPasswordHandler(IUsuarioRepository repository, ICriptografiaService criptografiaService)
    {
        _repository = repository;
        _criptografiaService = criptografiaService;
    }
    public async Task<Unit> Handle(ChangeUsuarioPasswordCommand request, CancellationToken cancellationToken)
    {
        var usuario = await _repository.GetByIdAsync(request.id);
        if(usuario == null) throw new KeyNotFoundException("Usuário não encontrado");

        var senha = _criptografiaService.EncryptString(request.senha);
        usuario.UpdatePassword(senha);
        
        await _repository.UpdateAsync(usuario);
        return Unit.Value;
    }
}