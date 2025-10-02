namespace ManaWorksApi.Domain.Entities;

public class PermissaoGrupo
{
    public int PermissaoGrupoId { get; private set; }
    public string PermissaoGrupoNome { get; private set; }

    public PermissaoGrupo(int permissaoGrupoId, string permissaoGrupoNome)
    {
        PermissaoGrupoId = permissaoGrupoId;
        PermissaoGrupoNome = permissaoGrupoNome;
    }
}