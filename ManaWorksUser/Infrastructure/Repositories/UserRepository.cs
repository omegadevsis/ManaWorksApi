using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Domain.Entities;
using ManaWorksUser.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksUser.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<User?> GetUserByIdAsync(int id)
        => await _context.users.FindAsync(id);

    public async Task<List<User?>> GetAllUsersAsync()
        => await _context.users.AsNoTracking().ToListAsync();

    public async Task AddAsync(User usuario)
    {
        _context.users.Add(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User usuario)
    {
        _context.users.Update(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePasswordAsync(int id)
    {
        var usuario = await _context.users.FindAsync(id);
        _context.users.Remove(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var usuario = await _context.users.FindAsync(id);
        _context.users.Remove(usuario);
        await _context.SaveChangesAsync();
    }
}