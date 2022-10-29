
using StarterKITDAL;
using StartKitBLL;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIStartupKit.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public User Login(User contact)
        {
            return _userService.Login(contact);
        }
    }
}
