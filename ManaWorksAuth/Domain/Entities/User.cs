using System.ComponentModel.DataAnnotations;

namespace ManaWorksAuth.Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; private set; }
    
    [Required(ErrorMessage = "Profile is required")]
    public int ProfileId { get; private set; }
    
    [MaxLength(40, ErrorMessage = "Password must be 50 characters or less")]
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; private set; }
    
    [MaxLength(30, ErrorMessage = "Password must be 50 characters or less")]
    [Required(ErrorMessage = "Login is required")]
    public string UserLogin { get; private set; }
    
    [Required(ErrorMessage = "Password is required")]
    [MaxLength(50, ErrorMessage = "Password must be 50 characters or less")]
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
}
