using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class PerfilRepository : IPerfilRepository
{
    private readonly AppDbContext _context;

    public PerfilRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Perfil?>> GetAllAsync()
        => await _context.perfis.AsNoTracking().ToListAsync();

    public async Task<Perfil?> GetByIdAsync(int id)
        => await _context.perfis.FindAsync(id);

    public async Task AddAsync(Perfil? perfil)
    {
        _context.perfis.Add(perfil!);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Perfil? perfil)
    {
        _context.perfis.Update(perfil!);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var perfil = await _context.perfis.FindAsync(id);
        _context.perfis.Remove(perfil!);
        await _context.SaveChangesAsync();
    }
}