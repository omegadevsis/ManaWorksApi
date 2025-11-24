using ManaWorksApi.Application.Interfaces.Auth;

namespace ManaWorksApi.Application.Dtos.Auth;

public class UserAuthResult
{
    public int UserId { get; set; } = 0;
    public int ProfileId { get; set; } = 0;
    public string ProfileName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string Expires { get; set; } = string.Empty;
    
}