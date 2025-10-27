using System.ComponentModel.DataAnnotations;

namespace ManaWorksUser.Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; private set; }
    
    [Required(ErrorMessage = "Profile is required")]
    public int ProfileId { get; private set; }
    
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; private set; }
    
    [Required(ErrorMessage = "Login is required")]
    public string UserLogin { get; private set; }
    
    [Required(ErrorMessage = "Password is required")]
    [MaxLength(10, ErrorMessage = "Password must be 10 characters or less")]
    public string UserPassword { get; private set; }
    [Required]
    public string UserStatus { get; set; }

    public User(int userId, string userName, string userLogin, string userPassword, int profileId, string userStatus)
    {
        UserId = userId;
        UserName = userName;
        UserLogin = userLogin;
        UserPassword = userPassword;
        ProfileId = profileId;
        UserStatus = userStatus;
    }

    public void UpdateUser(string userName, string userLogin, int profileId)
    {
        UserName = userName;
        UserLogin = userLogin;
        ProfileId = profileId;
    }
}
