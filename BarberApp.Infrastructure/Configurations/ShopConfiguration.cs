using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shops");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ShopName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.Property(x => x.Address)
                .HasMaxLength(250);

            builder.Property(x => x.RatingAvg)
                .HasPrecision(3, 2)
                .HasDefaultValue(0);

            builder.Property(x => x.TotalReviews)
                .HasDefaultValue(0);

            builder.Property(x => x.IsVerified)
                .HasDefaultValue(false);

            builder.HasOne(x => x.Owner)
                .WithMany()
                .HasForeignKey(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Area)
                .WithMany(x => x.Shops)
                .HasForeignKey(x => x.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.OwnerId);
            builder.HasIndex(x => x.AreaId);
        }
    }
}