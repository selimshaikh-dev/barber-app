using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(100)
                .HasDefaultValue("Bangladesh");

            builder.Property(x => x.District)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Thana)
                .HasMaxLength(100);

            builder.Property(x => x.Area)
                .HasMaxLength(150);

            builder.Property(x => x.Latitude)
                .HasPrecision(9, 6);

            builder.Property(x => x.Longitude)
                .HasPrecision(9, 6);

            builder.HasIndex(x => x.District);
            builder.HasIndex(x => x.Thana);
            builder.HasIndex(x => x.Area);
        }
    }
}