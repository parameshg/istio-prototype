using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Order.Model;
using RestSharp;

namespace NorthWind.Services.Order.Controllers
{
    [Route("")]
    public class OrderController : Controller
    {
        [HttpPost("order")]
        public OrderResponse Post([FromBody] OrderRequest order)
        {
            var result = new OrderResponse();

            try
            {
                // Validate Payment
                {
                    var payment = new RestClient("http://payment.northwind.svc.cluster.local");

                    var request = new RestRequest("/validate", Method.POST);
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new { CreditCardNumber = order.Payment });

                    var response = payment.Execute<ValidationResponse>(request);

                    if (response != null && response.Data != null)
                    {
                        result.Status = response.Data.Status;
                        result.Message = response.Data.Message;
                    }
                }

                if (result.Status)
                {
                    // Validate Address
                    {
                        var address = new RestClient("http://address.northwind.svc.cluster.local");

                        var request = new RestRequest("/validate", Method.POST);
                        request.RequestFormat = DataFormat.Json;
                        request.AddBody(new
                        {
                            Address = "Unit 1, 100 John Street, Sydney",
                            Country = "Australia",
                            Zip = order.Zip,
                        });

                        var response = address.Execute<ValidationResponse>(request);

                        if (response != null && response.Data != null)
                        {
                            result.Status = response.Data.Status;
                            result.Message = response.Data.Message;
                        }
                    }
                }

                if (result.Status)
                {
                    // Fetch Product
                    {
                        var product = new RestClient("http://product.northwind.svc.cluster.local");
                        var request = new RestRequest($"/products/{order.Product.ToString()}", Method.GET);

                        var response = product.Execute<ProductDetail>(request);
                        result.Total = response.Data.Price * order.Quantity;
                    }
                }
            }
            catch (Exception e)
            {
                result.Status = false;
                result.Message = e.Message;
                result.Total = -1;
            }

            return result;
        }
    }
}