

namespace Places.Infrastructure.Persistance;

public class GtPlaceEntityConfiguration : IEntityTypeConfiguration<GtPlace>
{
    public void Configure(EntityTypeBuilder<GtPlace> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.LocationId).ValueGeneratedNever();
        builder.Property(x => x.LocationId).IsRequired();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Address).HasMaxLength(250);

        builder.HasOne<GtLocation>(x => x.Location)
            .WithMany(l => l.GtPlaces)
            .HasForeignKey(k => k.LocationId);

        builder.Property(x => x.Description).HasMaxLength(500);
    }
}
