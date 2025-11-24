using ManaWorksApi.Application.Dtos;
using ManaWorksApi.Application.Extensions;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Application.Interfaces.Auth;
using ManaWorksApi.Domain.Entities.User;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    private readonly IEncryptionService _encryptionService;
    
    public UserRepository(AppDbContext context,  IEncryptionService encryptionService)
    {
        _context = context;
        _encryptionService = encryptionService;
    }

    public async Task<UserDto?> GetUserByIdAsync(int id, CancellationToken cancellationToken)
    {
         var user = await _context.users.FindAsync(id);
         return user.ToDto();
    }

    public async Task<List<User?>> GetAllUsersAsync(CancellationToken cancellationToken)
    {
        var users  = await _context.users.AsNoTracking().ToListAsync();
        return users;
    }

    public async Task<User> AddAsync(CreateUserDto usuario, CancellationToken cancellationToken)
    {
        usuario.Password = _encryptionService.EncryptString(usuario.Password);
        _context.users.Add(usuario.ToCreateEntity());
        await _context.SaveChangesAsync();
        return usuario.ToCreateEntity();
    }

    public async Task<User> UpdateAsync(UserDto usuario, CancellationToken cancellationToken)
    {
        _context.users.Update(usuario.ToEntity());
        await _context.SaveChangesAsync();
        return usuario.ToEntity();
    }

    public async Task UpdatePasswordAsync(int id, string password, CancellationToken cancellationToken)
    {
        var usuario = await _context.users.FindAsync(id);
        usuario.Password = _encryptionService.EncryptString(password);
        _context.users.Remove(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var usuario = await _context.users.FindAsync(id);
        _context.users.Remove(usuario);
        await _context.SaveChangesAsync();
    }
}