using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Address.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "address", version = 1, timestamp = DateTime.Now });
        }
    }
}