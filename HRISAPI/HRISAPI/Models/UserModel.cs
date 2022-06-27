
namespace HRISAPI.Models;

public class UserModel : IBaseModel
{
    public int Id { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
