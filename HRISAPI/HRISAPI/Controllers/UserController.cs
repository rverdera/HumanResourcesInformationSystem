
namespace HRISAPI.Controllers;

public class UserController : BaseController<UserModel>
{
    public UserController(IBaseRepository<UserModel> baseRepository) : base(baseRepository)
    {
    }
}
