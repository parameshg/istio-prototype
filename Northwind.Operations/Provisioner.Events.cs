using System;
using System.Configuration;
using System.Windows.Forms;
using RestSharp;

namespace Northwind.Operations
{
    partial class Provisioner
    {
        private RestClient Api { get { return new RestClient(ConfigurationManager.AppSettings["api"]); } }

        private void OnLoad(object sender, EventArgs e)
        {
            lstObjects.ShowGroups = true;
            lstObjects.Items.Clear();

            dynamic pods = kubectlx("get pods");

            foreach (dynamic i in pods.items)
            {
                string kind = i.kind;
                string name = i.metadata.name;
                string ns = i.metadata["namespace"];
                string address = string.Empty;

                lstObjects.Items.Add(new ListViewItem(new string[] { ns, kind, name, address }));
            }

            dynamic deployments = kubectlx("get deployments");

            foreach (dynamic i in deployments.items)
            {
                string kind = i.kind;
                string name = i.metadata.name;
                string ns = i.metadata["namespace"];
                string address = string.Empty;

                lstObjects.Items.Add(new ListViewItem(new string[] { ns, kind, name, address }));
            }

            dynamic services = kubectlx("get services");

            foreach (dynamic i in services.items)
            {
                string kind = i.kind;
                string name = i.metadata.name;
                string ns = i.metadata["namespace"];
                string address = i.spec.clusterIP;
                string type = i.spec.type;

                if (type == "LoadBalancer")
                    address = i?.status?.loadBalancer?.ingress?[0]?.ip;

                lstObjects.Items.Add(new ListViewItem(new string[] { ns, kind, name, address }));
            }

            dynamic ingress = kubectlx("get ingress");

            foreach (dynamic i in ingress.items)
            {
                string kind = i.kind;
                string name = i.metadata.name;
                string ns = i.metadata["namespace"];
                string address = string.Empty;

                lstObjects.Items.Add(new ListViewItem(new string[] { ns, kind, name, address }));
            }
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            OnLoad(sender, e);
        }

        private void OnObjectSelected(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstObjects.SelectedItems)
                Clipboard.SetText(i.SubItems[3].Text);
        }
    }
}