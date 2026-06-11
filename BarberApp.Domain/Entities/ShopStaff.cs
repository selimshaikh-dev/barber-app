using BarberApp.Domain.Common;
using BarberApp.Domain.Enums;

namespace BarberApp.Domain.Entities
{
    public class ShopStaff : BaseEntity
    {
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public StaffType StaffType { get; set; }
        // Barber / Assistant

        public string? Speciality { get; set; }
        public int ExperienceYears { get; set; }

        public bool IsPrimaryBarber { get; set; }

        public User User { get; set; }
        public Shop Shop { get; set; }
    }
}