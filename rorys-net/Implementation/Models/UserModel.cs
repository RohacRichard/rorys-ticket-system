using Implementation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Models
{
    public class UserModel
    {
        public User User { get; set; }
        public List<Role> Roles { get; set; }
    }
}
