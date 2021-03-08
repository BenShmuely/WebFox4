using System.Net;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers
{
    public class SecureCookieTest2: ControllerBase
    {
        
        [HttpGet("request")]
        [HttpGet("response")]
        
        // HttpCookie myCookie = new HttpCookie("Sensitive cookie");
        public void Unsafe(HttpWebResponse response, HttpWebRequest request)
        {
            string password = "p-" + RandomNumberGenerator.GetInt32(200000000, 2000000000);
            response.Cookies.Add(new Cookie("password", password));
        }
    }
}