using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Pages.Controllers
{
    public class StarterPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
