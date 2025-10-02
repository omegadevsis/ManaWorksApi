namespace ManaWorksApi.Application.Interfaces;

public interface ICriptografiaService
{
    string EncryptString(string plainText);
}