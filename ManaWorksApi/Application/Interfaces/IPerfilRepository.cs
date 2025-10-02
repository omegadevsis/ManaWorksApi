using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IPerfilRepository
{
    Task<List<Perfil?>> GetAllAsync();
    Task<Perfil?> GetByIdAsync(int id);
    Task AddAsync(Perfil? perfil);
    Task UpdateAsync(Perfil? perfil);
    Task DeleteAsync(int id);
}