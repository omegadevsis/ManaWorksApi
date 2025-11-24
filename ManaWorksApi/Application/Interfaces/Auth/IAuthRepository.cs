using ManaWorksApi.Application.Dtos.Auth;


namespace ManaWorksApi.Application.Interfaces.Auth;

public interface IAuthRepository
{
    Task<UserAuthResult?> GetUser(string login, string senha);
}
