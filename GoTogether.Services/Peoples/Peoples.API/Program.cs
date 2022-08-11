using Microsoft.AspNetCore.Authentication.JwtBearer;

using Peoples.Application.Contracts.DbContext;
using Peoples.Application.Features;
using Peoples.Infrastructure.Persistance;

using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(c =>
{
    c.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    c.AddProfile(new AssemblyMappingProfile(typeof(IGtProfileDbContext).Assembly));
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, c =>
    {
        c.Authority = "https://localhost:5055";
        c.Audience = "PeoplesAPI";
    });

builder.Services.AddControllers();
builder.Services.AddHttpClient();

builder.Services.AddProfilePersistance(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(e => e.MapControllers());

app.Run();
