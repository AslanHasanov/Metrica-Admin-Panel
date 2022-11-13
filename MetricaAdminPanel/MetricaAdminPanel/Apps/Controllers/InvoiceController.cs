using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Apps.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
