using System;
using System.Threading.Tasks;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        public User Login(string username, string password)
        {
            var user = new User {
                Id = Guid.NewGuid(),
                Username = "j.doe",
                Name = "John Doe",
                Email = "jd@mail.com",
                City = "Islamabad",
                Country = "Pakistan"
            };
           
           // Here simply i have returned the user, In real world scinerio We would check for the user first on basis of username
           // if user exist in our App than we can check the credentials by checking is Password provided compairing it with
           // PasswordHash and PasswordSalt against the specific user
           return user;
        }
    }
}