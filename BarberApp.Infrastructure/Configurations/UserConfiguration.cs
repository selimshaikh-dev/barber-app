using BarberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberApp.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(120);

            builder.Property(x => x.MobileNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(x => x.MobileNumber)
                .IsUnique();

            builder.Property(x => x.Email)
                .HasMaxLength(150);

            builder.HasIndex(x => x.Email)
                .IsUnique()
                .HasFilter("[Email] IS NOT NULL"); 

            builder.Property(x => x.Role)
                .IsRequired()
                .HasConversion<string>(); 

            builder.Property(x => x.PasswordHash)
                .IsRequired();

            builder.Property(x => x.ProfileImage)
                .HasMaxLength(255);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);
        }
    }
}