using System;
using System.Collections.Generic;
using System.Linq;
using k8s;
using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using Northwind.Operations.Api.Models;
using Northwind.Operations.Shared;

namespace Northwind.Operations.Api.Controllers
{
    [Route("")]
    [Produces("application/json")]
    public class HomeController : BaseController
    {
        [HttpGet()]
        public Response<string> Index()
        {
            var result = new Response<string>();

            try
            {
                if (Kube.ListNamespace().Items.SingleOrDefault(i => i.Metadata.Name.Equals(NAMESPACE)) == null)
                    Kube.CreateNamespace(new V1Namespace("v1", "Namespace", new V1ObjectMeta() { Name = NAMESPACE }, new V1NamespaceSpec()));

                result.Result = "Cluster Operations Api";
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

        [HttpGet("namespaces")]
        public Response<List<string>> GetNamespaces()
        {
            var result = new Response<List<string>>();

            try
            {
                result.Result = new List<string>();

                foreach (var i in Kube.ListNamespace().Items)
                    result.Result.Add(i.Metadata.Name);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.Message;
            }

            return result;
        }

        [HttpGet("pods")]
        public Response<List<Pod>> GetPods()
        {
            var result = new Response<List<Pod>>();

            try
            {
                result.Result = new List<Pod>();

                foreach (var i in Kube.ListNamespacedPod(NAMESPACE).Items)
                {
                    result.Result.Add(new Pod()
                    {
                        Name = i.Metadata.Name,
                        Status = i.Status.Phase,
                        Address = i.Status.HostIP
                    });
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.Message;
            }

            return result;
        }

        [HttpGet("services")]
        public Response<List<Service>> GetServices()
        {
            var result = new Response<List<Service>>();

            try
            {
                result.Result = new List<Service>();

                foreach (var i in Kube.ListNamespacedService(NAMESPACE).Items)
                {
                    result.Result.Add(new Service()
                    {
                        Name = i.Metadata.Name,
                        Status = string.IsNullOrEmpty(i.Spec.ClusterIP) ? "Pending" : "Running",
                        Address = i.Status?.LoadBalancer?.Ingress?.FirstOrDefault()?.Ip == null ? i?.Spec?.ClusterIP : i.Status?.LoadBalancer?.Ingress?.FirstOrDefault()?.Ip
                    });
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.Message;
            }

            return result;
        }
    }
}