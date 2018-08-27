using System;
using System.Configuration;
using System.Windows.Forms;
using RestSharp;

namespace Northwind.Operations
{
    public partial class MainWin : Form
    {
        private RestClient Api { get { return new RestClient(ConfigurationManager.AppSettings["api"]); } }

        public MainWin()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<string>>(new RestRequest("/endpoint", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                txtEndpoint.Text = response.Data.Result;

            btnDeployProductService.Enabled = false;
            btnRollbackProductService.Enabled = false;

            btnDeployOrderService.Enabled = false;
            btnRollbackOrderService.Enabled = false;

            btnDeployPaymentService.Enabled = false;
            btnRollbackPaymentService.Enabled = false;

            btnDeployAddressService.Enabled = false;
            btnRollbackAddressService.Enabled = false;
        }

        private void OnDeployProductService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest("/services/product/deploy", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnProductServiceChanged(sender, e);
        }

        private void OnRollbackProductService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest("/services/product/rollback", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnProductServiceChanged(sender, e);
        }

        private void OnDeployOrderService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest("/services/order/deploy", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnOrderServiceChanged(sender, e);
        }

        private void OnOrderServiceRollback(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest("/services/order/rollback", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnOrderServiceChanged(sender, e);
        }

        private void OnDeployPaymentService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest($"/services/payment/{cbPaymentServiceImage.SelectedIndex + 1}/deploy", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnPaymentServiceChanged(sender, e);
        }

        private void OnRollbackPaymentService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest($"/services/payment/{cbPaymentServiceImage.SelectedIndex + 1}/rollback", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnPaymentServiceChanged(sender, e);
        }

        private void OnDeployAddressService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest($"/services/address/{cbAddressServiceImage.SelectedIndex + 1}/deploy", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnAddressServiceChanged(sender, e);
        }

        private void OnRollbackAddressService(object sender, EventArgs e)
        {
            var response = Api.Execute<Response<dynamic>>(new RestRequest($"/services/address/{cbAddressServiceImage.SelectedIndex + 1}/rolback", Method.GET));

            if (response.Data.Error)
                MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                OnAddressServiceChanged(sender, e);
        }

        private void OnProductServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbProductServiceImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<dynamic>>(new RestRequest("/services/product", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var found = response.Data.Result != null;

                    btnDeployProductService.Enabled = !found;
                    btnRollbackProductService.Enabled = found;
                }

                Application.DoEvents();
            }
        }

        private void OnOrderServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbOrderServiceImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<dynamic>>(new RestRequest("/services/order", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var found = response.Data.Result != null;

                    btnDeployOrderService.Enabled = !found;
                    btnRollbackOrderService.Enabled = found;
                }

                Application.DoEvents();
            }
        }

        private void OnPaymentServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbPaymentServiceImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<dynamic>>(new RestRequest($"/services/payment/{cbPaymentServiceImage.SelectedIndex + 1}", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var found = response.Data.Result != null;

                    btnDeployPaymentService.Enabled = !found;
                    btnRollbackPaymentService.Enabled = found;
                }

                Application.DoEvents();
            }
        }

        private void OnAddressServiceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbAddressServiceImage.SelectedItem.ToString()))
            {
                var response = Api.Execute<Response<dynamic>>(new RestRequest($"/services/address/{cbAddressServiceImage.SelectedIndex + 1}", Method.GET));

                if (response.Data.Error)
                    MessageBox.Show(response.Data.Message, GetType().Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var found = response.Data.Result != null;

                    btnDeployAddressService.Enabled = !found;
                    btnRollbackAddressService.Enabled = found;
                }

                Application.DoEvents();
            }
        }
    }
}