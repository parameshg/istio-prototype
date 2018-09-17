using System;
using CreditCardValidator;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Payment.v2.Model;
using Northwind.Services.Shared;

namespace NorthWind.Services.Payment.v2.Controllers
{
    [Route("")]
    public class PaymentController : Controller
    {
        [HttpGet("validate")]
        public Response Index()
        {
            return new Response("payment/validate", 2);
        }

        [HttpPost("validate")]
        public Response<ValidationResponse> Post([FromBody]ValidationRequest request)
        {
            var result = new Response<ValidationResponse>("payment/validate", 2);

            result.Data = new ValidationResponse();

            try
            {
                var detector = new CreditCardDetector(request.CreditCardNumber);

                result.Data.Status = detector.IsValid(CardIssuer.MasterCard, CardIssuer.Maestro, CardIssuer.Visa, CardIssuer.AmericanExpress, CardIssuer.DinersClub, CardIssuer.Discover, CardIssuer.RuPay);

                if (!result.Data.Status)
                    result.Data.Message = "credit card is not valid. currently supporting only mastercard, maestro, visa, americanexpress, dinersclub, discover and rupay cards";
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