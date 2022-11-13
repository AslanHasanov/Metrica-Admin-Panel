using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Dashboard.Controllers
{
    public class HelpdeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
