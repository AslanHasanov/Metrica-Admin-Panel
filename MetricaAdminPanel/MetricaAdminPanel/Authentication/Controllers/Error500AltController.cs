using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class Error500AltController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
