using MediatR;

namespace ManaWorksApi.Application.Commands.Modulo;

public record CreateModuloCommand(int moduloId, string moduloNome) : IRequest<int>;