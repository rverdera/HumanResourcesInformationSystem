namespace HRISAPI.Models;

public class UserModel :IBaseModel
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

}
