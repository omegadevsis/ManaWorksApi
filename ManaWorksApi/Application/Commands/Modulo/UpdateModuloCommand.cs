using MediatR;

namespace ManaWorksApi.Application.Commands.Modulo;

public record UpdateModuloCommand(int moduloId, string moduloNome) : IRequest<int>;