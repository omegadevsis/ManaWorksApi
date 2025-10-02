namespace ManaWorksApi.Domain.Entities;

public class Permissao
{
    public int PermissaoId { get; private set; }
    public string PermissaoNome { get; private set; }  // Ex: "CriarPedido", "VisualizarRelatorios"
    
    public int PermissaoModuloId { get; set; }

    public Permissao(int permissaoId, string permissaoNome, int permissaoModuloId)
    {
        PermissaoId = permissaoId;
        PermissaoNome = permissaoNome;
        PermissaoModuloId = permissaoModuloId;
    }
}
