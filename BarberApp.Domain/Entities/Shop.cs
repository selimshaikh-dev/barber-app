using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Shop : BaseEntity
    {
        public int OwnerId { get; set; }
        public User Owner { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }

        public string ShopName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }

        public bool IsVerified { get; set; }

        public decimal RatingAvg { get; set; }
        public int TotalReviews { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}