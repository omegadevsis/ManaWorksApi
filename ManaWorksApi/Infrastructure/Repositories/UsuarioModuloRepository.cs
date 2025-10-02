using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class UsuarioModuloRepository : IUsuarioModuloRepository
{
    private readonly AppDbContext _context;
    
    public UsuarioModuloRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<UsuarioModulo?> GetByIdAsync(int id)
        => await _context.usuariomodulos.FindAsync(id);

    public async Task<List<UsuarioModulo?>> GetAllAsync()
        => await _context.usuariomodulos.AsNoTracking().ToListAsync();

    public async Task AddAsync(UsuarioModulo? usuario)
    {
        _context.usuariomodulos.Add(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(UsuarioModulo? usuario)
    {
        _context.usuariomodulos.Update(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var usuario = await _context.usuariomodulos.FindAsync(id);
        _context.usuariomodulos.Remove(usuario);
        await _context.SaveChangesAsync();
    }
}