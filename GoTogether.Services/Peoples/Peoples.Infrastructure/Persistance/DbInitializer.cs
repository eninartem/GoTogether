namespace Peoples.Infrastructure.Persistance;

public class DbInitializer
{
    public static void Initialize(GtProfileDbContext context)
    {
        context.Database.EnsureCreated();
    }
}
