namespace Peoples.Infrastructure.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddProfilePersistance(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = new NpgsqlConnectionStringBuilder
        {
            ConnectionString = configuration.GetConnectionString("Profile"),
            Username = configuration["UserID"],
            Password = configuration["Password"]
        }
        .ConnectionString;

        services.AddDbContext<GtProfileDbContext>(o => o.UseNpgsql(connectionString));

        return services;
    }
}
