using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Operations.Api.Models;

namespace Northwind.Operations.Api.Controllers
{
    [Route("api")]
    public class ApiController : BaseController
    {
        #region Product

        [HttpGet("product")]
        public Response<bool> GetProductApi()
        {
            var result = new Response<bool>();

            try
            {
                result.Result = Cluster.Exists(PRODUCT, 1);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("product/deploy")]
        public Response<bool> DeployProductApi()
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Deploy(PRODUCT, 1, PRODUCT_API_IMAGE, WEB_PORT, null, PRODUCT_API_PORT);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("product/rollback")]
        public Response<bool> RollbackProductApi()
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Rollback(PRODUCT, 1);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion Product

        #region Order

        [HttpGet("order")]
        public Response<bool> GetOrderApi()
        {
            var result = new Response<bool>();

            try
            {
                result.Result = Cluster.Exists(ORDER, 1);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("order/deploy")]
        public Response<bool> DeployOrderApi()
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Deploy(ORDER, 1, ORDER_API_IMAGE, WEB_PORT, null, ORDER_API_PORT);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("order/rollback")]
        public Response<bool> RollbackOrderApi()
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Rollback(ORDER, 1);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion Order

        #region Payment

        [HttpGet("payment/{version}")]
        public Response<bool> GetPaymentApi(int version)
        {
            var result = new Response<bool>();

            try
            {
                result.Result = Cluster.Exists(PAYMENT, version);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("payment/{version}/deploy")]
        public Response<bool> DeployPaymentApi(int version)
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Deploy(PAYMENT, version, PAYMENT_API_IMAGE, WEB_PORT);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("payment/{version}/rollback")]
        public Response<bool> RollbackPaymentApi(int version)
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Rollback(PAYMENT, version);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion Payment

        #region Address

        [HttpGet("address/{version}")]
        public Response<bool> GetAddressApi(int version)
        {
            var result = new Response<bool>();

            try
            {
                result.Result = Cluster.Exists(ADDRESS, version);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("address/{version}/deploy")]
        public Response<bool> DeployAddressApi(int version)
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Deploy(ADDRESS, version, ADDRESS_API_IMAGE, WEB_PORT);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("address/{version}/rollback")]
        public Response<bool> RollbackAddressApi(int version)
        {
            var result = new Response<bool>();

            try
            {
                Cluster.Rollback(ADDRESS, version);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion Address
    }
}