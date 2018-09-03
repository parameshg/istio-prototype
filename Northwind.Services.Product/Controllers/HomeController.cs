using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Product.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "product", version = 1, timestamp = DateTime.Now });
        }
    }
}