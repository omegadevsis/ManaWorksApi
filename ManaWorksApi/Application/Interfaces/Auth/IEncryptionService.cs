namespace ManaWorksApi.Application.Interfaces.Auth;

public interface IEncryptionService
{
    string EncryptString(string plainText);
}