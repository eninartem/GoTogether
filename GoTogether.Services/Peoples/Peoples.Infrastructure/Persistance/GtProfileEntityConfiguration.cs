using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Peoples.Domain;

namespace Peoples.Infrastructure.Persistance;

public class GtProfileEntityConfiguration : IEntityTypeConfiguration<GtProfile>
{
    public void Configure(EntityTypeBuilder<GtProfile> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.Id).IsUnique();

        builder.Property(p => p.Id).IsRequired();

        builder.Property(p => p.AppUserId).ValueGeneratedNever();

        builder.Property(p => p.LocationId).ValueGeneratedNever();

        builder.Property(p => p.NickName).IsRequired().HasMaxLength(50);

        builder.Property(p => p.Age).IsRequired().HasMaxLength(3);

        builder.Property(p => p.About).HasMaxLength(500);
    }
}
