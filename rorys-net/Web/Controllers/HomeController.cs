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
        //[Route("api/home/token")]
        [JwtAuthentication]
        public string Token()
        {
            return "OK";
        }

        [HttpGet]
        //[Route("api/home/jwt")]
        [AllowAnonymous]
        public string JWT()
        {
            return JWTManager.GenerateToken("richard.rohac");
        }
    }
}
