using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Address.v2.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "address", version = 2, timestamp = DateTime.Now });
        }
    }
}