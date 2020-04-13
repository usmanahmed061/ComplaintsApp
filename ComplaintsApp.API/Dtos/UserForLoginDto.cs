using System.ComponentModel.DataAnnotations;

namespace ComplaintsApp.API.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 15.")]
        public string Password { get; set; }
    }
}