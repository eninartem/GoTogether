namespace Places.Infrastructure.Persistance;

public class DbInitializer
{
    public static void Initialize(GtPlaceDbContext context)
    {
        context.Database.EnsureCreated();
    }
}