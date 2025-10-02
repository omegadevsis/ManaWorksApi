using MediatR;

namespace ManaWorksApi.Application.Commands.Permissao;

public record CreatePermissaoCommand(int permissaoId, string permissaoNome, int permissaoModuloId) : IRequest<Unit>;