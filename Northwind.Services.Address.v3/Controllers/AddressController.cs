using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Address.v3.Model;
using Northwind.Services.Shared;

namespace NorthWind.Services.Address.v3.Controllers
{
    [Route("")]
    public class AddressController : Controller
    {
        private static List<(int From, int To)> Area { get; set; }

        static AddressController()
        {
            Area = new List<(int From, int To)>();
            // Central & Northern Sydney
            Area.Add((2000, 2019));
            Area.Add((2021, 2037));
            Area.Add((2042, 2044));
            Area.Add((2048, 2048));
            Area.Add((2050, 2050));
            Area.Add((2052, 2114));
            Area.Add((2119, 2122));
            Area.Add((2126, 2126));
            Area.Add((2159, 2159));
            Area.Add((2204, 2204));
            // Western Sydney & Blue Mountains
            Area.Add((2038, 2041));
            Area.Add((2045, 2047));
            Area.Add((2115, 2118));
            Area.Add((2123, 2125));
            Area.Add((2127, 2128));
            Area.Add((2137, 2140));
            Area.Add((2142, 2142));
            Area.Add((2160, 2160));
            Area.Add((2745, 2751));
            Area.Add((2753, 2786));
            // Bug Fix
            Area.Add((2144, 2158));
        }

        [HttpGet("validate")]
        public Response Index()
        {
            return new Response("address/validate", 3);
        }

        [HttpPost("validate")]
        public Response<ValidationResponse> Post([FromBody] ValidationRequest request)
        {
            var result = new Response<ValidationResponse>("address/validate", 3);

            result.Data = new ValidationResponse();

            try
            {
                result.Data.Status = !string.IsNullOrEmpty(request.Address) && request.Country.ToLower().Equals("australia");

                if (result.Data.Status)
                    result.Data.Status = Area.Where(i => request.Zip >= i.From && request.Zip <= i.To).Count() >= 1;

                if (!result.Data.Status)
                    result.Data.Message = "address not valid or supported. currently supporting only australian areas of sydney (central, northern, western) and blue mountains";
            }
            catch (Exception e)
            {
                result.Data.Status = false;
                result.Data.Message = e.Message;
            }

            return result;
        }
    }
}