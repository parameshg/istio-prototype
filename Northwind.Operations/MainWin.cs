using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Northwind.Operations.Shared;
using RestSharp;

namespace Northwind.Operations
{
    public partial class MainWin : Form
    {
        private bool Loading
        {
            get { return ProgressBar.Visible; }

            set
            {
                ProgressBar.Visible = value;
                Application.DoEvents();
            }
        }

        private RestClient Api { get { return new RestClient(ConfigurationManager.AppSettings["api"]); } }

        public MainWin()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var health = Api.Execute<Response<string>>(new RestRequest("/", Method.GET));

            btnDeployProductApi.Enabled = false;
            btnRollbackProductApi.Enabled = false;

            btnDeployOrderApi.Enabled = false;
            btnRollbackOrderApi.Enabled = false;

            btnDeployPaymentApi.Enabled = false;
            btnRollbackPaymentApi.Enabled = false;

            btnDeployAddressApi.Enabled = false;
            btnRollbackAddressApi.Enabled = false;

            // Endpoint
            {
                var response = Api.Execute<Response<string>>(new RestRequest("/endpoint", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txtEndpoint.Text = response.Data.Result;
            }

            OnNamespaceRefreshed(this, new EventArgs());
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());
        }

        #region Deployment

        private void OnDeployProductApi(object sender, EventArgs e)
        {
            btnDeployProductApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest("/api/product/deploy", Method.GET));

            OnProductServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnRollbackProductApi(object sender, EventArgs e)
        {
            btnRollbackProductApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest("/api/product/rollback", Method.GET));

            OnProductServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDeployOrderApi(object sender, EventArgs e)
        {
            btnDeployOrderApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest("/api/order/deploy", Method.GET));

            OnOrderServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnRollbackOrderApi(object sender, EventArgs e)
        {
            btnRollbackOrderApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest("/api/order/rollback", Method.GET));

            OnOrderServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDeployPaymentApi(object sender, EventArgs e)
        {
            btnDeployPaymentApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest($"/api/payment/{cbPaymentApiImage.SelectedIndex + 1}/deploy", Method.GET));

            OnPaymentServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnPaymentServiceChanged(sender, e);
        }

        private void OnRollbackPaymentApi(object sender, EventArgs e)
        {
            btnRollbackPaymentApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest($"/api/payment/{cbPaymentApiImage.SelectedIndex + 1}/rollback", Method.GET));

            OnPaymentServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDeployAddressApi(object sender, EventArgs e)
        {
            btnDeployAddressApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest($"/api/address/{cbAddressApiImage.SelectedIndex + 1}/deploy", Method.GET));

            OnAddressServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnRollbackAddressApi(object sender, EventArgs e)
        {
            btnRollbackAddressApi.Enabled = false;

            var response = Api.Execute<Response<bool>>(new RestRequest($"/api/address/{cbAddressApiImage.SelectedIndex + 1}/rollback", Method.GET));

            OnAddressServiceChanged(sender, e);
            OnPodRefreshed(this, new EventArgs());
            OnServiceRefreshed(this, new EventArgs());

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Api

        private void OnProductServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbProductApiImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<bool>>(new RestRequest("/api/product", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    btnDeployProductApi.Enabled = !response.Data.Result;
                    btnRollbackProductApi.Enabled = response.Data.Result;
                }

                Application.DoEvents();
            }
        }

        private void OnOrderServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbOrderApiImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<bool>>(new RestRequest("/api/order", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    btnDeployOrderApi.Enabled = !response.Data.Result;
                    btnRollbackOrderApi.Enabled = response.Data.Result;
                }

                Application.DoEvents();
            }
        }

        private void OnPaymentServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbPaymentApiImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<bool>>(new RestRequest($"/api/payment/{cbPaymentApiImage.SelectedIndex + 1}", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    btnDeployPaymentApi.Enabled = !response.Data.Result;
                    btnRollbackPaymentApi.Enabled = response.Data.Result;
                }

                Application.DoEvents();
            }
        }

        private void OnAddressServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbAddressApiImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<bool>>(new RestRequest($"/api/address/{cbAddressApiImage.SelectedIndex + 1}", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    btnDeployAddressApi.Enabled = !response.Data.Result;
                    btnRollbackAddressApi.Enabled = response.Data.Result;
                }

                Application.DoEvents();
            }
        }

        #endregion

        #region Refresh

        private void OnNamespaceRefreshed(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<List<string>>>(new RestRequest("/namespaces", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lstNamespaces.Items.Clear();

                foreach (var i in response.Data.Result)
                    lstNamespaces.Items.Add(new ListViewItem(new string[] { i }));
            }
        }

        private void OnPodRefreshed(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<List<Pod>>>(new RestRequest("/pods", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lstPods.Items.Clear();

                foreach (var i in response.Data.Result)
                {
                    var name = i.Name;
                    var status = i.Status;
                    var address = i.Address;

                    lstPods.Items.Add(new ListViewItem(new string[] { name, status, address }));
                }
            }
        }

        private void OnServiceRefreshed(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<List<Service>>>(new RestRequest("/services", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lstServices.Items.Clear();

                foreach (var i in response.Data.Result)
                {
                    var name = i.Name;
                    var status = i.Status;
                    var address = i.Address;

                    lstServices.Items.Add(new ListViewItem(new string[] { name, status, address }));
                }
            }
        }

        #endregion

        #region Istio

        private void OnDeployMesh(object sender, EventArgs e)
        {

        }

        #endregion

        private void OnServicesDoubleClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstServices.SelectedItems)
                Clipboard.SetText(i.SubItems[2].Text);
        }
    }
}