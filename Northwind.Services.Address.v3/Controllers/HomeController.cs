using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Services.Address.v3.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return new OkObjectResult(new { api = "address", version = 3, timestamp = DateTime.Now });
        }
    }
}