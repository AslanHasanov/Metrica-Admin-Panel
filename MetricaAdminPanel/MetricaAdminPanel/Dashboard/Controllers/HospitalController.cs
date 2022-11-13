using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Dashboard.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
