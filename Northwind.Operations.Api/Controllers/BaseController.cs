using System;
using k8s;

namespace Northwind.Operations.Api.Controllers
{
    public class BaseController
    {
        protected IKubernetes Kube { get; set; }

        public BaseController()
        {
            Kube = new Kubernetes(KubernetesClientConfiguration.BuildConfigFromConfigFile($@"C:\Users\{Environment.UserName}\.kube\config"));
        }
    }
}