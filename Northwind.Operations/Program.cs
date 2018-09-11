using System;
using System.Windows.Forms;

namespace Northwind.Operations
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Provisioner());
        }
    }
}