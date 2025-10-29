namespace ManaWorksAuth.Application.Dtos;

public class TokenResult
{
    public string Token { get; set; } = string.Empty;
    public string Expires { get; set; } = string.Empty;
}