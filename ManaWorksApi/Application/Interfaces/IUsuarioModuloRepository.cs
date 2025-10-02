using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IUsuarioModuloRepository
{
    Task<List<UsuarioModulo?>> GetAllAsync();
    Task<UsuarioModulo?> GetByIdAsync(int id);
    Task AddAsync(UsuarioModulo? usuario);
    Task UpdateAsync(UsuarioModulo? usuario);
    Task DeleteAsync(int id);
}