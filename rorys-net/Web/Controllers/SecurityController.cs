using Common.Models;
using Implementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.JWT;

namespace Web.Controllers
{
    public class SecurityController : System.Web.Http.ApiController
    {
        private readonly ISecurityOrchestration _securityOrchestration;

        public SecurityController(ISecurityOrchestration securityOrchestration)
        {
            _securityOrchestration = securityOrchestration;
        }

        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Login([FromBody] LoginCredentials loginCredentials)
        {           
            var userResult = _securityOrchestration.Login(loginCredentials);
            if (userResult == null)
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }

            var newJwtToken = JWTManager.GenerateToken(userResult);

            return Request.CreateResponse(HttpStatusCode.OK, newJwtToken);
        }
    }
}
