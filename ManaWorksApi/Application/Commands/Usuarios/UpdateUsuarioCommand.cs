using System.Net.Mail;
using MediatR;

namespace ManaWorksApi.Application.Commands.Usuarios;

public record UpdateUsuarioCommand(int usuarioId, string nome, string login, string senha, int perfilId) : IRequest<Unit>;