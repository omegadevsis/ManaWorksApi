namespace ManaWorksApi.Domain.Entities;

public class PermissaoStatus
{
    public int PermissaoStatusId { get; private set; }
    public string PermissaoStatusNome { get; private set; }

    public PermissaoStatus(int permissaoStatusId, string permissaoStatusNome)
    {
        PermissaoStatusId = permissaoStatusId;
        PermissaoStatusNome = permissaoStatusNome;
    }
}