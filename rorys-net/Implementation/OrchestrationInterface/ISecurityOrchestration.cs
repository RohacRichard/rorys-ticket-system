using Common.Models;
using Implementation.Models;
using Implementation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Interface
{
    public interface ISecurityOrchestration
    {
        UserModel Login(LoginCredentials loginCredentials);
    }
}
