using MediatR;

namespace ManaWorksApi.Application.Commands.Perfil;

public record DeletePerfilCommand(int id): IRequest<Unit>;