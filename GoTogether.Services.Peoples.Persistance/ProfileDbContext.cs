using GoTogether.Services.Peoples.Domain;

using Microsoft.EntityFrameworkCore;

namespace GoTogether.Services.Peoples.Persistance;

public class ProfileDbContext : DbContext
{
    public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options) { }

    public DbSet<Profile> Profiles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ProfileEntityConfiguration());
        base.OnModelCreating(builder);
    }
}
