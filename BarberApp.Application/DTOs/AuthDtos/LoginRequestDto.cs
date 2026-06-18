using System.ComponentModel.DataAnnotations;

namespace BarberApp.Application.DTOs.AuthDtos
{
    public class LoginRequestDto
    {
        [Required]
        [MaxLength(20)]
        public string MobileNumber { get; set; }

        [Required]
        public string Password { get; set; }
    }
}