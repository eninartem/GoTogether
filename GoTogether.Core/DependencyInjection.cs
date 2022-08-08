using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Npgsql;

namespace GoTogether.Services.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance<T>(this IServiceCollection services, IConfiguration configuration) where T : DbContext
        {
            var connectionString = new NpgsqlConnectionStringBuilder
            {
                ConnectionString = configuration.GetConnectionString(nameof(T)),
                Username = configuration["UserID"],
                Password = configuration["Password"]
            }
            .ConnectionString;

            services.AddDbContext<T>(o => o.UseNpgsql(connectionString));

            return services;
        }
    }
}
