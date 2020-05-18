using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GITTESTWeb001.Models;

namespace GITTESTWeb001.Controllers
{
    public class GuiController : Controller
    {
        private readonly ILogger<GuiController> _logger;

        public GuiController(ILogger<GuiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }       
    }
}
