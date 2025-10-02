using ManaWorksApi.Domain.Entities;

namespace anaWorksApi.Application.Interfaces;

public interface IPerfilPermissaoRepository
{
    Task<List<PerfilPermissao?>> GetAsync();
    Task<PerfilPermissao?> GetByIdAsync(int id);
    Task PostAsync(PerfilPermissao? perfilPermissao);
    
    Task SaveChangesAsync();
}