using Implementation.Interface;
using Implementation.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Orchestration
{
    public class SecurityOrchestration : ISecurityOrchestration
    {
        private readonly IUserRepository _userRepository;

        public SecurityOrchestration(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string Login(string username, string password)
        {
            var pepe = _userRepository.GetAll();
            return "";
        }
    }
}
