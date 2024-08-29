﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize(Policy = "AdminPolicy")] //bunu yazmasak hata alırız! 
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}