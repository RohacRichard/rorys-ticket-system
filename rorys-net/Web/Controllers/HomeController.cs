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
        [Route("api/home/token")]
        [JwtAuthentication]
        public string Get()
        {
            return "OK";
        }

        [HttpGet]
        [Route("api/home/jwt")]
        [AllowAnonymous]
        public string JWTTest()
        {
            //IAuthContainerModel model = GetJWTContainerModel("Richard Rohac", "richardrohac496@gmail.com");
            //IAuthService authService = new JWTService(model.SecretKey);

            //string token = authService.GenerateToken(model);

            //if (!authService.IsTokenValid(token))
            //{
            //    throw new UnauthorizedAccessException();
            //}
            //else
            //{
            //    List<Claim> claims = authService.GetTokenClaims(token).ToList();

            //    Debug.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Name)).Value);
            //    Debug.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Email)).Value);
            //}

            return JWTManager.GenerateToken("richard.rohac");
        }

        
    }
}
