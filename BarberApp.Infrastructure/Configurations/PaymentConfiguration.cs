using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(x => x.Currency)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.PaymentMethod)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.PaymentStatus)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.Gateway)
                .HasConversion<string>();

            builder.Property(x => x.TransactionId)
                .HasMaxLength(100);

            builder.Property(x => x.GatewayTransactionId)
                .HasMaxLength(150);

            builder.Property(x => x.Remarks)
                .HasMaxLength(500);

            builder.HasOne(x => x.Booking)
                .WithMany()
                .HasForeignKey(x => x.BookingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.BookingId);

            builder.HasIndex(x => x.UserId);

            builder.HasIndex(x => x.PaymentStatus);

            builder.HasIndex(x => x.TransactionId);

            builder.HasIndex(x => new { x.UserId, x.PaymentStatus });
        }
    }
}