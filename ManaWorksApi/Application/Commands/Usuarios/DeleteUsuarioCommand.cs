using MediatR;

namespace ManaWorksApi.Application.Commands.Usuarios;

public record DeleteUsuarioCommand(int usuarioId) : IRequest<Unit>;