﻿using Microsoft.AspNetCore.Mvc;

namespace MetricaAdminPanel.Authentication.Controllers
{
    public class Error404AltController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
