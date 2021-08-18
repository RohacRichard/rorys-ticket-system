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
    }
}
