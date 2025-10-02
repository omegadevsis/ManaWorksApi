using MediatR;

namespace ManaWorksApi.Application.Commands.Permissao;

public record UpdatePermissaoCommand(int permissaoId, string permissaoNome, int permissaoModuloId) : IRequest<Unit>;