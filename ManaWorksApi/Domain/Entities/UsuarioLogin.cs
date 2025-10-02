namespace ManaWorksApi.Domain.Entities;

public class UsuarioLogin
{
    public string Login { get; set; }
    public string Senha { get; set; }

    public UsuarioLogin(string login, string senha)
    {
        Login = login;
        Senha = senha;
    }
}