namespace BarberApp.Application.DTOs
{
    public class ShopDto
    {
        public int Id { get; set; }

        public string ShopName { get; set; }

        public string? Description { get; set; }

        public string? Address { get; set; }

        public bool IsVerified { get; set; }

        public decimal RatingAvg { get; set; }

        public int TotalReviews { get; set; }

        public int AreaId { get; set; }
        public string? AreaName { get; set; }

        public int ThanaId { get; set; }
        public string? ThanaName { get; set; }

        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}