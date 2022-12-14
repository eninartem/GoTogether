namespace Places.Infrastructure.Persistance;

public class GtLocationEntityConfiguration : IEntityTypeConfiguration<GtLocation>
{
    public void Configure(EntityTypeBuilder<GtLocation> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.Country).IsRequired();
        builder.Property(x => x.Country).HasMaxLength(50);

        builder.Property(x => x.City).HasMaxLength(50);

        builder.HasData(new GtLocation[]
        {
            new GtLocation
            {
                Id = Guid.NewGuid(),
                Country = "Russia",
                City = "Samara"
            },
            new GtLocation
            {
                Id = Guid.NewGuid(),
                Country = "Russia",
                City = "Togliatty"
            }
        });
    }
}
