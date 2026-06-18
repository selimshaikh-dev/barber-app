using BarberApp.Domain.Common;

public class District : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Thana> Thanas { get; set; }
}