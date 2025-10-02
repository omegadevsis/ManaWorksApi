using MediatR;

namespace ManaWorksApi.Application.Commands.Permissao;

public record DeletePermissaoCommand(int id) : IRequest<Unit>;
