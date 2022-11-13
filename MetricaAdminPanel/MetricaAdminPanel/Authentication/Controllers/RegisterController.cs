using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
