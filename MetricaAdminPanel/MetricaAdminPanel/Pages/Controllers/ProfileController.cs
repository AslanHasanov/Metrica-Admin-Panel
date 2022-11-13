using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Pages.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
