using System.ComponentModel.DataAnnotations;
using ManaWorksApi.Application.Extensions;

namespace ManaWorksApi.Domain.Entities.User;

public class User
{
    public int UserId { get; set; }
    public int ProfileId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Profile? Profile { get; set; }

    public void UpdateUser(string userName, string userLogin, int profileId)
    {
        Name = userName;
        Login = userLogin;
        ProfileId = profileId;
    }
}