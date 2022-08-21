namespace Peoples.Infrastructure.Persistance;

public class GtProfileEntityConfiguration : IEntityTypeConfiguration<GtProfile>
{
    public void Configure(EntityTypeBuilder<GtProfile> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.Id).IsUnique();
        builder.Property(p => p.Id).IsRequired();

        builder.Property(p => p.AppUserId).ValueGeneratedNever();
        builder.Property(x => x.LocationId).IsRequired();
        builder.Property(p => p.LocationId).ValueGeneratedNever();
        builder.HasOne<GtLocation>(l => l.Location)
            .WithMany(p => p.GtProfiles)
            .HasForeignKey(p => p.LocationId);

        builder.Property(p => p.NickName).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Age).HasMaxLength(3);
        builder.Property(p => p.About).HasMaxLength(500);
        builder.Property(p => p.EMail).IsRequired().HasMaxLength(50);
    }
}
