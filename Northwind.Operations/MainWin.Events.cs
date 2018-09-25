using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Windows.Forms;
using Northwind.Operations.Model;
using Northwind.Services.Shared;
using RestSharp;

namespace Northwind.Operations
{
    partial class MainWin
    {
        private RestClient Api { get { return new RestClient(ConfigurationManager.AppSettings["api"]); } }

        private void OnLoad(object sender, EventArgs e)
        {
            dynamic config = kubectlj("config view");

            txtEndpoint.Text = config.clusters[0].cluster.server;

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

            var response = Api.Execute<Response<List<ProductDetail>>>(new RestRequest("/products/search?q=a", Method.GET));

            if (response.StatusCode == HttpStatusCode.OK)
            {
                cbProducts.Items.Clear();

                foreach (var i in response.Data.Data)
                {
                    cbProducts.Items.Add(i);
                    cbProducts.DisplayMember = "Name";
                    cbProducts.ValueMember = "Id";
                }
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

        private void OnClearTerminal(object sender, EventArgs e)
        {
            txtTerminal.Clear();
        }

        private void OnCanaryPercent(object sender, EventArgs e)
        {
            lblCanaryPercent.Text = $"{tbCanaryRelease.Value}%";
        }

        private void OnFaultPercent(object sender, EventArgs e)
        {
            lblFaultPercent.Text = $"{tbFaultPercent.Value}%";
        }
    }
}