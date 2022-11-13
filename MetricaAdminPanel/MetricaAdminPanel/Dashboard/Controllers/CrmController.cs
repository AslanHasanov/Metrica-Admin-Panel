using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Dashboard.Controllers
{
    public class CrmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
