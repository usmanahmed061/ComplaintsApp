using System.ComponentModel.DataAnnotations;

namespace ComplaintsApp.API.Dtos
{
    public class LogComplaintDto
    {
        [Required]
        [MaxLength(100)]
        public string Subject { get; set; }
        
        [Required]
        [MaxLength(1000)]
        public string Detail { get; set; }

        [Required]
        public string CreatedBy { get; set; }
    }
}