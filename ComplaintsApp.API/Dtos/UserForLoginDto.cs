using System.ComponentModel.DataAnnotations;

namespace ComplaintsApp.API.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}