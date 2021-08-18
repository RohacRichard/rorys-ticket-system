using Implementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Web.Controllers
{
    public class SecurityController : System.Web.Http.ApiController
    {
        private readonly ISecurityOrchestration _securityOrchestration;

        public SecurityController(ISecurityOrchestration securityOrchestration)
        {
            _securityOrchestration = securityOrchestration;
        }

        [HttpGet]
        [AllowAnonymous]
        public string Test()
        {
            var lol = _securityOrchestration.Login("a", "b");
            return "";
        }

        [HttpPost]
        [AllowAnonymous]
        public string Login([FromBody] string data)
        {
            var lol = _securityOrchestration.Login("a", "b");
            return data;
        }
    }
}
