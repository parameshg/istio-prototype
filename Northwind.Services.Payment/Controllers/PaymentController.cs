using System;
using CreditCardValidator;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Payment.Model;
using Northwind.Services.Shared;

namespace NorthWind.Services.Payment.Controllers
{
    [Route("")]
    public class PaymentController : Controller
    {
        [HttpGet("validate")]
        public Response Index()
        {
            return new Response("payment/validate", 1);
        }

        [HttpPost("validate")]
        public Response<ValidationResponse> Post([FromBody] ValidationRequest request)
        {
            var result = new Response<ValidationResponse>("payment/validate", 1);

            result.Data = new ValidationResponse();

            try
            {
                var detector = new CreditCardDetector(request.CreditCardNumber);

                result.Data.Status = detector.IsValid(CardIssuer.MasterCard, CardIssuer.Visa);

                if (!result.Data.Status)
                    result.Data.Message = "credit card is not valid. currently supporting only mastercard and visa cards";
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