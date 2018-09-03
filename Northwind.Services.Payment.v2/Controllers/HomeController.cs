using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Payment.v2.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "payment", version = 2, timestamp = DateTime.Now });
        }
    }
}