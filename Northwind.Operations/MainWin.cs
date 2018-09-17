using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CreditCardValidator;
using Northwind.Operations.Model;
using RestSharp;

namespace Northwind.Operations
{
    public partial class MainWin : Form
    {
        private static Random rnd = new Random();

        public MainWin()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Deployment

        private void OnDeployAllApi(object sender, EventArgs e)
        {
            OnDeployApi(btnDeployProductApi, new EventArgs());
            OnDeployApi(btnDeployOrderApi, new EventArgs());
            OnDeployApi(btnDeployPaymentApi, new EventArgs());
            OnDeployApi(btnDeployAddressApi, new EventArgs());
        }

        private void OnRollbackAllApi(object sender, EventArgs e)
        {
            OnRollbackApi(btnRollbackProductApi, new EventArgs());
            OnRollbackApi(btnRollbackOrderApi, new EventArgs());
            OnRollbackApi(btnRollbackPaymentApi, new EventArgs());
            OnRollbackApi(btnRollbackAddressApi, new EventArgs());
        }

        private void OnDeployApi(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                btn.Enabled = false;

                ComboBox list = null;

                if (cbProductApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbProductApiImage;
                else if (cbOrderApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbOrderApiImage;
                else if (cbPaymentApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbPaymentApiImage;
                else if (cbAddressApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbAddressApiImage;
                else
                    list = null;

                var version = list != null ? list.SelectedIndex + 1 : 1;

                kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\deployment-{btn.Tag.ToString()}-v{version}.yml")}");
                kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\service-{btn.Tag.ToString()}.yml")}");

                btn.Enabled = true;
            }

            OnLoad(this, new EventArgs());
        }

        private void OnRollbackApi(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                btn.Enabled = false;

                ComboBox list = null;

                if (cbProductApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbProductApiImage;
                else if (cbOrderApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbOrderApiImage;
                else if (cbPaymentApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbPaymentApiImage;
                else if (cbAddressApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                    list = cbAddressApiImage;
                else
                    list = null;

                var version = list != null ? list.SelectedIndex + 1 : 1;

                kubectl($@"delete -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\deployment-{btn.Tag.ToString()}-v{version}.yml")}");
                kubectl($@"delete -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\service-{btn.Tag.ToString()}.yml")}");

                btn.Enabled = true;
            }

            OnLoad(this, new EventArgs());
        }

        private void OnDeployIngress(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                btn.Enabled = false;

                kubectl($@"create -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\ingress.yml")}");
                //kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\ingress-controller.yml")}");

                btn.Enabled = true;
            }
        }

        private void OnRollbackIngress(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                btn.Enabled = false;

                kubectl($@"delete -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\ingress.yml")}");
                //kubectl($@"delete -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\ingress-controller.yml")}");

                btn.Enabled = true;
            }
        }

        #endregion

        #region Istio

        private void OnDeployMesh(object sender, EventArgs e)
        {
            //kubectl($"apply -f {Path.Combine(txtIstioPath.Text, @"install\kubernetes\helm\istio\templates\crds.yaml")}");
            helm($"install {Path.Combine(txtIstioPath.Text, @"install\kubernetes\helm\istio")} --name istio --namespace istio-system");
        }

        private void OnRollbackMesh(object sender, EventArgs e)
        {
            helm("helm delete --purge istio");
            kubectl($"delete -f {Path.Combine(txtIstioPath.Text, @"install\kubernetes\helm\istio\templates\crds.yaml")}");
        }

        private void OnDeploySidecar(object sender, EventArgs e)
        {
            var component = (sender as Button).Tag.ToString();

            kubectl(@"-n istio-system get configmap istio-sidecar-injector -o=jsonpath='{.data.config}'", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\inject-config.yaml"));
            kubectl(@"-n istio-system get configmap istio -o=jsonpath='{.data.mesh}'", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\mesh-config.yaml"));

            istioctl($@"kube-inject --injectConfigFile {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\inject-config.yaml")} --meshConfigFile {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\mesh-config.yaml")} --filename {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\" + component + ".yml")} --output {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\" + component + "-injected.yml")}");
            kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\" + component + "-injected.yml")}");
        }

        #endregion

        private void OnProductHealth(object sender, EventArgs e)
        {
            new Action<string>(SendRequest).BeginInvoke($"/products", null, null);
        }

        private void OnOrderHealth(object sender, EventArgs e)
        {
            new Action<string>(SendRequest).BeginInvoke($"/orders", null, null);
        }

        private void OnProductSearch(object sender, EventArgs e)
        {
            new Action<string>(SendRequest).BeginInvoke($"/products/search?q={txtSearch.Text}", null, null);
        }

        private void SendRequest(string resource)
        {
            var request = new RestRequest(resource, Method.GET);

            var response = Api.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(() => { txtResponse.Text = response.Content; }));
                else
                    txtResponse.Text = response.Content;
            }
        }

        private void SendRequest(string resource, OrderRequest body)
        {
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(body);

            var response = Api.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(() => { txtResponse.Text = response.Content; }));
                else
                    txtResponse.Text = response.Content;
            }
        }

        private void OnOrderSubmitted(object sender, EventArgs e)
        {
            new Action<string, OrderRequest>(SendRequest).BeginInvoke($"/orders/order", new OrderRequest()
            {
                Id = Guid.NewGuid(),
                Product = ((ProductDetail)cbProducts.SelectedItem).Id,
                Address = "Unit 1, 100 John Street, Sydney",
                Quantity = rnd.Next(1, 9),
                Payment = CreditCardFactory.RandomCardNumber((CardIssuer)Enum.Parse(typeof(CardIssuer), cbPayment.SelectedItem.ToString())),
                Zip = GetZip(),
                Country = "Australia"
            }, null, null);
        }

        private string GetZip()
        {
            var result = string.Empty;

            var region = new List<(int From, int To)>();

            if (cbArea.SelectedItem.ToString() == "Central and Northern Sydney")
            {
                region.Add((2000, 2019));
                region.Add((2021, 2037));
                region.Add((2042, 2044));
                region.Add((2048, 2048));
                region.Add((2050, 2050));
                region.Add((2052, 2114));
                region.Add((2119, 2122));
                region.Add((2126, 2126));
                region.Add((2159, 2159));
                region.Add((2204, 2204));
            }

            if (cbArea.SelectedItem.ToString() == "Western Sydney and Blue Mountains")
            {
                region.Add((2038, 2041));
                region.Add((2045, 2047));
                region.Add((2115, 2118));
                region.Add((2123, 2125));
                region.Add((2127, 2128));
                region.Add((2137, 2140));
                region.Add((2142, 2142));
                region.Add((2160, 2160));
                region.Add((2745, 2751));
                region.Add((2753, 2786));
            }

            if (cbArea.SelectedItem.ToString() == "Greystanes - 2145 (Western Sydney)")
                region.Add((2144, 2158));

            if (region.Count > 0)
            {
                var area = region[rnd.Next(0, region.Count - 1)];
                result = rnd.Next(area.From, area.To).ToString();
            }

            return result;
        }
    }
}