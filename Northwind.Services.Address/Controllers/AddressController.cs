using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Address.Model;

namespace NorthWind.Services.Address.Controllers
{
    [Route("")]
    public class AddressController : Controller
    {
        private static List<(int From, int To)> Area { get; set; }

        static AddressController()
        {
            Area = new List<(int From, int To)>();
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
        }

        [HttpPost("validate")]
        public ValidationResponse Post([FromBody] ValidationRequest request)
        {
            var result = new ValidationResponse();

            try
            {
                result.Status = !string.IsNullOrEmpty(request.Address) && request.Country.ToLower().Equals("australia");

                if (result.Status)
                    result.Status = Area.Where(i => request.Zip >= i.From && request.Zip <= i.To).Count() >= 1;

                if (!result.Status)
                    result.Message = "address not valid or supported. currently supporting only australian areas of central and northen sydney";
            }
            catch (Exception e)
            {
                result.Status = false;
                result.Message = e.Message;
            }

            return result;
        }
    }
}