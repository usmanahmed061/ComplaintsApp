using System.Security.Claims;
using System.Text;
using ComplaintsApp.API.Data;
using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Models;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens;
using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace ComplaintsApp.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;
        private readonly IAuthRepository _repo;
        public AuthService(IAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }
        public LoggedInUserDto Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = _repo.Login(userForLoginDto.Username, userForLoginDto.Password);

            if (userFromRepo != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier , userFromRepo.Id.ToString()),
                    new Claim(ClaimTypes.Name , userFromRepo.Username)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8
                    .GetBytes(_config.GetSection("AppSettings:Token").Value));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = creds
                };

                var tokenHandler = new JwtSecurityTokenHandler();

                var token = tokenHandler.CreateToken(tokenDescriptor);

                // We can use AutoMapper to return only those info that is required.    

                var returnObj = new LoggedInUserDto
                {
                    Token = tokenHandler.WriteToken(token),
                    User = userFromRepo
                };

                return returnObj;
            }

            return null;
        }
    }
}