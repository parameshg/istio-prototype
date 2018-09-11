using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Northwind.Operations
{
    public partial class Provisioner : Form
    {
        public Provisioner()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        #region Deployment

        private void OnDeployApi(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                btn.Enabled = false;

                var version = 1;

                kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\{btn.Tag.ToString()}-v{version}-deployment.yml")}");
                kubectl($@"apply -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\{btn.Tag.ToString()}-v{version}-service.yml")}");

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

                var version = 1;

                kubectl($@"delete -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\{btn.Tag.ToString()}-v{version}-deployment.yml")}");
                kubectl($@"delete -f {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Kubernetes\{btn.Tag.ToString()}-v{version}-service.yml")}");

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

        #region CLI

        private dynamic kubectlx(string args)
        {
            dynamic result = null;

            txtTerminal.AppendText($"kubectl {args} --all-namespaces -o json");
            txtTerminal.AppendText(Environment.NewLine);

            using (var kubectl = new Process())
            {
                kubectl.StartInfo.CreateNoWindow = true;
                kubectl.StartInfo.FileName = "kubectl.exe";
                kubectl.StartInfo.Arguments = args + " --all-namespaces -o json";
                kubectl.StartInfo.UseShellExecute = false;
                kubectl.StartInfo.RedirectStandardOutput = true;
                kubectl.StartInfo.RedirectStandardError = true;
                kubectl.Start();

                result = JsonConvert.DeserializeObject(kubectl.StandardOutput.ReadToEnd());
                txtTerminal.AppendText(Environment.NewLine);

                kubectl.WaitForExit();
            }

            return result;
        }

        private void kubectl(string args)
        {
            txtTerminal.AppendText($"kubectl {args}");
            txtTerminal.AppendText(Environment.NewLine);

            using (var kubectl = new Process())
            {
                kubectl.StartInfo.CreateNoWindow = true;
                kubectl.StartInfo.FileName = "kubectl.exe";
                kubectl.StartInfo.Arguments = args;
                kubectl.StartInfo.UseShellExecute = false;
                kubectl.StartInfo.RedirectStandardOutput = true;
                kubectl.StartInfo.RedirectStandardError = true;
                kubectl.Start();

                txtTerminal.AppendText(kubectl.StandardOutput.ReadToEnd());
                txtTerminal.AppendText(kubectl.StandardError.ReadToEnd());
                txtTerminal.AppendText(Environment.NewLine);

                kubectl.WaitForExit();
            }
        }

        private void kubectl(string args, string filename)
        {
            txtTerminal.AppendText($"kubectl {args} > {filename}");
            txtTerminal.AppendText(Environment.NewLine);

            using (var kubectl = new Process())
            {
                kubectl.StartInfo.CreateNoWindow = true;
                kubectl.StartInfo.FileName = "kubectl.exe";
                kubectl.StartInfo.Arguments = args;
                kubectl.StartInfo.UseShellExecute = false;
                kubectl.StartInfo.RedirectStandardOutput = true;
                kubectl.StartInfo.RedirectStandardError = true;
                kubectl.Start();

                using (var writer = new StreamWriter(filename))
                {
                    writer.Write(kubectl.StandardOutput.ReadToEnd().Replace("'", string.Empty));
                    writer.Write(kubectl.StandardError.ReadToEnd());
                }

                kubectl.WaitForExit();
            }
        }

        private void istioctl(string args)
        {
            txtTerminal.AppendText($"istioctl {args}");
            txtTerminal.AppendText(Environment.NewLine);

            using (var istioctl = new Process())
            {
                istioctl.StartInfo.CreateNoWindow = true;
                istioctl.StartInfo.FileName = Path.Combine(txtIstioPath.Text, @"bin\istioctl.exe");
                istioctl.StartInfo.Arguments = args;
                istioctl.StartInfo.UseShellExecute = false;
                istioctl.StartInfo.RedirectStandardOutput = true;
                istioctl.StartInfo.RedirectStandardError = true;
                istioctl.Start();

                txtTerminal.AppendText(istioctl.StandardOutput.ReadToEnd());
                txtTerminal.AppendText(istioctl.StandardError.ReadToEnd());
                txtTerminal.AppendText(Environment.NewLine);

                istioctl.WaitForExit();
            }
        }

        private void helm(string args)
        {
            txtTerminal.AppendText($"helm {args}");
            txtTerminal.AppendText(Environment.NewLine);

            using (var kubectl = new Process())
            {
                kubectl.StartInfo.CreateNoWindow = true;
                kubectl.StartInfo.FileName = "helm.exe";
                kubectl.StartInfo.Arguments = args;
                kubectl.StartInfo.UseShellExecute = false;
                kubectl.StartInfo.RedirectStandardOutput = true;
                kubectl.StartInfo.RedirectStandardError = true;
                kubectl.Start();

                txtTerminal.AppendText(kubectl.StandardOutput.ReadToEnd());
                txtTerminal.AppendText(kubectl.StandardError.ReadToEnd());
                txtTerminal.AppendText(Environment.NewLine);

                kubectl.WaitForExit();
            }
        }

        #endregion
    }
}