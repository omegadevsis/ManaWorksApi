using MediatR;

namespace ManaWorksApi.Application.Commands.Modulo;

public record DeleteModuloCommand(int id) : IRequest<Unit>;
