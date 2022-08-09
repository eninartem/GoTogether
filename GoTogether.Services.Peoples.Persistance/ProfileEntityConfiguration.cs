using GoTogether.Services.Peoples.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoTogether.Services.Peoples.Persistance;

public class ProfileEntityConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.Id).IsUnique();

        builder.Property(p => p.Id).IsRequired();

        builder.Property(p => p.LocationId).ValueGeneratedNever();

        builder.Property(p => p.NickName).IsRequired().HasMaxLength(50);

        builder.Property(p => p.Age).IsRequired().HasMaxLength(3);

        builder.Property(p => p.About).HasMaxLength(500);
    }
}
