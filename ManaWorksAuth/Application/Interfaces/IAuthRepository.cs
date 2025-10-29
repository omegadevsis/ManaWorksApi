using ManaWorksAuth.Application.Dtos;
using ManaWorksAuth.Domain.Entities;

namespace ManaWorksAuth.Application.Interfaces;

public interface IAuthRepository
{
    Task<UserAuthResult?> GetUser(string login, string senha);
    Task AddUserAsync(User user);
}
