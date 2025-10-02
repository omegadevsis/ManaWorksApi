using MediatR;

namespace ManaWorksApi.Application.Commands.Usuarios;

public record ChangeUsuarioPasswordCommand(int id, string senha) : IRequest<Unit>;
