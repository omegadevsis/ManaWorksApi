using MediatorLib.Requests;

namespace ManaWorksUser.Application.Commands.Users;

public record DeleteUserCommand(int userId) : IRequest<int>;