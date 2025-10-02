namespace ManaWorksApi.Application.Domain;

public class TokenResult
{
    public string Token { get; set; } = string.Empty;
    public string Expires { get; set; } = string.Empty;
}