using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation_Layer.Controllers
{
    public class WinnerController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
