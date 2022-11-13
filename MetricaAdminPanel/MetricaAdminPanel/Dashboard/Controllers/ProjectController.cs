using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Dashboard.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
