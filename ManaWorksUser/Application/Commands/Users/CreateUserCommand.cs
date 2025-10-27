using MediatorLib.Requests;

namespace ManaWorksUser.Application.Commands.Users;

public record CreateUserCommand(string name, string login, string password, int profileId, string status) : IRequest<int>;