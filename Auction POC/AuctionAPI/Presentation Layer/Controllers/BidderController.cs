using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Presentation_Layer.Controllers
{
    public class BidderController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
