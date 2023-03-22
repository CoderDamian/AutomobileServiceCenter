using ASC.Web.Configuration;
using ASC.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace ASC.Web.Extensions
{
    public static class MyAppServices
    {
        public static void AddMyApplicationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<ApplicationSettings>(configuration.GetSection("AppSettings"));
        }

        public static void AddMyDataBase(this IServiceCollection services)
        {
            //var connectionString = configuration.GetConnectionString("DefaultConnection");

            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            //services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDbContext<ApplicationDbContext>();
        }

        public static void AddMyIndentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }

        public static void AddAppicationServices(this IServiceCollection services)
        {
            //services.AddTransient<IEmailSender, AuthMessageSender>();
            //services.AddTransient<ISmsSender, AuthMessageSender>();
        }
    }
}
