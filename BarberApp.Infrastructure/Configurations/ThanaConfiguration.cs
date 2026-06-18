using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class ThanaConfiguration : IEntityTypeConfiguration<Thana>
    {
        public void Configure(EntityTypeBuilder<Thana> builder)
        {
            builder.ToTable("Thanas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(x => x.District)
                .WithMany(x => x.Thanas)
                .HasForeignKey(x => x.DistrictId);

            builder.HasIndex(x => x.DistrictId);
        }
    }
}