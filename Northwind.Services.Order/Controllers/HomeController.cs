using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Order.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "order", version = 1, timestamp = DateTime.Now });
        }
    }
}