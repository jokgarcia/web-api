using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Core.Controllers
{
    
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost("token")]
        public IActionResult Token()
        {
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credential = header.ToString().Substring("Basic".Length).Trim();
                var userNamePassCred = Encoding.UTF8.GetString(Convert.FromBase64String(credential));
                var userNamePass = userNamePassCred.Split(":");
                
                //Check in DB
                if(userNamePass[0] == "Admin@email.com" && userNamePass[1] == "Pass")
                {
                    var claimsData = new[] { new Claim(ClaimTypes.Name, userNamePass[0]) };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mycompanykeydafsfsdfsfsfs"));
                    //Sign the Key
                    var signedCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                            issuer: "mycompany.com",
                            audience: "mycompany.com",
                            expires: DateTime.Now.AddMinutes(1),
                            claims: claimsData,
                            signingCredentials: signedCredential
                        );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(tokenString);
                }
                
            }
            return BadRequest("Wrong Request");
        }
    }
}
