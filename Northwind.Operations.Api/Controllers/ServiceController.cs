using System;
using System.Collections.Generic;
using System.Linq;
using k8s;
using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using Northwind.Operations.Api.Models;

namespace Northwind.Operations.Api.Controllers
{
    [Route("services")]
    public class ServiceController : BaseController
    {
        #region Home

        [HttpGet()]
        public Response<V1PodList> Index()
        {
            var result = new Response<V1PodList>();

            try
            {
                result.Result = Kube.ListNamespacedPod(Constants.NAMESPACE);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion

        #region Product

        [HttpGet("product")]
        public Response<V1Deployment> GetProductService()
        {
            var result = new Response<V1Deployment>();

            try
            {
                result.Result = Kube.ListNamespacedDeployment(Constants.NAMESPACE).Items.SingleOrDefault(i => i.Metadata.Name.Equals("product-deployment"));
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("product/deploy")]
        public Response<V1Deployment> DeployProductService()
        {
            var result = new Response<V1Deployment>();

            try
            {
                var o = new V1Deployment("apps/v1", "Deployment")
                {
                    Metadata = new V1ObjectMeta()
                    {
                        Name = "product-deployment",
                        Labels = new Dictionary<string, string>() { { "api", "product" } }
                    },
                    Spec = new V1DeploymentSpec()
                    {
                        Replicas = 1,
                        Selector = new V1LabelSelector()
                        {
                            MatchLabels = new Dictionary<string, string>() { { "api", "product" } }
                        },
                        Template = new V1PodTemplateSpec()
                        {
                            Metadata = new V1ObjectMeta()
                            {
                                Name = "product-pod",
                                Labels = new Dictionary<string, string>() { { "api", "product" } }
                            },
                            Spec = new V1PodSpec()
                            {
                                Containers = new List<V1Container>()
                                {
                                    new V1Container()
                                    {
                                        Name = "product-api",
                                        Image = "parameshg/northwind.product:v1",
                                        Ports = new List<V1ContainerPort>()
                                        {
                                            new V1ContainerPort()
                                            {
                                                ContainerPort = 80
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                result.Result = Kube.CreateNamespacedDeployment(o, Constants.NAMESPACE);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("product/rollback")]
        public Response<V1Status> RollbackProductService()
        {
            var result = new Response<V1Status>();

            try
            {
                foreach (var i in Kube.ListNamespacedDeployment(Constants.NAMESPACE).Items)
                {
                    if (i.Metadata.Name.Equals("product-deployment"))
                    {
                        result.Result = Kube.DeleteNamespacedDeployment(new V1DeleteOptions(), i.Metadata.Name, Constants.NAMESPACE);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion

        #region Order

        [HttpGet("order")]
        public Response<V1Pod> GetOrderService()
        {
            var result = new Response<V1Pod>();

            try
            {
                result.Result = Kube.ListNamespacedPod(Constants.NAMESPACE).Items.SingleOrDefault(i => i.Metadata.Name.Equals("order-pod"));
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("order/deploy")]
        public Response<V1Deployment> DeployOrderService()
        {
            var result = new Response<V1Deployment>();

            try
            {
                var o = new V1Deployment("apps/v1", "Deployment")
                {
                    Metadata = new V1ObjectMeta()
                    {
                        Name = "order-deployment",
                        Labels = new Dictionary<string, string>() { { "api", "order" } }
                    },
                    Spec = new V1DeploymentSpec()
                    {
                        Replicas = 1,
                        Selector = new V1LabelSelector()
                        {
                            MatchLabels = new Dictionary<string, string>() { { "api", "order" } }
                        },
                        Template = new V1PodTemplateSpec()
                        {
                            Metadata = new V1ObjectMeta()
                            {
                                Name = "order-pod",
                                Labels = new Dictionary<string, string>() { { "api", "order" } }
                            },
                            Spec = new V1PodSpec()
                            {
                                Containers = new List<V1Container>()
                                {
                                    new V1Container()
                                    {
                                        Name = "order-api",
                                        Image = "parameshg/northwind.order:v1",
                                        Ports = new List<V1ContainerPort>()
                                        {
                                            new V1ContainerPort()
                                            {
                                                ContainerPort = 80
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                result.Result = Kube.CreateNamespacedDeployment(o, Constants.NAMESPACE);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("order/rollback")]
        public Response<V1Status> RollbackOrderService()
        {
            var result = new Response<V1Status>();

            try
            {
                foreach (var i in Kube.ListNamespacedDeployment(Constants.NAMESPACE).Items)
                {
                    if (i.Metadata.Name.Equals("order-deployment"))
                    {
                        result.Result = Kube.DeleteNamespacedDeployment(new V1DeleteOptions(), i.Metadata.Name, Constants.NAMESPACE);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion

        #region Payment

        [HttpGet("payment/{version}")]
        public Response<V1Pod> GetPaymentService(int version)
        {
            var result = new Response<V1Pod>();

            try
            {
                result.Result = Kube.ListNamespacedPod(Constants.NAMESPACE).Items.SingleOrDefault(i => i.Metadata.Name.Equals("payment-pod") &&
                              i.Metadata.Labels.Where(o => o.Key.Equals("version") && o.Value.Equals(version.ToString())).Count().Equals(1));
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("payment/{version}/deploy")]
        public Response<V1Deployment> DeployPaymentService(int version)
        {
            var result = new Response<V1Deployment>();

            try
            {
                var o = new V1Deployment("apps/v1", "Deployment")
                {
                    Metadata = new V1ObjectMeta()
                    {
                        Name = "payment-deployment",
                        Labels = new Dictionary<string, string>() { { "api", "payment" }, { "version", version.ToString() } }
                    },
                    Spec = new V1DeploymentSpec()
                    {
                        Replicas = 1,
                        Selector = new V1LabelSelector()
                        {
                            MatchLabels = new Dictionary<string, string>() { { "api", "payment" }, { "version", version.ToString() } }
                        },
                        Template = new V1PodTemplateSpec()
                        {
                            Metadata = new V1ObjectMeta()
                            {
                                Name = "payment-pod",
                                Labels = new Dictionary<string, string>() { { "api", "payment" }, { "version", version.ToString() } }
                            },
                            Spec = new V1PodSpec()
                            {
                                Containers = new List<V1Container>()
                                {
                                    new V1Container()
                                    {
                                        Name = "payment-api",
                                        Image = "parameshg/northwind.payment:v" + version,
                                        Ports = new List<V1ContainerPort>()
                                        {
                                            new V1ContainerPort()
                                            {
                                                ContainerPort = 80
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                result.Result = Kube.CreateNamespacedDeployment(o, Constants.NAMESPACE);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("payment/{version}/rollback")]
        public Response<V1Status> RollbackPaymentService(int version)
        {
            var result = new Response<V1Status>();

            try
            {
                foreach (var i in Kube.ListNamespacedDeployment(Constants.NAMESPACE).Items)
                {
                    if (i.Metadata.Name.Equals("payment-deployment") &&
                        i.Metadata.Labels.Where(o => o.Key.Equals("version") && o.Value.Equals(version.ToString())).Count().Equals(1))
                    {
                        result.Result = Kube.DeleteNamespacedDeployment(new V1DeleteOptions(), i.Metadata.Name, Constants.NAMESPACE);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion

        #region Address

        [HttpGet("address/{version}")]
        public Response<V1Pod> GetAddressService(int version)
        {
            var result = new Response<V1Pod>();

            try
            {
                result.Result = Kube.ListNamespacedPod(Constants.NAMESPACE).Items.SingleOrDefault(i => i.Metadata.Name.Equals("address-pod") &&
                              i.Metadata.Labels.Where(o => o.Key.Equals("version") && o.Value.Equals(version.ToString())).Count().Equals(1));
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("address/{version}/deploy")]
        public Response<V1Deployment> DeployAddressService(int version)
        {
            var result = new Response<V1Deployment>();

            try
            {
                var o = new V1Deployment("apps/v1", "Deployment")
                {
                    Metadata = new V1ObjectMeta()
                    {
                        Name = "address-deployment",
                        Labels = new Dictionary<string, string>() { { "api", "address" }, { "version", version.ToString() } }
                    },
                    Spec = new V1DeploymentSpec()
                    {
                        Replicas = 1,
                        Selector = new V1LabelSelector()
                        {
                            MatchLabels = new Dictionary<string, string>() { { "api", "address" }, { "version", version.ToString() } }
                        },
                        Template = new V1PodTemplateSpec()
                        {
                            Metadata = new V1ObjectMeta()
                            {
                                Name = "address-pod",
                                Labels = new Dictionary<string, string>() { { "api", "address" }, { "version", version.ToString() } }
                            },
                            Spec = new V1PodSpec()
                            {
                                Containers = new List<V1Container>()
                                {
                                    new V1Container()
                                    {
                                        Name = "address-api",
                                        Image = "parameshg/northwind.address:v" + version,
                                        Ports = new List<V1ContainerPort>()
                                        {
                                            new V1ContainerPort()
                                            {
                                                ContainerPort = 80
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                result.Result = Kube.CreateNamespacedDeployment(o, Constants.NAMESPACE);
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        [HttpGet("address/{version}/rollback")]
        public Response<V1Status> RollbackAddressService(int version)
        {
            var result = new Response<V1Status>();

            try
            {
                foreach (var i in Kube.ListNamespacedDeployment(Constants.NAMESPACE).Items)
                {
                    if (i.Metadata.Name.Equals("address-deployment") &&
                        i.Metadata.Labels.Where(o => o.Key.Equals("version") && o.Value.Equals(version.ToString())).Count().Equals(1))
                    {
                        result.Result = Kube.DeleteNamespacedDeployment(new V1DeleteOptions(), i.Metadata.Name, Constants.NAMESPACE);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message = e.ToString();
            }

            return result;
        }

        #endregion
    }
}