using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;


namespace ManaWorksUser.Application.Commands.Users;

public record UpdateUserCommand(int userId, string name, string login, string password, int profileId) : IRequest<User>;