using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Apps.Controllers
{
    public class ContactListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
