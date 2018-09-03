using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CreditCardValidator;

namespace Northwind.Users
{
    public partial class MainWin : Form
    {
        private Random rnd = new Random();

        private int _TotalRequests;

        private int TotalRequests { get { return _TotalRequests; } set { _TotalRequests++; lblRequestSent.Text = $"Request Sent: {_TotalRequests}"; } }

        private int _PassedRequests;

        private int PassedRequests { get { return _PassedRequests; } set { _PassedRequests++; lblRequestPassed.Text = $"Request Passed: {_PassedRequests}"; } }

        private int _FailedRequests;

        private int FailedRequests { get { return _FailedRequests; } set { _FailedRequests++; lblRequestFailed.Text = $"Request Failed: {_FailedRequests}"; } }

        private List<Timer> Timers { get; set; }

        private List<CardIssuer> CardIssuers { get; set; }

        private List<(int From, int To)> Areas { get; set; }

        public MainWin()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Timers = new List<Timer>();
            CardIssuers = new List<CardIssuer>();
            Areas = new List<(int From, int To)>();
        }

        private void OnDelayChanged(object sender, EventArgs e)
        {
            foreach (var i in Timers)
                i.Interval = tbDelay.Value;

            lblDelay.Text = $"Delay: {tbDelay.Value} ms";
            lblDelayInterval.Text = $"{tbDelay.Value} ms";
        }

        private void OnUsersChanged(object sender, EventArgs e)
        {
            lblUsers.Text = $"Users: {tbUsers.Value}";
            lblUsersCount.Text = tbUsers.Value.ToString();

            if (!txtProductEndpoint.Enabled)
            {
                if (Timers.Count < tbUsers.Value)
                {
                    while (Timers.Count < tbUsers.Value)
                    {
                        var timer = new Timer()
                        {
                            Interval = tbDelay.Value,
                            Enabled = true,
                            Tag = Timers.Count + 1
                        };
                        timer.Tick += OnTimer;
                        Timers.Add(timer);
                    }
                }

                if (Timers.Count > tbUsers.Value)
                {
                    while (Timers.Count > tbUsers.Value)
                    {
                        var timer = Timers.Last();
                        timer.Stop();
                        Timers.Remove(timer);
                    }
                }
            }
        }

        private void OnStart(object sender, EventArgs e)
        {
            txtProductEndpoint.Enabled = false;
            txtOrderEndpoint.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            var o = new Timer()
            {
                Interval = tbDelay.Value,
                Enabled = true,
                Tag = 1
            };

            o.Tick += OnTimer;
            o.Start();

            Timers.Add(o);
        }

        private void OnStop(object sender, EventArgs e)
        {
            foreach (var i in Timers)
                i.Enabled = false;

            Timers.Clear();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtProductEndpoint.Enabled = true;
            txtOrderEndpoint.Enabled = true;
        }

        private void OnTimer(object sender, EventArgs e)
        {
            var transaction = new Transaction(txtProductEndpoint.Text, txtOrderEndpoint.Text, GenerateCreditCardNumber(), GeneratePostalCode());

            txtLogs.AppendText($"User-{((Timer)sender).Tag.ToString()}: Searching for {transaction.Search}... ");

            var result = transaction.Execute();

            if (result.status)
            {
                PassedRequests++;
                txtLogs.AppendText($"found {result.products} products!");
            }
            else
            {
                FailedRequests++;
                txtLogs.AppendText($"failed! Error: {result.message}");
            }

            txtLogs.AppendText(Environment.NewLine);
            TotalRequests++;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            txtProductEndpoint.Enabled = true;
            txtOrderEndpoint.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void OnCardIssuersChecked(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked && e.NewValue == CheckState.Checked)
                CardIssuers.Add((CardIssuer)Enum.Parse(typeof(CardIssuer), lstCardIssuers.Items[e.Index].ToString()));

            if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked)
                CardIssuers.Remove((CardIssuer)Enum.Parse(typeof(CardIssuer), lstCardIssuers.Items[e.Index].ToString()));
        }

        private void OnServiceAreadChecked(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked && e.NewValue == CheckState.Checked)
            {
                if (lstServiceArea.Items[e.Index].ToString() == "Central and Northern Sydney")
                {
                    Areas.Add((2000, 2019));
                    Areas.Add((2021, 2037));
                    Areas.Add((2042, 2044));
                    Areas.Add((2048, 2048));
                    Areas.Add((2050, 2050));
                    Areas.Add((2052, 2114));
                    Areas.Add((2119, 2122));
                    Areas.Add((2126, 2126));
                    Areas.Add((2159, 2159));
                    Areas.Add((2204, 2204));
                }

                if (lstServiceArea.Items[e.Index].ToString() == "Western Sydney and Blue Mountains")
                {
                    Areas.Add((2038, 2041));
                    Areas.Add((2045, 2047));
                    Areas.Add((2115, 2118));
                    Areas.Add((2123, 2125));
                    Areas.Add((2127, 2128));
                    Areas.Add((2137, 2140));
                    Areas.Add((2142, 2142));
                    Areas.Add((2160, 2160));
                    Areas.Add((2745, 2751));
                    Areas.Add((2753, 2786));
                }

                if (lstServiceArea.Items[e.Index].ToString() == "Greystanes - 2145 (Western Sydney)")
                {
                    Areas.Add((2144, 2158));
                }
            }

            if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked)
            {
                if (lstServiceArea.Items[e.Index].ToString() == "Central and Northern Sydney")
                {
                    Areas.Remove((2000, 2019));
                    Areas.Remove((2021, 2037));
                    Areas.Remove((2042, 2044));
                    Areas.Remove((2048, 2048));
                    Areas.Remove((2050, 2050));
                    Areas.Remove((2052, 2114));
                    Areas.Remove((2119, 2122));
                    Areas.Remove((2126, 2126));
                    Areas.Remove((2159, 2159));
                    Areas.Remove((2204, 2204));
                }

                if (lstServiceArea.Items[e.Index].ToString() == "Western Sydney and Blue Mountains")
                {
                    Areas.Remove((2038, 2041));
                    Areas.Remove((2045, 2047));
                    Areas.Remove((2115, 2118));
                    Areas.Remove((2123, 2125));
                    Areas.Remove((2127, 2128));
                    Areas.Remove((2137, 2140));
                    Areas.Remove((2142, 2142));
                    Areas.Remove((2160, 2160));
                    Areas.Remove((2745, 2751));
                    Areas.Remove((2753, 2786));
                }

                if (lstServiceArea.Items[e.Index].ToString() == "Greystanes - 2145 (Western Sydney)")
                {
                    Areas.Remove((2144, 2158));
                }
            }
        }

        private string GenerateCreditCardNumber()
        {
            var result = string.Empty;

            if (CardIssuers.Count > 0)
                result = CreditCardFactory.RandomCardNumber(CardIssuers[rnd.Next(0, CardIssuers.Count - 1)]);

            return result;
        }

        private string GeneratePostalCode()
        {
            var result = string.Empty;

            if (Areas.Count > 0)
            {
                var area = Areas[rnd.Next(0, Areas.Count - 1)];
                result = rnd.Next(area.From, area.To).ToString();
            }

            return result;
        }
    }
}