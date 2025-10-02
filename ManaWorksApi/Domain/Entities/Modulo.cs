namespace ManaWorksApi.Domain.Entities;

public class Modulo
{
    public int ModuloId { get; private set; }
    public string ModuloNome { get; private set; }

    public Modulo(int moduloId, string moduloNome)
    {
        ModuloId = moduloId;
        ModuloNome = moduloNome;
    }
}