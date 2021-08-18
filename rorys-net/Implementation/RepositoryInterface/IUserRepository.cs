using Common.Models;
using Implementation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.RepositoryInterface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User CheckLogin(LoginCredentials loginCredentials);
        List<Role> GetRolesForUser(User user);
    }
}
