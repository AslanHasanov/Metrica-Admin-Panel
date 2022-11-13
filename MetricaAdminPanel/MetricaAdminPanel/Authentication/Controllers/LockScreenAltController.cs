using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class LockScreenAltController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
