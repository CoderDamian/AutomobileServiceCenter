using ASC.Business.Contracts;
using ASC.Web.Extensions;
using ASC.Web.Logger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMyApplicationSettings(builder.Configuration);
builder.Services.AddMyDataBase();
builder.Services.AddMyIndentity();
builder.Services.AddMyLogging();

ILoggerFactory loggerFactory = new();
ILogDataOperations logDataOperations = new();
// Configure Azure Logger to log all events except the ones that are generated by default by ASP.NET Core
    loggerFactory.AddAzureTableStorageLog(logDataOperations, (categoryName, logLevel) => !categoryName.Contains("Microsoft") && logLevel >= LogLevel.Information);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

//app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
