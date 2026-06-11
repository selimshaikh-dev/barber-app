using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class AvailabilitySlot : BaseEntity
    {
        public int StaffId { get; set; }
        public int ShopId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public User Staff { get; set; }
        public Shop Shop { get; set; }
    }
}