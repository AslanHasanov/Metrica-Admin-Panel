using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
