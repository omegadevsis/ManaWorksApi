using MediatR;

namespace ManaWorksApi.Application.Commands.Usuarios;

public record CreateUsuarioCommand(string nome, string login, string senha, int perfilId, string status) : IRequest<int>;