using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class ModuloRepository : IModuloRepository
{
    private readonly AppDbContext _context;

    public ModuloRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Modulo?> GetByIdAsync(int id)
        => await _context.modulos.FindAsync(id);

    public async Task<List<Modulo?>> GetAllAsync()
        => await _context.modulos.AsNoTracking().ToListAsync();

    public async Task AddAsync(Modulo? modulo)
    {
        _context.modulos.Add(modulo);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Modulo? modulo)
    {
        _context.modulos.Add(modulo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var modulo = await _context.modulos.FindAsync(id);
        _context.modulos.Remove(modulo);
        await _context.SaveChangesAsync();
    }
}