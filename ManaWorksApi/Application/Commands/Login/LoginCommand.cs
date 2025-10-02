using ManaWorksApi.Application.Domain;
using ManaWorksApi.Domain.Entities;
using MediatR;

namespace ManaWorksApi.Application.Commands.Login;

public record LoginCommand(string Login, string Senha) : IRequest<UsuarioLoginResult?>;