using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Service : BaseEntity
    {
        public int ShopId { get; set; }

        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }

        public Shop Shop { get; set; }
    }
}