using System;
using CreditCardValidator;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Payment.v2.Model;

namespace NorthWind.Services.Payment.v2.Controllers
{
    [Route("")]
    public class PaymentController : Controller
    {
        [HttpPost("validate")]
        public ValidationResponse Post([FromBody]ValidationRequest request)
        {
            var result = new ValidationResponse();

            try
            {
                var detector = new CreditCardDetector(request.CreditCardNumber);

                result.Status = detector.IsValid(CardIssuer.MasterCard, CardIssuer.Maestro, CardIssuer.Visa, CardIssuer.AmericanExpress, CardIssuer.DinersClub, CardIssuer.Discover, CardIssuer.RuPay);

                if (!result.Status)
                    result.Message = "credit card is not valid. currently supporting only mastercard, maestro, visa, americanexpress, dinersclub, discover and rupay cards";
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