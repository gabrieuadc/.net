using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using padrao.Models;

namespace padrao.Authent{

    public static class TokenService{
        
        public static string GenerateToken(UsuarioModel usuarioModel){
            var tokenHandler = new JwtSecurityTokenHandler();
            var key= Encoding.ASCII.GetBytes("1212312fsdfsdf54s6f5s");
            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(new []{
                    new Claim(ClaimTypes.Name, usuarioModel.Nome.ToString()),
                }),
                Expires= DateTime.UtcNow.AddHours(8),
                SigningCredentials= new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
        }

    // public IActionResult Login([FromBody] LoginModel model)
    // {
        // if (model == null)
        // {
        //     return BadRequest("Invalid client request");
        // }

        // if (model.UserName == "usuario" && model.Password == "senha")
        // {
            // var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("chave-super-secreta-aqui"));
            // var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            // var claims = new List<Claim>
            // {
            //     new Claim(ClaimTypes.Name, model.UserName),
            //     new Claim(ClaimTypes.Role, "Admin")
            // };

            // var tokeOptions = new JwtSecurityToken(
            //     issuer: "https://seu-site.com",
            //     audience: "https://seu-site.com",
            //     claims: claims,
            //     expires: DateTime.Now.AddMinutes(30),
            //     signingCredentials: signinCredentials
            // );

            // var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

        //     return Ok(new { Token = tokenString });
        // }
        // else
        // {
        //     return Unauthorized();
        // }
    // }


    }

}