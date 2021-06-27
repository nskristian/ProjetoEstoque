using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Presentation.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
