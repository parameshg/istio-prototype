namespace Northwind.Operations
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbArea = new System.Windows.Forms.GroupBox();
            this.lstServiceArea = new System.Windows.Forms.CheckedListBox();
            this.gbDelay = new System.Windows.Forms.GroupBox();
            this.tlpTransactionDelay = new System.Windows.Forms.TableLayoutPanel();
            this.tbDelay = new System.Windows.Forms.TrackBar();
            this.lblDelayInterval = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbProductEndpoint = new System.Windows.Forms.GroupBox();
            this.txtProductEndpoint = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsers = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDelay = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRequestSent = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRequestPassed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRequestFailed = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.lstCardIssuers = new System.Windows.Forms.CheckedListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.tbUsers = new System.Windows.Forms.TrackBar();
            this.gbOrderEndpoint = new System.Windows.Forms.GroupBox();
            this.txtOrderEndpoint = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.gbArea.SuspendLayout();
            this.gbDelay.SuspendLayout();
            this.tlpTransactionDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).BeginInit();
            this.gbProductEndpoint.SuspendLayout();
            this.Status.SuspendLayout();
            this.gbLogs.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsers)).BeginInit();
            this.gbOrderEndpoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.gbOrderEndpoint, 1, 0);
            this.tlpMain.Controls.Add(this.gbArea, 1, 3);
            this.tlpMain.Controls.Add(this.gbDelay, 0, 2);
            this.tlpMain.Controls.Add(this.btnStart, 1, 5);
            this.tlpMain.Controls.Add(this.gbProductEndpoint, 0, 0);
            this.tlpMain.Controls.Add(this.Status, 0, 6);
            this.tlpMain.Controls.Add(this.gbLogs, 0, 4);
            this.tlpMain.Controls.Add(this.gbPayment, 0, 3);
            this.tlpMain.Controls.Add(this.btnStop, 0, 5);
            this.tlpMain.Controls.Add(this.gbUsers, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(784, 561);
            this.tlpMain.TabIndex = 0;
            // 
            // gbArea
            // 
            this.gbArea.Controls.Add(this.lstServiceArea);
            this.gbArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbArea.Location = new System.Drawing.Point(395, 173);
            this.gbArea.Name = "gbArea";
            this.gbArea.Size = new System.Drawing.Size(386, 194);
            this.gbArea.TabIndex = 6;
            this.gbArea.TabStop = false;
            this.gbArea.Text = "Service Area";
            // 
            // lstServiceArea
            // 
            this.lstServiceArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstServiceArea.FormattingEnabled = true;
            this.lstServiceArea.Items.AddRange(new object[] {
            "Central and Northern Sydney",
            "Western Sydney and Blue Mountains",
            "Greystanes - 2145 (Western Sydney)"});
            this.lstServiceArea.Location = new System.Drawing.Point(3, 16);
            this.lstServiceArea.Name = "lstServiceArea";
            this.lstServiceArea.Size = new System.Drawing.Size(380, 175);
            this.lstServiceArea.TabIndex = 0;
            this.lstServiceArea.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnServiceAreadChecked);
            // 
            // gbDelay
            // 
            this.tlpMain.SetColumnSpan(this.gbDelay, 2);
            this.gbDelay.Controls.Add(this.tlpTransactionDelay);
            this.gbDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDelay.Location = new System.Drawing.Point(3, 113);
            this.gbDelay.Name = "gbDelay";
            this.gbDelay.Size = new System.Drawing.Size(778, 54);
            this.gbDelay.TabIndex = 1;
            this.gbDelay.TabStop = false;
            this.gbDelay.Text = "Transaction Delay";
            // 
            // tlpTransactionDelay
            // 
            this.tlpTransactionDelay.ColumnCount = 2;
            this.tlpTransactionDelay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransactionDelay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTransactionDelay.Controls.Add(this.tbDelay, 0, 0);
            this.tlpTransactionDelay.Controls.Add(this.lblDelayInterval, 1, 0);
            this.tlpTransactionDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransactionDelay.Location = new System.Drawing.Point(3, 16);
            this.tlpTransactionDelay.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTransactionDelay.Name = "tlpTransactionDelay";
            this.tlpTransactionDelay.RowCount = 1;
            this.tlpTransactionDelay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransactionDelay.Size = new System.Drawing.Size(772, 35);
            this.tlpTransactionDelay.TabIndex = 0;
            // 
            // tbDelay
            // 
            this.tbDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDelay.LargeChange = 10;
            this.tbDelay.Location = new System.Drawing.Point(3, 3);
            this.tbDelay.Maximum = 10000;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(706, 29);
            this.tbDelay.TabIndex = 0;
            this.tbDelay.TickFrequency = 1000;
            this.tbDelay.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDelay.Value = 1000;
            this.tbDelay.ValueChanged += new System.EventHandler(this.OnDelayChanged);
            // 
            // lblDelayInterval
            // 
            this.lblDelayInterval.AutoSize = true;
            this.lblDelayInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDelayInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayInterval.Location = new System.Drawing.Point(715, 0);
            this.lblDelayInterval.Name = "lblDelayInterval";
            this.lblDelayInterval.Size = new System.Drawing.Size(54, 35);
            this.lblDelayInterval.TabIndex = 3;
            this.lblDelayInterval.Text = "1000 ms";
            this.lblDelayInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(395, 509);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(386, 24);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnStart);
            // 
            // gbProductEndpoint
            // 
            this.gbProductEndpoint.Controls.Add(this.txtProductEndpoint);
            this.gbProductEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductEndpoint.Location = new System.Drawing.Point(3, 3);
            this.gbProductEndpoint.Name = "gbProductEndpoint";
            this.gbProductEndpoint.Size = new System.Drawing.Size(386, 44);
            this.gbProductEndpoint.TabIndex = 0;
            this.gbProductEndpoint.TabStop = false;
            this.gbProductEndpoint.Text = "Product Endpoint";
            // 
            // txtProductEndpoint
            // 
            this.txtProductEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductEndpoint.Location = new System.Drawing.Point(3, 16);
            this.txtProductEndpoint.Name = "txtProductEndpoint";
            this.txtProductEndpoint.Size = new System.Drawing.Size(380, 23);
            this.txtProductEndpoint.TabIndex = 0;
            this.txtProductEndpoint.Text = "http://localhost";
            // 
            // Status
            // 
            this.tlpMain.SetColumnSpan(this.Status, 2);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage,
            this.lblUsers,
            this.lblDelay,
            this.lblRequestSent,
            this.lblRequestPassed,
            this.lblRequestFailed});
            this.Status.Location = new System.Drawing.Point(0, 537);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(784, 24);
            this.Status.TabIndex = 1;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatusMessage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(335, 19);
            this.lblStatusMessage.Spring = true;
            this.lblStatusMessage.Text = "Ready";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsers
            // 
            this.lblUsers.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblUsers.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(51, 19);
            this.lblUsers.Text = "Users: 1";
            // 
            // lblDelay
            // 
            this.lblDelay.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblDelay.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(89, 19);
            this.lblDelay.Text = "Delay: 1000 ms";
            // 
            // lblRequestSent
            // 
            this.lblRequestSent.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblRequestSent.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblRequestSent.Name = "lblRequestSent";
            this.lblRequestSent.Size = new System.Drawing.Size(91, 19);
            this.lblRequestSent.Text = "Request Sent: 0";
            // 
            // lblRequestPassed
            // 
            this.lblRequestPassed.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblRequestPassed.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblRequestPassed.Name = "lblRequestPassed";
            this.lblRequestPassed.Size = new System.Drawing.Size(104, 19);
            this.lblRequestPassed.Text = "Request Passed: 0";
            // 
            // lblRequestFailed
            // 
            this.lblRequestFailed.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblRequestFailed.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblRequestFailed.Name = "lblRequestFailed";
            this.lblRequestFailed.Size = new System.Drawing.Size(99, 19);
            this.lblRequestFailed.Text = "Request Failed: 0";
            // 
            // gbLogs
            // 
            this.tlpMain.SetColumnSpan(this.gbLogs, 2);
            this.gbLogs.Controls.Add(this.txtLogs);
            this.gbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLogs.Location = new System.Drawing.Point(3, 373);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(778, 130);
            this.gbLogs.TabIndex = 2;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Location = new System.Drawing.Point(3, 16);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(772, 111);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "";
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.lstCardIssuers);
            this.gbPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPayment.Location = new System.Drawing.Point(3, 173);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(386, 194);
            this.gbPayment.TabIndex = 5;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Credit Card Issuers";
            // 
            // lstCardIssuers
            // 
            this.lstCardIssuers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCardIssuers.FormattingEnabled = true;
            this.lstCardIssuers.Items.AddRange(new object[] {
            "MasterCard",
            "Maestro",
            "Visa",
            "AmericanExpress",
            "DinersClub",
            "Discover",
            "Rupay"});
            this.lstCardIssuers.Location = new System.Drawing.Point(3, 16);
            this.lstCardIssuers.Name = "lstCardIssuers";
            this.lstCardIssuers.Size = new System.Drawing.Size(380, 175);
            this.lstCardIssuers.TabIndex = 0;
            this.lstCardIssuers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnCardIssuersChecked);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(3, 509);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(386, 24);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.OnStop);
            // 
            // gbUsers
            // 
            this.tlpMain.SetColumnSpan(this.gbUsers, 2);
            this.gbUsers.Controls.Add(this.tlpOptions);
            this.gbUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsers.Location = new System.Drawing.Point(3, 53);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(778, 54);
            this.gbUsers.TabIndex = 0;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Number of Users";
            // 
            // tlpOptions
            // 
            this.tlpOptions.ColumnCount = 2;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpOptions.Controls.Add(this.lblUsersCount, 1, 0);
            this.tlpOptions.Controls.Add(this.tbUsers, 0, 0);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 1;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpOptions.Size = new System.Drawing.Size(772, 35);
            this.tlpOptions.TabIndex = 4;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCount.Location = new System.Drawing.Point(715, 0);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(54, 35);
            this.lblUsersCount.TabIndex = 2;
            this.lblUsersCount.Text = "1";
            this.lblUsersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsers
            // 
            this.tbUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsers.LargeChange = 10;
            this.tbUsers.Location = new System.Drawing.Point(3, 3);
            this.tbUsers.Maximum = 100;
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(706, 29);
            this.tbUsers.TabIndex = 0;
            this.tbUsers.TickFrequency = 10;
            this.tbUsers.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbUsers.Value = 1;
            this.tbUsers.ValueChanged += new System.EventHandler(this.OnUsersChanged);
            // 
            // gbOrderEndpoint
            // 
            this.gbOrderEndpoint.Controls.Add(this.txtOrderEndpoint);
            this.gbOrderEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderEndpoint.Location = new System.Drawing.Point(395, 3);
            this.gbOrderEndpoint.Name = "gbOrderEndpoint";
            this.gbOrderEndpoint.Size = new System.Drawing.Size(386, 44);
            this.gbOrderEndpoint.TabIndex = 1;
            this.gbOrderEndpoint.TabStop = false;
            this.gbOrderEndpoint.Text = "Order Endpoint";
            // 
            // txtOrderEndpoint
            // 
            this.txtOrderEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrderEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderEndpoint.Location = new System.Drawing.Point(3, 16);
            this.txtOrderEndpoint.Name = "txtOrderEndpoint";
            this.txtOrderEndpoint.Size = new System.Drawing.Size(380, 23);
            this.txtOrderEndpoint.TabIndex = 0;
            this.txtOrderEndpoint.Text = "http://localhost";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind: Users";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.gbArea.ResumeLayout(false);
            this.gbDelay.ResumeLayout(false);
            this.tlpTransactionDelay.ResumeLayout(false);
            this.tlpTransactionDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).EndInit();
            this.gbProductEndpoint.ResumeLayout(false);
            this.gbProductEndpoint.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.gbLogs.ResumeLayout(false);
            this.gbPayment.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsers)).EndInit();
            this.gbOrderEndpoint.ResumeLayout(false);
            this.gbOrderEndpoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbProductEndpoint;
        private System.Windows.Forms.TextBox txtProductEndpoint;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblRequestSent;
        private System.Windows.Forms.ToolStripStatusLabel lblRequestPassed;
        private System.Windows.Forms.ToolStripStatusLabel lblRequestFailed;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.TrackBar tbUsers;
        private System.Windows.Forms.GroupBox gbDelay;
        private System.Windows.Forms.TrackBar tbDelay;
        private System.Windows.Forms.ToolStripStatusLabel lblUsers;
        private System.Windows.Forms.ToolStripStatusLabel lblDelay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.Label lblDelayInterval;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.CheckedListBox lstCardIssuers;
        private System.Windows.Forms.GroupBox gbArea;
        private System.Windows.Forms.CheckedListBox lstServiceArea;
        private System.Windows.Forms.TableLayoutPanel tlpTransactionDelay;
        private System.Windows.Forms.GroupBox gbOrderEndpoint;
        private System.Windows.Forms.TextBox txtOrderEndpoint;
    }
}

