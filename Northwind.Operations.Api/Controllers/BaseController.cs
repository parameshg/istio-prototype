using System;
using k8s;

namespace Northwind.Operations.Api.Controllers
{
    public class BaseController
    {
        #region Kube Constants

        protected const string NAMESPACE = "northwind";
        protected const int WEB_PORT = 80;

        protected const string PRODUCT = "product";
        protected const string PRODUCT_API_IMAGE = "parameshg/northwind.product";
        protected const int PRODUCT_API_PORT = 80;

        protected const string ORDER = "order";
        protected const string ORDER_API_IMAGE = "parameshg/northwind.order";
        protected const int ORDER_API_PORT = 80;

        protected const string PAYMENT = "payment";
        protected const string PAYMENT_API_IMAGE = "parameshg/northwind.payment";

        protected const string ADDRESS = "address";
        protected const string ADDRESS_API_IMAGE = "parameshg/northwind.address";

        #endregion

        protected IKubernetes Kube { get; set; }

        protected Cluster Cluster { get; set; }

        public BaseController()
        {
            Kube = new Kubernetes(KubernetesClientConfiguration.BuildConfigFromConfigFile($@"C:\Users\{Environment.UserName}\.kube\config"));

            Cluster = new Cluster(Kube, NAMESPACE);
        }
    }
}