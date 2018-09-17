using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Shared;

namespace Northwind.Services.Product.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public Response Index()
        {
            return new Response("product", 1);
        }
    }
}