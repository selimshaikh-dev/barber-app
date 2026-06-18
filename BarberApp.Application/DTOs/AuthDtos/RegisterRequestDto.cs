namespace BarberApp.Application.DTOs.AuthDtos
{
    public class RegisterRequestDto
    {
        public required string FullName { get; set; }

        public required string MobileNumber { get; set; }

        public required string Password { get; set; }

        public required string ConfirmPassword { get; set; }
    }
}