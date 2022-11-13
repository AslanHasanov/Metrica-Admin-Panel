using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Pages.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
