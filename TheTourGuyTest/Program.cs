using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TheTourGuyTest.Core.Mappings;
using TheTourGuyTest.Core.Repositories.Implementations;
using TheTourGuyTest.Core.Repositories.Interfaces;
using TheTourGuyTest.Core.Services.Implementations;
using TheTourGuyTest.Core.Services.Interfaces;
using TheTourGuyTest.Core.Validators;
using TheTourGuyTest.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddControllersWithViews();

builder
    .Services
    .AddSingleton(sp =>
    {
        return new DbContextOptionsBuilder<TheTourGuyDbContext>()
                .UseSqlServer(builder.Configuration.GetConnectionString("TheTourGuyDb"))                
                .Options;
    });

builder
    .Services
    .AddDbContext<TheTourGuyDbContext>();

builder.Services.AddScoped<IPersonsRepository, PersonsRepository>();
builder.Services.AddScoped<IPersonsService, PersonsService>();

builder.Services.AddAutoMapper(typeof(PersonsMappingProfile));
builder.Services.AddValidatorsFromAssemblyContaining<CreatePersonRequestValidator>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    //Migrate database on app startup
    var dbContext = scope.ServiceProvider.GetService<TheTourGuyDbContext>();
    dbContext.Migrate();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
