namespace ManaWorksAuth.Application.Interfaces;

public interface IEncryptionService
{
    string EncryptString(string plainText);
}