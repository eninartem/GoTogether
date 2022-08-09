namespace GoTogether.Services.Peoples.Infrastructure;

public class DbInitializer
{
    public static void Initialize(ProfileDbContext context)
    {
        context.Database.EnsureCreated();
    }
}
