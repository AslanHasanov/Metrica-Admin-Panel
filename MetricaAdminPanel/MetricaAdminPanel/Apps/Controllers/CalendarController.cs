using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Apps.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
