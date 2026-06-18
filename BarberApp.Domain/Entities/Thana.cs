using BarberApp.Domain.Common;

public class Thana : BaseEntity
{
    public string Name { get; set; }

    public int DistrictId { get; set; }
    public District District { get; set; }

    public ICollection<Area> Areas { get; set; }
}