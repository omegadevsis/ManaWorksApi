namespace ManaWorksApi.Domain.Entities;

public class UsuarioModulo
{
    public int UsuarioModuloId { get; private set; }
    public int ModuloId { get; private set; }
    public int UsuarioId { get; private set; }

    public UsuarioModulo(int usuarioModuloId, int moduloId, int usuarioId)
    {
        UsuarioModuloId = usuarioModuloId;
        ModuloId = moduloId;
        UsuarioId = usuarioId;
    }
}