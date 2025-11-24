using ManaWorksApi.Application.Dtos;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.User;

namespace ManaWorksApi.Application.Interfaces;

public interface IUserRepository
{
    Task<List<User?>> GetAllUsersAsync(CancellationToken cancellationToken);
    Task<UserDto?> GetUserByIdAsync(int id, CancellationToken cancellationToken);
    Task<User> AddAsync(CreateUserDto? usuario, CancellationToken cancellationToken);
    Task<User> UpdateAsync(UserDto? usuario, CancellationToken cancellationToken);
    Task UpdatePasswordAsync(int id, string password, CancellationToken cancellationToken);
    Task DeleteAsync(int id, CancellationToken cancellationToken);
}