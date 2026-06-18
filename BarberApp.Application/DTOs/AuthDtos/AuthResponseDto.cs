using BarberApp.Domain.Enums;

namespace BarberApp.Application.DTOs.AuthDtos
{
    public class AuthResponseDto
    {
        public int UserId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;

        public UserRole Role { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
