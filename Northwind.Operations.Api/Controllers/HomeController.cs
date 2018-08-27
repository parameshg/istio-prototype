using System;
using System.Linq;
using k8s;
using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using Northwind.Operations.Api.Models;

namespace Northwind.Operations.Api.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class HomeController : BaseController
    {
        [HttpGet()]
        public Response<V1NamespaceList> Index()
        {
            var result = new Response<V1NamespaceList>();

            try
            {
                if (Kube.ListNamespace().Items.SingleOrDefault(i => i.Metadata.Name.Equals(Constants.NAMESPACE)) == null)
                    Kube.CreateNamespace(new V1Namespace("v1", "Namespace", new V1ObjectMeta() { Name = Constants.NAMESPACE }, new V1NamespaceSpec()));

                result.Result = Kube.ListNamespace();
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.Message;
            }

            return result;
        }

        [HttpGet("endpoint")]
        public Response<string> GetEndpoint()
        {
            var result = new Response<string>();

            result.Result = Kube.BaseUri.ToString();

            return result;
        }
    }
}