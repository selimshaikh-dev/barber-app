using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Country { get; set; } = "Bangladesh";
        public string District { get; set; }
        public string Thana { get; set; }
        public string Area { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}