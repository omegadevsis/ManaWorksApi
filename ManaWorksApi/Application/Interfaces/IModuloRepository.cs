using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IModuloRepository
{
    Task<List<Modulo?>> GetAllAsync();
    Task<Modulo?> GetByIdAsync(int id);
    Task AddAsync(Modulo? modulo);
    Task UpdateAsync(Modulo? modulo);
    Task DeleteAsync(int id);
}