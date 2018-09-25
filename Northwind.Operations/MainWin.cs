using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using CreditCardValidator;
using Northwind.Operations.Model;
using Northwind.Services.Shared;
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
            cbProductApiImage.SelectedIndex = 0;
            OnDeployApi(btnDeployProductApi, new EventArgs());

            cbOrderApiImage.SelectedIndex = 0;
            OnDeployApi(btnDeployOrderApi, new EventArgs());

            cbPaymentApiImage.SelectedIndex = 0;
            OnDeployApi(btnDeployPaymentApi, new EventArgs());

            cbPaymentApiImage.SelectedIndex = 1;
            OnDeployApi(btnDeployPaymentApi, new EventArgs());

            cbAddressApiImage.SelectedIndex = 0;
            OnDeployApi(btnDeployAddressApi, new EventArgs());

            cbAddressApiImage.SelectedIndex = 1;
            OnDeployApi(btnDeployAddressApi, new EventArgs());

            cbAddressApiImage.SelectedIndex = 2;
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

                ComboBox list = GetList(btn);

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
            var btn = sender as Button;

            if (btn != null)
            {
                ComboBox list = GetList(btn);

                var version = list != null ? list.SelectedIndex + 1 : 1;

                var component = $"deployment-{btn.Tag.ToString()}-v{version}";

                kubectl(@"-n istio-system get configmap istio-sidecar-injector -o=jsonpath='{.data.config}'", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\inject-config.yaml"));
                kubectl(@"-n istio-system get configmap istio -o=jsonpath='{.data.mesh}'", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\mesh-config.yaml"));

                istioctl($@"kube-inject --injectConfigFile {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\inject-config.yaml")} --meshConfigFile {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\mesh-config.yaml")} --filename {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\" + component + ".yml")} --output {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\" + component + "-injected.yml")}");
                kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Kubernetes\" + component + "-injected.yml")}");
            }
        }

        private void OnInstallSidecars(object sender, EventArgs e)
        {
            cbProductApiImage.SelectedIndex = 0;
            OnDeploySidecar(btnInstallProductSidecar, new EventArgs());

            cbOrderApiImage.SelectedIndex = 0;
            OnDeploySidecar(btnInstallOrderSidecar, new EventArgs());

            cbPaymentApiImage.SelectedIndex = 0;
            OnDeploySidecar(btnInstallPaymentSidecar, new EventArgs());

            cbPaymentApiImage.SelectedIndex = 1;
            OnDeploySidecar(btnInstallPaymentSidecar, new EventArgs());

            cbAddressApiImage.SelectedIndex = 0;
            OnDeploySidecar(btnInstallAddressSidecar, new EventArgs());

            cbAddressApiImage.SelectedIndex = 1;
            OnDeploySidecar(btnInstallAddressSidecar, new EventArgs());

            cbAddressApiImage.SelectedIndex = 2;
            OnDeploySidecar(btnInstallAddressSidecar, new EventArgs());
        }

        private void OnUninstallSidecars(object sender, EventArgs e)
        {

        }

        private void OnBlueGreenDeployment(object sender, EventArgs e)
        {
            var btn = sender as RadioButton;

            if (btn != null)
            {
                var component = string.Empty;
                var version = 1;

                if (btn.Tag.ToString().Contains("payment"))
                {
                    component = "payment";

                    if (btn.Tag.ToString().Contains("1"))
                        version = 1;

                    if (btn.Tag.ToString().Contains("2"))
                        version = 2;
                }

                if (btn.Tag.ToString().Contains("address"))
                {
                    component = "address";

                    if (btn.Tag.ToString().Contains("1"))
                        version = 1;

                    if (btn.Tag.ToString().Contains("2"))
                        version = 2;

                    if (btn.Tag.ToString().Contains("3"))
                        version = 3;
                }

                if (btn.Checked)
                {
                    new Action(() =>
                    {
                        kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\Istio\virtual-service-{component}-v{version}.yml")}");
                        kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\Istio\destination-rule-{component}.yml")}");

                        Thread.Sleep(5000);

                    }).BeginInvoke(null, null);
                }
            }
        }

        private void OnCanaryRelease(object sender, EventArgs e)
        {
            var percent = tbCanaryRelease.Value / 10 * 10;

            kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\Istio\Canary\virtual-service-payment-canary-{percent}.yml")}");

            Thread.Sleep(5000);
        }

        private void OnFaultInjected(object sender, EventArgs e)
        {
            var percent = tbFaultPercent.Value / 10 * 10;

            kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\Istio\Fault\virtual-service-address-v3-fault-{percent}.yml")}");

            Thread.Sleep(5000);
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

        private Response<OrderResponse> SendRequest(OrderRequest order)
        {
            Response<OrderResponse> result = null;

            var request = new RestRequest("/orders/order", Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddBody(order);

            var response = Api.Execute<Response<OrderResponse>>(request);

            if (response.StatusCode == HttpStatusCode.OK)
                result = response.Data;

            return result;
        }

        private Response<List<ProductDetail>> Search(string pattern)
        {
            Response<List<ProductDetail>> result = null;

            var request = new RestRequest($"/products/search?q={pattern}", Method.GET);

            var response = Api.Execute<Response<List<ProductDetail>>>(request);

            if (response.StatusCode == HttpStatusCode.OK)
                result = response.Data;

            return result;
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
                Zip = GetZip(cbArea.SelectedItem.ToString()),
                Country = "Australia"
            }, null, null);
        }

        private string GetZip(string area)
        {
            var result = string.Empty;

            var region = new List<(int From, int To)>();

            if (area == "Central and Northern Sydney")
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

            if (area == "Western Sydney and Blue Mountains")
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

            if (area == "Greystanes - 2145 (Western Sydney)")
                region.Add((2144, 2158));

            if (region.Count > 0)
            {
                var code = region[rnd.Next(0, region.Count - 1)];
                result = rnd.Next(code.From, code.To).ToString();
            }

            return result;
        }

        private ComboBox GetList(Button btn)
        {
            ComboBox result = null;

            if (cbProductApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                result = cbProductApiImage;
            else if (cbOrderApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                result = cbOrderApiImage;
            else if (cbPaymentApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                result = cbPaymentApiImage;
            else if (cbAddressApiImage.Tag.ToString().Equals(btn.Tag.ToString()))
                result = cbAddressApiImage;
            else
                result = null;

            return result;
        }

        private void OnSubmitTestOrders(object sender, EventArgs e)
        {
            txtRequestSent.Text = "0";
            txtRequestPassed.Text = "0";
            txtRequestFailed.Text = "0";

            txtPayment1.Text = "0";
            txtPayment2.Text = "0";

            txtAddress1.Text = "0";
            txtAddress2.Text = "0";
            txtAddress3.Text = "0";

            var tester = new Tester();

            tester.RequestSent += (object from, EventArgs args) =>
            {
                pbTestProgress.Value++;

                txtRequestSent.Text = pbTestProgress.Value.ToString();

                txtTestLogs.AppendText("Sending request...\n");
            };

            tester.RequestPassed += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtRequestPassed.Text);

                count++;

                txtRequestPassed.Text = count.ToString();

                Application.DoEvents();
            };

            tester.RequestFailed += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtRequestFailed.Text);

                count++;

                txtRequestFailed.Text = count.ToString();

                Application.DoEvents();
            };

            tester.RequestProcessedByPaymentServer1 += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtPayment1.Text);

                count++;

                txtPayment1.Text = count.ToString();

                Application.DoEvents();
            };

            tester.RequestProcessedByPaymentServer2 += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtPayment2.Text);

                count++;

                txtPayment2.Text = count.ToString();

                Application.DoEvents();
            };

            tester.RequestProcessedByAddressServer1 += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtAddress1.Text);

                count++;

                txtAddress1.Text = count.ToString();

                Application.DoEvents();
            };

            tester.RequestProcessedByAddressServer2 += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtAddress2.Text);

                count++;

                txtAddress2.Text = count.ToString();

                Application.DoEvents();
            };

            tester.RequestProcessedByAddressServer3 += (object from, EventArgs args) =>
            {
                var count = int.Parse(txtAddress3.Text);

                count++;

                txtAddress3.Text = count.ToString();

                Application.DoEvents();
            };

            pbTestProgress.Value = 0;
            pbTestProgress.Minimum = 0;
            pbTestProgress.Maximum = Convert.ToInt32(nOrders.Value);

            tester.Execute(cbPaymentTest.SelectedItem.ToString(), cbAddressTest.SelectedItem.ToString(), Convert.ToInt32(nOrders.Value));
        }
    }
}