using ASC.Web.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ASC.Web.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IOptions<ApplicationSettings> settings;

        public DashboardController(IOptions<ApplicationSettings> settings)
        {
            this.settings = settings;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
