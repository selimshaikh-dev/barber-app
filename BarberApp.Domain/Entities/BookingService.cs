
using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class BookingService : BaseEntity
    {
        public int BookingId { get; set; }
        public int ServiceId { get; set; }

        public decimal Price { get; set; }

        public Booking Booking { get; set; }
        public Service Service { get; set; }
    }
}