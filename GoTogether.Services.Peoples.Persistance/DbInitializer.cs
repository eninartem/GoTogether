namespace GoTogether.Services.Peoples.Persistance;

public class DbInitializer
{
    public static void Initialize(ProfileDbContext context)
    {
        context.Database.EnsureCreated();
    }
}
