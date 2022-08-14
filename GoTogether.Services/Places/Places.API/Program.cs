using Places.Infrastructure.Persistance;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddPlacePersistance(builder.Configuration);

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(e => e.MapControllers());
app.Run();
