using ITAssetTracker.Infrastructure;
using ITAssetTracker.MVC.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Get the connection string
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Add the connection string this way? In ASP.NET this is how it's done
builder.Services.AddDbContext<ITAssetTrackerContext>(options => options.UseSqlite(connectionString));

//builder.Services.AddScoped<ISupportTicketService, SupportTicketService>();
//builder.Services.AddScoped<ISupportTicketRepository, EFSupportTicketRepository>();
//builder.Services.AddScoped(provider => new SupportTicketService(new EFSupportTicketRepository()));

builder.AddSupportTicketRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
