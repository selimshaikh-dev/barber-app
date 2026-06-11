using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable("Media");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.EntityType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.EntityId)
                .IsRequired();

            builder.Property(x => x.MediaUrl)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.MediaType)
                .IsRequired()
                .HasConversion<string>();

            builder.HasIndex(x => new { x.EntityType, x.EntityId });

            builder.HasIndex(x => x.MediaType);
        }
    }
}