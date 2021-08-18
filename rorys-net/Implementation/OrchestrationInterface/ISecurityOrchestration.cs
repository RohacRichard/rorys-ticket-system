using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Interface
{
    public interface ISecurityOrchestration
    {
        string Login(string username, string password);
    }
}
