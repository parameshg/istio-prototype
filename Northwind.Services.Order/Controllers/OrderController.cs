using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.Services.Order.Model;
using Northwind.Services.Shared;
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

        [HttpGet("order")]
        public Response Index()
        {
            return new Response("order/submit", 1);
        }

        [HttpPost("order")]
        public Response<OrderResponse> Post([FromBody] OrderRequest order)
        {
            var result = new Response<OrderResponse>("order/submit", 1);

            result.Downstream = new List<Response>();
            result.Data = new OrderResponse();

            try
            {
                // Validate Payment
                {
                    var payment = new RestClient("http://payment.default.svc.cluster.local");

                    var request = new RestRequest("/validate", Method.POST);
                    Logger.LogDebug($"Executing {request.Method.ToString()} to {payment.BaseUrl.ToString()} on {request.Resource}");

                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new { CreditCardNumber = order.Payment });

                    var response = payment.Execute<Response<ValidationResponse>>(request);

                    if (response == null)
                        throw new Exception("payment validation error [null]");

                    Logger.LogDebug(response.Content);

                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"payment validation error [{response.StatusCode}]");

                    if (response != null && response.Data != null && response.Data.Data != null)
                    {
                        result.Downstream.Add(response.Data);
                        result.Data.Status = response.Data.Data.Status;
                        result.Data.Message = response.Data.Data.Message;
                    }
                }

                if (result.Data.Status)
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

                        var response = address.Execute<Response<ValidationResponse>>(request);

                        if (response == null)
                            throw new Exception("address validation error [null]");

                        Logger.LogDebug(response.Content);

                        if (response.StatusCode != HttpStatusCode.OK)
                            throw new Exception($"address validation error [{response.StatusCode}]");

                        if (response != null && response.Data != null && response.Data.Data != null)
                        {
                            result.Downstream.Add(response.Data);
                            result.Data.Status = response.Data.Data.Status;
                            result.Data.Message = response.Data.Data.Message;
                        }
                    }
                }

                if (result.Data.Status)
                {
                    // Fetch Product
                    {
                        var product = new RestClient("http://product.default.svc.cluster.local");
                        var request = new RestRequest($"/products/{order.Product.ToString()}", Method.GET);
                        Logger.LogDebug($"Executing {request.Method.ToString()} to {product.BaseUrl.ToString()} on {request.Resource}");

                        var response = product.Execute<Response<ProductDetail>>(request);

                        if (response == null)
                            throw new Exception("product read error [null]");

                        Logger.LogDebug(response.Content);

                        if (response.StatusCode != HttpStatusCode.OK)
                            throw new Exception($"product read error [{response.StatusCode}]");

                        result.Data.Total = response.Data.Data.Price * order.Quantity;
                    }
                }
            }
            catch (Exception e)
            {
                result.Data.Status = false;
                result.Data.Message = e.Message;
                result.Data.Total = -1;
            }

            return result;
        }
    }
}