using ManaWorksApi.Application.Interfaces;

namespace ManaWorksApi.Application.Domain;

public class UsuarioLoginResult
{
    public int UsuarioId { get; set; } = 0;
    public int PerfilId { get; set; } = 0;
    public string PerfilNome { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string Expires { get; set; } = string.Empty;
    
}