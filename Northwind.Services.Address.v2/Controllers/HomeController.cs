using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Shared;

namespace Northwind.Services.Address.v2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public Response Index()
        {
            return new Response("address", 2);
        }
    }
}