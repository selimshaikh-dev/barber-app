using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ServiceName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(x => x.DurationMinutes)
                .IsRequired();

            builder.HasOne(x => x.Shop)
                .WithMany()
                .HasForeignKey(x => x.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.ShopId);
            builder.HasIndex(x => x.ServiceName);
        }
    }
}