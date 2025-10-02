namespace ManaWorksApi.Domain.Entities;

public class Perfil
{
    public int PerfilId { get; private set; }
    public int PermissaoGrupoId { get; private set; }
    public string PerfilNome { get; private set; }
    public List<Permissao> Permissoes { get; private set; }

    public Perfil(int perfilId, int permissaoGrupoId, string perfilNome)
    {
        PerfilId = perfilId;
        PermissaoGrupoId = permissaoGrupoId;
        PerfilNome = perfilNome;
    }
}
