using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class LogInAltController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
