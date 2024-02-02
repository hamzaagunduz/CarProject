﻿using Microsoft.AspNetCore.Mvc;

namespace CarProject.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımızda";
            ViewBag.v2 = "Vizyonumuz ve Hedeflerimiz";
            return View();
        }
    }
}
