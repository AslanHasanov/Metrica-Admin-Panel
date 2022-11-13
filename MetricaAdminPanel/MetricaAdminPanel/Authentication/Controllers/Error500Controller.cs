using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class Error500Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
