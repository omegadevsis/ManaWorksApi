using ManaWorksUser.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksUser.Application.Queries.Users;

public record GetUserByIdQuery(int id) : IRequest<User?>;
