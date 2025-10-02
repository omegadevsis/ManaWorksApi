using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class PermissaoRepository: IPermissaoRepository
{
    private readonly AppDbContext _context;
    
    public PermissaoRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Permissao?> GetByIdAsync(int id)
        => await _context.permissoes.FindAsync(id);

    public async Task<List<Permissao?>> GetAllAsync()
        => await _context.permissoes.AsNoTracking().ToListAsync();

    public async Task AddAsync(Permissao? permissao)
    {
        _context.permissoes.Add(permissao);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Permissao? permissao)
    {
        _context.permissoes.Update(permissao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var permissao = await _context.permissoes.FindAsync(id);
        _context.permissoes.Remove(permissao);
        await _context.SaveChangesAsync();
    }
}