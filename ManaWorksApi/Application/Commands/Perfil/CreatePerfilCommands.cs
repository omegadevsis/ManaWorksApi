using MediatR;

namespace ManaWorksApi.Application.Commands.Perfil;

public record CreatePerfilCommand(string perfilNome, int perfilGrupoId) : IRequest<int>;