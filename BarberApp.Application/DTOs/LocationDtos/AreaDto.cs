namespace BarberApp.Application.DTOs.LocationDtos
{
    public class AreaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ThanaId { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}