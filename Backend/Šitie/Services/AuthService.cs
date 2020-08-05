using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Šitie.Dtos;
using Šitie.Models;
using Šitie.Services.Interfaces;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace Šitie.Services
{
    public class AuthService : IAuthService
    {
        private IConfiguration _config;
        private readonly AppDbContext dbContext;

        public AuthService(AppDbContext dbContext, IConfiguration config)
        {
            this.dbContext = dbContext;
            _config = config;
        }

        public string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMonths(12),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public User AuthenticateUser(LoginDto login)
        {
            User user = null;
            user = dbContext.Users.Where(a => a.Email == login.Email && a.Password == login.Password).SingleOrDefault();
            return user;
        }
    }
}
