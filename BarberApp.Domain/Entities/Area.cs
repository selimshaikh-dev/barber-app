using BarberApp.Domain.Common;
using BarberApp.Domain.Entities;

public class Area : BaseEntity
{
    public string Name { get; set; }

    public int ThanaId { get; set; }
    public Thana Thana { get; set; }

    public ICollection<Shop> Shops { get; set; }

    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

}