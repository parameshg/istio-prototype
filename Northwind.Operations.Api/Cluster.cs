using System.Collections.Generic;
using System.Linq;
using k8s;
using k8s.Models;

namespace Northwind.Operations.Api
{
    public class Cluster
    {
        private const string LABEL_API = "api";

        private const string LABEL_VERSION = "version";

        private string Namespace { get; set; }

        private IKubernetes Kube { get; set; }

        public Cluster(IKubernetes kube, string ns)
        {
            Kube = kube;
            Namespace = ns;
        }

        public bool Exists(string name, int version)
        {
            return Kube.ListNamespacedDeployment(Namespace).Items.Count(i => i.Metadata.Name.Equals(name) && i.Metadata.Labels.Where(o => o.Key.Equals(LABEL_VERSION) && o.Value.Equals(version.ToString())).Count().Equals(1)).Equals(1) &&
                   Kube.ListNamespacedService(Namespace).Items.Count(i => i.Metadata.Name.Equals(name) && i.Metadata.Labels.Where(o => o.Key.Equals(LABEL_VERSION) && o.Value.Equals(version.ToString())).Count().Equals(1)).Equals(1);
        }

        public void Deploy(string name, int version, string image, int? containerPort = null, int? nodePort = null, int? externalPort = null)
        {
            var labels = new Dictionary<string, string>() { { LABEL_API, name }, { LABEL_VERSION, version.ToString() } };

            var deployment = new V1Deployment("apps/v1", "Deployment")
            {
                Metadata = new V1ObjectMeta()
                {
                    Name = name,
                    Labels = labels
                },
                Spec = new V1DeploymentSpec()
                {
                    Replicas = 1,
                    Selector = new V1LabelSelector()
                    {
                        MatchLabels = labels
                    },
                    Template = new V1PodTemplateSpec()
                    {
                        Metadata = new V1ObjectMeta()
                        {
                            Name = name,
                            Labels = labels
                        },
                        Spec = new V1PodSpec()
                        {
                            Containers = new List<V1Container>()
                            {
                                new V1Container()
                                {
                                    Name = name,
                                    Image = $"{image}:v{version}",
                                    Ports = containerPort.HasValue ? new List<V1ContainerPort>() { new V1ContainerPort() { ContainerPort = containerPort.Value } } : null
                                }
                            }
                        }
                    }
                }
            };

            Kube.CreateNamespacedDeployment(deployment, Namespace);

            var serviceType = "ClusterIP";
            var servicePort = containerPort.HasValue ? new V1ServicePort(containerPort.Value) : new V1ServicePort();

            if (externalPort.HasValue)
            {
                serviceType = "LoadBalancer";
                servicePort = new V1ServicePort()
                {
                    Name = name,
                    Protocol = "TCP",
                    Port = externalPort.Value,
                    TargetPort = new IntstrIntOrString(containerPort.Value.ToString())
                };
            }

            var service = new V1Service("v1", "Service")
            {
                Metadata = new V1ObjectMeta()
                {
                    Name = name,
                    Labels = labels,
                },
                Spec = new V1ServiceSpec()
                {
                    Type = serviceType,
                    Ports = new List<V1ServicePort>() { servicePort },
                    Selector = labels
                }
            };

            Kube.CreateNamespacedService(service, Namespace);
        }

        public void Rollback(string name, int version)
        {
            foreach (var i in Kube.ListNamespacedDeployment(Namespace).Items)
            {
                if (i.Metadata.Name.Equals(name) && i.Metadata.Labels.Where(o => o.Key.Equals(LABEL_VERSION) && o.Value.Equals(version.ToString())).Count().Equals(1))
                {
                    Kube.DeleteNamespacedDeployment(new V1DeleteOptions(), i.Metadata.Name, Namespace);
                    break;
                }
            }

            foreach (var i in Kube.ListNamespacedService(Namespace).Items)
            {
                if (i.Metadata.Name.Equals(name) && i.Metadata.Labels.Where(o => o.Key.Equals(LABEL_VERSION) && o.Value.Equals(version.ToString())).Count().Equals(1))
                {
                    Kube.DeleteNamespacedService(new V1DeleteOptions(), i.Metadata.Name, Namespace);
                    break;
                }
            }
        }
    }
}