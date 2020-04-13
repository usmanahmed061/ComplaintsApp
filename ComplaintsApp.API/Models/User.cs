using System;

namespace ComplaintsApp.API.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }    
        public string Country { get; set; }
    }
}