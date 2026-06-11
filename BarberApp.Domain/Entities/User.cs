using BarberApp.Domain.Common;
using BarberApp.Domain.Enums;

namespace BarberApp.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string? Email { get; set; }
        public string PasswordHash { get; set; }

        public UserRole Role { get; set; }

        public string? ProfileImage { get; set; }
    }
}