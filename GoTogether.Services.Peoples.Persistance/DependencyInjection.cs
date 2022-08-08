using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Npgsql;

namespace GoTogether.Services.Peoples.Persistance;

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

        services.AddDbContext<ProfileDbContext>(o => o.UseNpgsql(connectionString));

        return services;
    }
}
