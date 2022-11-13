using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Apps.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
