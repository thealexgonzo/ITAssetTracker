var builder = WebApplication.CreateBuilder(args);

// AddAsync services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();

//// AddAsync services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddApplicationServices();

// Get the connection string
//string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

//// AddAsync the connection string this way? In ASP.NET this is how it's done
//builder.Services.AddDbContext<ITAssetTrackerContext>(options => options.UseSqlite(connectionString));

////builder.Services.AddScoped<ISupportTicketService, SupportTicketService>();
////builder.Services.AddScoped<ISupportTicketRepository, EFSupportTicketRepository>();
////builder.Services.AddScoped(provider => new SupportTicketService(new EFSupportTicketRepository()));

//builder.AddSupportTicketRepositories();
//builder.AddAssetRepositories();
//builder.AddAssetProductRepositories();
//builder.AddAssetTypeRepository();
//builder.AddCategoryRespository();
//builder.AddAssetStatusRepository();
//builder.AddAssetHistoryRepository();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseRouting();

//app.UseAuthorization();

//app.MapStaticAssets();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}")
//    .WithStaticAssets();


app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
