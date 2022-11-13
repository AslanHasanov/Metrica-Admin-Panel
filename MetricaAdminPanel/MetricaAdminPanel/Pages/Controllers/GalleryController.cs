using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Pages.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
