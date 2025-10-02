using ManaWorksApi.Application.Domain;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface ILoginRepository
{
    Task<UsuarioLoginResult?> GetUser(string login, string senha);
}
