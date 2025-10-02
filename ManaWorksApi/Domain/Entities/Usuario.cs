namespace ManaWorksApi.Domain.Entities;

public class Usuario
{
    public int UsuarioId { get; private set; }
    public int PerfilId { get; private set; }
    public string Nome { get; private set; }
    public string Login { get; private set; }
    public string Senha { get; private set; }
    public string Status { get; set; }
    public Perfil Perfil { get; private set; }

    public Usuario(int usuarioId, string nome, string login, string senha, int perfilId, string status)
    {
        UsuarioId = usuarioId;
        Nome = nome;
        Login = login;
        Senha = senha;
        PerfilId = perfilId;
        Status = status;
    }

    public void UpdatePassword(string senha)
    {
        Senha = senha;
    }

    public bool VerificarSenha(string senha)
    {
        // Implemente hash e verificação real aqui (ex: BCrypt)
        return Senha == Hash(senha);
    }

    private string Hash(string senha)
    {
        // Placeholder - substitua pelo hash real
        return senha;
    }
}
