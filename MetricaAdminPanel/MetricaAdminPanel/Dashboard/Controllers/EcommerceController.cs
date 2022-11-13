using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Dashboard.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
