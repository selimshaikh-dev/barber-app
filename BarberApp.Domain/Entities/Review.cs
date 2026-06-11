using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Review : BaseEntity
    {
        public int ShopId { get; set; }
        public int ClientId { get; set; }
        public int? BookingId { get; set; }

        public int Rating { get; set; }
        public string? Comment { get; set; }

        public Shop Shop { get; set; }
        public User Client { get; set; }
    }
}