using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Dtos
{
    public class LoggedInUserDto
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}