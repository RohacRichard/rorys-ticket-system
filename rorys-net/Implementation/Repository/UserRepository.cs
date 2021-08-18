using Common.Models;
using Implementation.Models;
using Implementation.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RorysEntities _dBContext;

        public UserRepository(RorysEntities dbContext)
        {
            _dBContext = dbContext;
        }

        public IEnumerable<User> GetAll()
        {
            return _dBContext.User.ToList();
        }

        public List<Role> GetRolesForUser(User user)
        {
            var foundUser = _dBContext.User.Single(u => u.Id == user.Id);

            if (foundUser == null)
            {
                return null;
            }

            var links = _dBContext.LnkRoleToUser.Where(l => l.User.Id == user.Id).ToList();

            if (links == null)
            {
                return null;
            }

            var roles = new List<Role>();
            //foreach (var link in links)
            //{
            //    roles.Add(link.Role);
            //}

            links.ToList().ForEach(f => roles.Add(f.Role));

            return roles;
        }

        public User CheckLogin(LoginCredentials loginCredentials)
        {
            var foundUser = _dBContext.User.Single(u => u.Username == loginCredentials.Username);

            if (foundUser == null)
            {
                return null;
            }

            return (foundUser.Password == loginCredentials.Password) ? foundUser : null;
        }
    }
}
