using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class AvailabilitySlotConfiguration : IEntityTypeConfiguration<AvailabilitySlot>
    {
        public void Configure(EntityTypeBuilder<AvailabilitySlot> builder)
        {
            builder.ToTable("AvailabilitySlots", t =>
            {
                t.HasCheckConstraint(
                    "CK_AvailabilitySlot_TimeRange",
                    "[EndTime] > [StartTime]"
                );
            });

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DayOfWeek)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.StartTime)
                .IsRequired();

            builder.Property(x => x.EndTime)
                .IsRequired();

            builder.HasOne(x => x.Staff)
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Shop)
                .WithMany()
                .HasForeignKey(x => x.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.StaffId);
            builder.HasIndex(x => x.ShopId);
            builder.HasIndex(x => x.DayOfWeek);
            builder.HasIndex(x => new { x.StaffId, x.DayOfWeek });
        }
    }
}
