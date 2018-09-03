using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Payment.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "payment", version = 1, timestamp = DateTime.Now });
        }
    }
}