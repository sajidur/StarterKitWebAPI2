using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class UserRepository:IUserRepository
    {
        ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public User Login(User user)
        {
            return _context.Users.Where(a => a.UserName == user.UserName&&a.Password==user.Password).FirstOrDefault();
        }
    }
}
