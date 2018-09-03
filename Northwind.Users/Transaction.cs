using System;
using System.Collections.Generic;
using Northwind.Users.Model;
using RestSharp;

namespace Northwind.Users
{
    public class Transaction
    {
        private static Random rnd = new Random();

        public string Search { get; private set; }

        private string ProductEndpoint { get; }

        private string OrderEndpoint { get; }

        private string Payment { get; }

        private string Zip { get; }

        private List<string> Pattern { get; set; }

        public Transaction(string productEndpoint, string orderEndpoint, string payment, string zip)
        {
            ProductEndpoint = productEndpoint ?? throw new ArgumentNullException(nameof(productEndpoint));
            OrderEndpoint = orderEndpoint ?? throw new ArgumentNullException(nameof(orderEndpoint));
            Payment = payment ?? throw new ArgumentNullException(nameof(payment));
            Zip = zip ?? throw new ArgumentNullException(nameof(zip));

            Pattern = new List<string>() { "chocolate", "laundry", "whiskey", "scotch", "champagne", "lacura", "degreaser", "SPF", "skin", "coffee" };
            Search = Pattern[rnd.Next(0, 9)];
        }

        public (bool status, string message, int products) Execute()
        {
            (bool status, string message, int products) result = (false, string.Empty, 0);

            try
            {
                var server = new RestClient(ProductEndpoint);
                var request = new RestRequest("/search", Method.GET);
                request.AddQueryParameter("q", Search);

                var response = server.Execute<List<ProductDetail>>(request);

                if (response.Data != null)
                {
                    result.products = response.Data.Count;
                    result.status = true;
                    result.message = "OK";

                    foreach (var i in response.Data)
                    {
                        var order = Process(i.Id);

                        result.status = order.status;
                        result.message = order.message;

                        if (!result.status)
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                result.status = false;
                result.message = e.Message;
            }

            return result;
        }

        private (bool status, string message) Process(Guid productId)
        {
            (bool status, string message) result = (false, string.Empty);

            try
            {
                var server = new RestClient(OrderEndpoint);
                var request = new RestRequest("/order", Method.POST);

                request.RequestFormat = DataFormat.Json;
                request.AddBody(new OrderRequest()
                {
                    Id = Guid.NewGuid(),
                    Product = productId,
                    Address = "Unit 1, 100 John Street, Sydney",
                    Quantity = rnd.Next(1, 9),
                    Payment = Payment,
                    Zip = Zip,
                    Country = "Australia"
                });

                var response = server.Execute<OrderResponse>(request);

                if (response.IsSuccessful && response.Data != null)
                {
                    result.status = response.Data.Status;
                    result.message = response.Data.Message;
                }
            }
            catch (Exception e)
            {
                result.status = false;
                result.message = e.Message;
            }

            return result;
        }
    }
}