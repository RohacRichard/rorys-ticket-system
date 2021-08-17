using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using Web.JWT;

namespace Web.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [JwtAuthentication]
        public string Token()
        {
            return "OK";
        }

        [HttpGet]
        [AllowAnonymous]
        public string JWT()
        {
            return JWTManager.GenerateToken("richard.rohac");
        }
    }
}
