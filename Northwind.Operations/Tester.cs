using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using CreditCardValidator;
using Northwind.Operations.Model;
using Northwind.Services.Shared;
using RestSharp;

namespace Northwind.Operations
{
    public class Tester
    {
        public event EventHandler RequestSent;
        public event EventHandler RequestPassed;
        public event EventHandler RequestFailed;

        public event EventHandler RequestProcessedByPaymentServer1;
        public event EventHandler RequestProcessedByPaymentServer2;

        public event EventHandler RequestProcessedByAddressServer1;
        public event EventHandler RequestProcessedByAddressServer2;
        public event EventHandler RequestProcessedByAddressServer3;

        private Random rnd = new Random();

        private RestClient api { get { return new RestClient(ConfigurationManager.AppSettings["api"]); } }

        public void Execute(string card, string area, int count)
        {
            var products = SearchProducts("a");

            for (var i = 0; i < count; i++)
            {
                var id = products[rnd.Next(0, products.Count - 1)].Id;

                var response = SubmitOrder(new OrderRequest()
                {
                    Id = Guid.NewGuid(),
                    Product = id,
                    Address = "Unit 1, 100 John Street, Sydney",
                    Quantity = rnd.Next(1, 9),
                    Payment = GenerateCreditCardNumber(card),
                    Zip = GenerateAreaCode(area),
                    Country = "Australia"
                });

                if (response.Data.Status)
                    RequestPassed?.Invoke(this, new EventArgs());
                else
                    RequestFailed?.Invoke(this, new EventArgs());

                foreach (var o in response.Downstream)
                {
                    if (o.Endpoint.Contains("payment"))
                    {
                        if (o.Version.Equals(1))
                            RequestProcessedByPaymentServer1?.Invoke(this, new EventArgs());

                        if (o.Version.Equals(2))
                            RequestProcessedByPaymentServer2?.Invoke(this, new EventArgs());
                    }

                    if (o.Endpoint.Contains("address"))
                    {
                        if (o.Version.Equals(1))
                            RequestProcessedByAddressServer1?.Invoke(this, new EventArgs());

                        if (o.Version.Equals(2))
                            RequestProcessedByAddressServer2?.Invoke(this, new EventArgs());

                        if (o.Version.Equals(3))
                            RequestProcessedByAddressServer3?.Invoke(this, new EventArgs());
                    }
                }

                RequestSent?.Invoke(this, new EventArgs());
            }
        }

        private List<ProductDetail> SearchProducts(string pattern)
        {
            var result = new List<ProductDetail>();

            var request = new RestRequest($"/products/search?q={pattern}", Method.GET);

            var response = api.Execute<Response<List<ProductDetail>>>(request);

            if (response.StatusCode.Equals(HttpStatusCode.OK))
                result.AddRange(response?.Data?.Data);

            return result;
        }

        private Response<OrderResponse> SubmitOrder(OrderRequest order)
        {
            Response<OrderResponse> result = null;

            var request = new RestRequest("/orders/order", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(order);

            var response = api.Execute<Response<OrderResponse>>(request);

            if (response.StatusCode == HttpStatusCode.OK)
                result = response.Data;

            return result;
        }

        private string GenerateAreaCode(string area)
        {
            var result = string.Empty;

            var region = new List<(int From, int To)>();

            if (area.Equals("Central and Northern Sydney"))
            {
                region.Add((2000, 2019));
                region.Add((2021, 2037));
                region.Add((2042, 2044));
                region.Add((2048, 2048));
                region.Add((2050, 2050));
                region.Add((2052, 2114));
                region.Add((2119, 2122));
                region.Add((2126, 2126));
                region.Add((2159, 2159));
                region.Add((2204, 2204));
            }

            if (area.Equals("Western Sydney and Blue Mountains"))
            {
                region.Add((2038, 2041));
                region.Add((2045, 2047));
                region.Add((2115, 2118));
                region.Add((2123, 2125));
                region.Add((2127, 2128));
                region.Add((2137, 2140));
                region.Add((2142, 2142));
                region.Add((2160, 2160));
                region.Add((2745, 2751));
                region.Add((2753, 2786));
            }

            if (area.Equals("Greystanes - 2145 (Western Sydney)"))
                region.Add((2144, 2158));

            if (region.Count > 0)
            {
                var code = region[rnd.Next(0, region.Count - 1)];

                result = rnd.Next(code.From, code.To).ToString();
            }

            return result;
        }

        private string GenerateCreditCardNumber(string issuer)
        {
            return CreditCardFactory.RandomCardNumber((CardIssuer)Enum.Parse(typeof(CardIssuer), issuer));
        }
    }
}