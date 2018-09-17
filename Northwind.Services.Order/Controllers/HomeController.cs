using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Shared;

namespace Northwind.Services.Order.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public Response Index()
        {
            return new Response("order", 1);
        }
    }
}