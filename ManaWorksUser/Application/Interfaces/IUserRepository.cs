using ManaWorksUser.Domain.Entities;

namespace ManaWorksUser.Application.Interfaces;

public interface IUserRepository
{
    Task<List<User?>> GetAllUsersAsync();
    Task<User?> GetUserByIdAsync(int id);
    Task AddAsync(User? usuario);
    Task UpdateAsync(User? usuario);
    Task UpdatePasswordAsync(int id);
    Task DeleteAsync(int id);
}