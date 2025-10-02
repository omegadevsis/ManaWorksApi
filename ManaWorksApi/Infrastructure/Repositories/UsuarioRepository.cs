using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;
    
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Usuario?> GetByIdAsync(int id)
        => await _context.usuarios.FindAsync(id);

    public async Task<List<Usuario?>> GetAllAsync()
        => await _context.usuarios.AsNoTracking().ToListAsync();

    public async Task AddAsync(Usuario usuario)
    {
        _context.usuarios.Add(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Usuario usuario)
    {
        _context.usuarios.Update(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePasswordAsync(int id)
    {
        var usuario = await _context.usuarios.FindAsync(id);
        _context.usuarios.Remove(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var usuario = await _context.usuarios.FindAsync(id);
        _context.usuarios.Remove(usuario);
        await _context.SaveChangesAsync();
    }
}