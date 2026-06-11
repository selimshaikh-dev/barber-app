using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class ShopStaffConfiguration : IEntityTypeConfiguration<ShopStaff>
    {
        public void Configure(EntityTypeBuilder<ShopStaff> builder)
        {
            builder.ToTable("ShopStaffs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StaffType)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.Speciality)
                .HasMaxLength(200);

            builder.Property(x => x.ExperienceYears)
                .HasDefaultValue(0);

            builder.Property(x => x.IsPrimaryBarber)
                .HasDefaultValue(false);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Shop)
                .WithMany()
                .HasForeignKey(x => x.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => new { x.UserId, x.ShopId })
                .IsUnique();

            builder.HasIndex(x => x.ShopId);

            builder.HasIndex(x => x.UserId);

            builder.HasIndex(x => x.StaffType);

            builder.HasIndex(x => new { x.ShopId, x.StaffType });
        }
    }
}