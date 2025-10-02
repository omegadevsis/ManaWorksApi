using MediatR;

namespace ManaWorksApi.Application.Commands.UsuarioModulo;

public record DeleteUsuarioModuloCommand(int id) : IRequest<Unit>;