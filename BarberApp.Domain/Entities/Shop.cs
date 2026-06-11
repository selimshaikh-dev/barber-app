using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Shop : BaseEntity
    {
        public int OwnerId { get; set; }
        public int LocationId { get; set; }

        public string ShopName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }

        public bool IsVerified { get; set; }
        public decimal RatingAvg { get; set; } = 0;
        public int TotalReviews { get; set; } = 0;

        // NAVIGATION
        public User Owner { get; set; }
        public Location Location { get; set; }
    }
}