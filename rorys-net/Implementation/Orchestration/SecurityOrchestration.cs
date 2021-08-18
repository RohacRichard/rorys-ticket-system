using Common.Models;
using Implementation.Interface;
using Implementation.Models;
using Implementation.Repository;
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

        public UserModel Login(LoginCredentials loginCredentials)
        {
            var user = _userRepository.CheckLogin(loginCredentials);

            if (user == null)
            {
                return null;
            }

            return new UserModel
            {
                User = user,
                Roles = _userRepository.GetRolesForUser(user)
            };
        }
    }
}
