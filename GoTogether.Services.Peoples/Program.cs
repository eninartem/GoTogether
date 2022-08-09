using GoTogether.Services.Peoples.Persistance;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddProfilePersistance(builder.Configuration);
var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.UseRouting();
app.UseEndpoints(e => e.MapControllers());

app.Run();
