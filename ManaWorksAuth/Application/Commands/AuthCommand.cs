using ManaWorksAuth.Application.Dtos;
using ManaWorksAuth.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksApi.Application.Commands;

public record AuthCommand(string Login, string Senha) : IRequest<UserAuthResult?>;