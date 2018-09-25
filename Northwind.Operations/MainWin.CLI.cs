using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Northwind.Operations
{
    partial class MainWin
    {
        private dynamic kubectlj(string args)
        {
            dynamic result = null;

            using (var kubectl = new Process())
            {
                kubectl.StartInfo.CreateNoWindow = true;
                kubectl.StartInfo.FileName = "kubectl.exe";
                kubectl.StartInfo.Arguments = args + " -o json";
                kubectl.StartInfo.UseShellExecute = false;
                kubectl.StartInfo.RedirectStandardOutput = true;
                kubectl.StartInfo.RedirectStandardError = true;
                kubectl.Start();

                result = JsonConvert.DeserializeObject(kubectl.StandardOutput.ReadToEnd());

                kubectl.WaitForExit();
            }

            return result;
        }

        private dynamic kubectlx(string args)
        {
            dynamic result = null;

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

                kubectl.WaitForExit();
            }

            return result;
        }

        private void kubectl(string args, bool validate = true)
        {
            if (!validate)
                args += " --validate=false";

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() =>
                {
                    txtTerminal.AppendText($"kubectl {args}");
                    txtTerminal.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                txtTerminal.AppendText($"kubectl {args}");
                txtTerminal.AppendText(Environment.NewLine);
            }

            using (var kubectl = new Process())
            {
                kubectl.StartInfo.CreateNoWindow = true;
                kubectl.StartInfo.FileName = "kubectl.exe";
                kubectl.StartInfo.Arguments = args;
                kubectl.StartInfo.UseShellExecute = false;
                kubectl.StartInfo.RedirectStandardOutput = true;
                kubectl.StartInfo.RedirectStandardError = true;
                kubectl.Start();

                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        txtTerminal.AppendText(kubectl.StandardOutput.ReadToEnd());
                        txtTerminal.AppendText(kubectl.StandardError.ReadToEnd());
                        txtTerminal.AppendText(Environment.NewLine);
                    }));
                }
                else
                {
                    txtTerminal.AppendText(kubectl.StandardOutput.ReadToEnd());
                    txtTerminal.AppendText(kubectl.StandardError.ReadToEnd());
                    txtTerminal.AppendText(Environment.NewLine);
                }

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
    }
}