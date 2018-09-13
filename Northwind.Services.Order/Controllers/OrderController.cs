using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.Services.Order.Model;
using RestSharp;

namespace NorthWind.Services.Order.Controllers
{
    [Route("")]
    public class OrderController : Controller
    {
        public ILogger Logger { get; }

        public OrderController(ILogger<OrderController> logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost("order")]
        public OrderResponse Post([FromBody] OrderRequest order)
        {
            var result = new OrderResponse();

            try
            {
                // Validate Payment
                {
                    var payment = new RestClient("http://payment.default.svc.cluster.local");

                    var request = new RestRequest("/validate", Method.POST);
                    Logger.LogDebug($"Executing {request.Method.ToString()} to {payment.BaseUrl.ToString()} on {request.Resource}");

                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new { CreditCardNumber = order.Payment });

                    var response = payment.Execute<ValidationResponse>(request);
                    Logger.LogDebug(response.Content);

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
                        var address = new RestClient("http://address.default.svc.cluster.local");

                        var request = new RestRequest("/validate", Method.POST);
                        Logger.LogDebug($"Executing {request.Method.ToString()} to {address.BaseUrl.ToString()} on {request.Resource}");
                        request.RequestFormat = DataFormat.Json;
                        request.AddBody(new
                        {
                            Address = "Unit 1, 100 John Street, Sydney",
                            Country = "Australia",
                            Zip = order.Zip,
                        });

                        var response = address.Execute<ValidationResponse>(request);
                        Logger.LogDebug(response.Content);

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
                        var product = new RestClient("http://product.default.svc.cluster.local");
                        var request = new RestRequest($"/products/{order.Product.ToString()}", Method.GET);
                        Logger.LogDebug($"Executing {request.Method.ToString()} to {product.BaseUrl.ToString()} on {request.Resource}");

                        var response = product.Execute<ProductDetail>(request);
                        Logger.LogDebug(response.Content);

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