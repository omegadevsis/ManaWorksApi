using System.ComponentModel.DataAnnotations;

namespace ManaWorksUser.Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; private set; }
    
    [Required(ErrorMessage = "Profile is required")]
    public int ProfileId { get; private set; }
    
    [Required(ErrorMessage = "Username is required")]
    public string Name { get; private set; }
    
    [Required(ErrorMessage = "Login is required")]
    public string Login { get; private set; }
    
    [Required(ErrorMessage = "Password is required")]
    [MaxLength(10, ErrorMessage = "Password must be 10 characters or less")]
    public string Password { get; private set; }
    [Required]
    public string Status { get; set; }

    public User(int userId, string name, string login, string password, int profileId, string status)
    {
        UserId = userId;
        Name = name;
        Login = login;
        Password = password;
        ProfileId = profileId;
        Status = status;
    }

    public void UpdateUser(string userName, string userLogin, int profileId)
    {
        Name = userName;
        Login = userLogin;
        ProfileId = profileId;
    }
}
