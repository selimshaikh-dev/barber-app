using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Chat : BaseEntity
    {
        public int BookingId { get; set; }

        public Booking Booking { get; set; }
    }
}