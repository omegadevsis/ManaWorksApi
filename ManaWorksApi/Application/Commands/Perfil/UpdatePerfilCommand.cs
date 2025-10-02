using MediatR;

namespace ManaWorksApi.Application.Commands.Perfil;

public record UpdatePerfilCommand(int perfilId, string perfilNome, int perfilGrupoId) : IRequest<Unit>;