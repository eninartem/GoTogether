using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Npgsql;

namespace Places.Infrastructure.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPlacePersistance(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = new NpgsqlConnectionStringBuilder
        {
            ConnectionString = configuration.GetConnectionString("Place"),
            Username = configuration["UserID"],
            Password = configuration["Password"]
        }
        .ConnectionString;

        services.AddDbContext<GtPlaceDbContext>(o => o.UseNpgsql(connectionString));

        return services;
    }
}
