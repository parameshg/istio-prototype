using System;
using CreditCardValidator;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Payment.Model;

namespace NorthWind.Services.Payment.Controllers
{
    [Route("")]
    public class PaymentController : Controller
    {
        [HttpPost("validate")]
        public ValidationResponse Post([FromBody] ValidationRequest request)
        {
            var result = new ValidationResponse();

            try
            {
                var detector = new CreditCardDetector(request.CreditCardNumber);

                result.Status = detector.IsValid(CardIssuer.MasterCard, CardIssuer.Visa);

                if (!result.Status)
                    result.Message = "credit card is not valid. currently supporting only mastercard and visa cards";
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