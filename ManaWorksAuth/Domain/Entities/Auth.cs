using System.ComponentModel.DataAnnotations;

namespace ManaWorksAuth.Domain.Entities;

public class Auth
{
    public int AuthId { get; set; }
    public int UserId { get; set; }
    public int ProfileId { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Passwords { get; set; }
    public string Status { get; set; }
    public string ProfileName { get; set; }
}