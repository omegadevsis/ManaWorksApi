using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IUsuarioRepository
{
    Task<List<Usuario?>> GetAllAsync();
    Task<Usuario?> GetByIdAsync(int id);
    Task AddAsync(Usuario? usuario);
    Task UpdateAsync(Usuario? usuario);
    Task UpdatePasswordAsync(int id);
    Task DeleteAsync(int id);
}