using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class LockScreenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
