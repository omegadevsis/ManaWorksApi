namespace ManaWorksApi.Domain.Entities;

public class PerfilPermissao
{
    public int PerfilPermissaoId { get; private set; }
    public int PermissaoId { get; private set; }
    public Permissao Permissao { get; private set; }
    public PermissaoStatus PermissaoStatus { get; private set; }
    public int PerfilId { get; private set; }
    public Perfil Perfil { get; private set; }

    public PerfilPermissao(Permissao permissao, int perfilId, PermissaoStatus permissaoStatus, int perfilPermissaoId,
        int permissaoId)
    {
        Permissao = permissao;
        PerfilId = perfilId;
        PermissaoStatus = permissaoStatus;
        PerfilPermissaoId = perfilPermissaoId;
        PermissaoId = permissaoId;
    }

    public void Autorizar()
    {
        if (PermissaoStatus.PermissaoStatusNome == "Permitida")
            PermissaoStatus = PermissaoStatus;
    }

    public void Negar()
    {
        //Estado = EstadoPermissao.Negada;
    }

    public void SolicitarAprovacao()
    {
        //Estado = EstadoPermissao.PendenteAprovacao;
    }

    public bool PodeSerAutorizadoPor(Usuario usuario)
    {
        // Implemente a lógica de hierarquia, ex:
        // Retorna true se usuário tem perfil hierarquicamente superior ao perfil dono desta permissão
        return false;
        //return usuario.Perfil.Nivel > this.Perfil.Nivel;
    }
}