using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IPermissaoRepository
{
    Task<List<Permissao?>> GetAllAsync();
    Task<Permissao?> GetByIdAsync(int id);
    Task AddAsync(Permissao? permissao);
    Task UpdateAsync(Permissao? permissao);
    Task DeleteAsync(int id);
}