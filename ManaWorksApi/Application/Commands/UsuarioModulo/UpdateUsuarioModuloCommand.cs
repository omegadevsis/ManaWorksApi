using MediatR;

namespace ManaWorksApi.Application.Commands.UsuarioModulo;

public record UpdateUsuarioModuloCommand(int usuarioModuloId, int moduloId, int usuarioId) : IRequest<Unit>;