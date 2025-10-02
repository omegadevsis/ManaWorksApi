using MediatR;

namespace ManaWorksApi.Application.Commands.UsuarioModulo;

public record CreateUsuarioModuloCommand(int usuarioModuloId, int moduloId, int usuarioId) : IRequest<Unit>;