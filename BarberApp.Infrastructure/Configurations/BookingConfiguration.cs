using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalAmount)
                .HasPrecision(10, 2)
                .HasDefaultValue(0);

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.BookingDate)
                .IsRequired();

            builder.Property(x => x.BookingTime)
                .IsRequired();

            builder.Property(x => x.StartDateTime)
                .IsRequired();

            builder.Property(x => x.EndDateTime)
                .IsRequired();

            builder.Property(x => x.EstimatedDurationMinutes)
                .IsRequired();

            builder.Property(x => x.Notes)
                .HasMaxLength(500);

            builder.HasOne(x => x.Client)
                .WithMany()
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Shop)
                .WithMany()
                .HasForeignKey(x => x.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(x => x.ClientId);
            builder.HasIndex(x => x.ShopId);
            builder.HasIndex(x => x.Status);
            builder.HasIndex(x => x.StartDateTime);
        }
    }
}