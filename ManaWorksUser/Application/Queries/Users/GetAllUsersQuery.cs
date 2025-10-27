using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Queries.Users;

public record GetAllUsersQuery(): IRequest<List<User?>>;
