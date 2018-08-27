namespace Northwind.Operations
{
    partial class MainWin
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddressService = new System.Windows.Forms.GroupBox();
            this.tlpAddressService = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployAddressService = new System.Windows.Forms.Button();
            this.cbAddressServiceImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackAddressService = new System.Windows.Forms.Button();
            this.gbPaymentService = new System.Windows.Forms.GroupBox();
            this.tlpPaymentService = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployPaymentService = new System.Windows.Forms.Button();
            this.cbPaymentServiceImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackPaymentService = new System.Windows.Forms.Button();
            this.gbOrderService = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployOrderService = new System.Windows.Forms.Button();
            this.cbOrderServiceImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackOrderService = new System.Windows.Forms.Button();
            this.gbProductService = new System.Windows.Forms.GroupBox();
            this.tlpProductService = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployProductService = new System.Windows.Forms.Button();
            this.cbProductServiceImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackProductService = new System.Windows.Forms.Button();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.gbEndpoint = new System.Windows.Forms.GroupBox();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.gbMesh = new System.Windows.Forms.GroupBox();
            this.tlpMesh = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeployMeshMaster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAddressService.SuspendLayout();
            this.tlpAddressService.SuspendLayout();
            this.gbPaymentService.SuspendLayout();
            this.tlpPaymentService.SuspendLayout();
            this.gbOrderService.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbProductService.SuspendLayout();
            this.tlpProductService.SuspendLayout();
            this.gbLogs.SuspendLayout();
            this.gbEndpoint.SuspendLayout();
            this.gbMesh.SuspendLayout();
            this.tlpMesh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.StatusBar, 0, 5);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMain.Controls.Add(this.gbLogs, 0, 4);
            this.tlpMain.Controls.Add(this.gbEndpoint, 0, 0);
            this.tlpMain.Controls.Add(this.gbMesh, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.Size = new System.Drawing.Size(964, 591);
            this.tlpMain.TabIndex = 0;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage});
            this.StatusBar.Location = new System.Drawing.Point(0, 567);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(964, 24);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatusMessage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(949, 19);
            this.lblStatusMessage.Spring = true;
            this.lblStatusMessage.Text = "Ready";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gbAddressService, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbPaymentService, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbOrderService, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbProductService, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 85);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbAddressService
            // 
            this.gbAddressService.Controls.Add(this.tlpAddressService);
            this.gbAddressService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressService.Location = new System.Drawing.Point(726, 3);
            this.gbAddressService.Name = "gbAddressService";
            this.gbAddressService.Size = new System.Drawing.Size(235, 79);
            this.gbAddressService.TabIndex = 1;
            this.gbAddressService.TabStop = false;
            this.gbAddressService.Text = "Address Service";
            // 
            // tlpAddressService
            // 
            this.tlpAddressService.ColumnCount = 2;
            this.tlpAddressService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddressService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddressService.Controls.Add(this.btnDeployAddressService, 0, 1);
            this.tlpAddressService.Controls.Add(this.cbAddressServiceImage, 0, 0);
            this.tlpAddressService.Controls.Add(this.btnRollbackAddressService, 1, 1);
            this.tlpAddressService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddressService.Location = new System.Drawing.Point(3, 16);
            this.tlpAddressService.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddressService.Name = "tlpAddressService";
            this.tlpAddressService.RowCount = 2;
            this.tlpAddressService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddressService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddressService.Size = new System.Drawing.Size(229, 60);
            this.tlpAddressService.TabIndex = 0;
            // 
            // btnDeployAddressService
            // 
            this.btnDeployAddressService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployAddressService.Location = new System.Drawing.Point(3, 33);
            this.btnDeployAddressService.Name = "btnDeployAddressService";
            this.btnDeployAddressService.Size = new System.Drawing.Size(108, 24);
            this.btnDeployAddressService.TabIndex = 0;
            this.btnDeployAddressService.Text = "Deploy";
            this.btnDeployAddressService.UseVisualStyleBackColor = true;
            this.btnDeployAddressService.Click += new System.EventHandler(this.OnDeployAddressService);
            // 
            // cbAddressServiceImage
            // 
            this.tlpAddressService.SetColumnSpan(this.cbAddressServiceImage, 2);
            this.cbAddressServiceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAddressServiceImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddressServiceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddressServiceImage.FormattingEnabled = true;
            this.cbAddressServiceImage.Items.AddRange(new object[] {
            "parameshg/northwind.address:v1",
            "parameshg/northwind.address:v2",
            "parameshg/northwind.address:v3"});
            this.cbAddressServiceImage.Location = new System.Drawing.Point(3, 3);
            this.cbAddressServiceImage.Name = "cbAddressServiceImage";
            this.cbAddressServiceImage.Size = new System.Drawing.Size(223, 24);
            this.cbAddressServiceImage.TabIndex = 1;
            this.cbAddressServiceImage.SelectedIndexChanged += new System.EventHandler(this.OnAddressServiceChanged);
            // 
            // btnRollbackAddressService
            // 
            this.btnRollbackAddressService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackAddressService.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackAddressService.Name = "btnRollbackAddressService";
            this.btnRollbackAddressService.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackAddressService.TabIndex = 2;
            this.btnRollbackAddressService.Text = "Rollback";
            this.btnRollbackAddressService.UseVisualStyleBackColor = true;
            this.btnRollbackAddressService.Click += new System.EventHandler(this.OnRollbackAddressService);
            // 
            // gbPaymentService
            // 
            this.gbPaymentService.Controls.Add(this.tlpPaymentService);
            this.gbPaymentService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentService.Location = new System.Drawing.Point(485, 3);
            this.gbPaymentService.Name = "gbPaymentService";
            this.gbPaymentService.Size = new System.Drawing.Size(235, 79);
            this.gbPaymentService.TabIndex = 1;
            this.gbPaymentService.TabStop = false;
            this.gbPaymentService.Text = "Payment Service";
            // 
            // tlpPaymentService
            // 
            this.tlpPaymentService.ColumnCount = 2;
            this.tlpPaymentService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentService.Controls.Add(this.btnDeployPaymentService, 0, 1);
            this.tlpPaymentService.Controls.Add(this.cbPaymentServiceImage, 0, 0);
            this.tlpPaymentService.Controls.Add(this.btnRollbackPaymentService, 1, 1);
            this.tlpPaymentService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentService.Location = new System.Drawing.Point(3, 16);
            this.tlpPaymentService.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPaymentService.Name = "tlpPaymentService";
            this.tlpPaymentService.RowCount = 2;
            this.tlpPaymentService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentService.Size = new System.Drawing.Size(229, 60);
            this.tlpPaymentService.TabIndex = 0;
            // 
            // btnDeployPaymentService
            // 
            this.btnDeployPaymentService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployPaymentService.Location = new System.Drawing.Point(3, 33);
            this.btnDeployPaymentService.Name = "btnDeployPaymentService";
            this.btnDeployPaymentService.Size = new System.Drawing.Size(108, 24);
            this.btnDeployPaymentService.TabIndex = 0;
            this.btnDeployPaymentService.Text = "Deploy";
            this.btnDeployPaymentService.UseVisualStyleBackColor = true;
            this.btnDeployPaymentService.Click += new System.EventHandler(this.OnDeployPaymentService);
            // 
            // cbPaymentServiceImage
            // 
            this.tlpPaymentService.SetColumnSpan(this.cbPaymentServiceImage, 2);
            this.cbPaymentServiceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPaymentServiceImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentServiceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentServiceImage.FormattingEnabled = true;
            this.cbPaymentServiceImage.Items.AddRange(new object[] {
            "parameshg/northwind.payment:v1",
            "parameshg/northwind.payment:v2"});
            this.cbPaymentServiceImage.Location = new System.Drawing.Point(3, 3);
            this.cbPaymentServiceImage.Name = "cbPaymentServiceImage";
            this.cbPaymentServiceImage.Size = new System.Drawing.Size(223, 24);
            this.cbPaymentServiceImage.TabIndex = 1;
            this.cbPaymentServiceImage.SelectedIndexChanged += new System.EventHandler(this.OnPaymentServiceChanged);
            // 
            // btnRollbackPaymentService
            // 
            this.btnRollbackPaymentService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackPaymentService.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackPaymentService.Name = "btnRollbackPaymentService";
            this.btnRollbackPaymentService.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackPaymentService.TabIndex = 2;
            this.btnRollbackPaymentService.Text = "Rollback";
            this.btnRollbackPaymentService.UseVisualStyleBackColor = true;
            this.btnRollbackPaymentService.Click += new System.EventHandler(this.OnRollbackPaymentService);
            // 
            // gbOrderService
            // 
            this.gbOrderService.Controls.Add(this.tableLayoutPanel2);
            this.gbOrderService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderService.Location = new System.Drawing.Point(244, 3);
            this.gbOrderService.Name = "gbOrderService";
            this.gbOrderService.Size = new System.Drawing.Size(235, 79);
            this.gbOrderService.TabIndex = 1;
            this.gbOrderService.TabStop = false;
            this.gbOrderService.Text = "Order Service";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeployOrderService, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbOrderServiceImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRollbackOrderService, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDeployOrderService
            // 
            this.btnDeployOrderService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployOrderService.Location = new System.Drawing.Point(3, 33);
            this.btnDeployOrderService.Name = "btnDeployOrderService";
            this.btnDeployOrderService.Size = new System.Drawing.Size(108, 24);
            this.btnDeployOrderService.TabIndex = 0;
            this.btnDeployOrderService.Text = "Deploy";
            this.btnDeployOrderService.UseVisualStyleBackColor = true;
            this.btnDeployOrderService.Click += new System.EventHandler(this.OnDeployOrderService);
            // 
            // cbOrderServiceImage
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbOrderServiceImage, 2);
            this.cbOrderServiceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOrderServiceImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderServiceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderServiceImage.FormattingEnabled = true;
            this.cbOrderServiceImage.Items.AddRange(new object[] {
            "parameshg/northwind.order:v1"});
            this.cbOrderServiceImage.Location = new System.Drawing.Point(3, 3);
            this.cbOrderServiceImage.Name = "cbOrderServiceImage";
            this.cbOrderServiceImage.Size = new System.Drawing.Size(223, 24);
            this.cbOrderServiceImage.TabIndex = 1;
            this.cbOrderServiceImage.SelectedIndexChanged += new System.EventHandler(this.OnOrderServiceChanged);
            // 
            // btnRollbackOrderService
            // 
            this.btnRollbackOrderService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackOrderService.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackOrderService.Name = "btnRollbackOrderService";
            this.btnRollbackOrderService.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackOrderService.TabIndex = 2;
            this.btnRollbackOrderService.Text = "Rollback";
            this.btnRollbackOrderService.UseVisualStyleBackColor = true;
            this.btnRollbackOrderService.Click += new System.EventHandler(this.OnOrderServiceRollback);
            // 
            // gbProductService
            // 
            this.gbProductService.Controls.Add(this.tlpProductService);
            this.gbProductService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductService.Location = new System.Drawing.Point(3, 3);
            this.gbProductService.Name = "gbProductService";
            this.gbProductService.Size = new System.Drawing.Size(235, 79);
            this.gbProductService.TabIndex = 0;
            this.gbProductService.TabStop = false;
            this.gbProductService.Text = "Product Service";
            // 
            // tlpProductService
            // 
            this.tlpProductService.ColumnCount = 2;
            this.tlpProductService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductService.Controls.Add(this.btnDeployProductService, 0, 1);
            this.tlpProductService.Controls.Add(this.cbProductServiceImage, 0, 0);
            this.tlpProductService.Controls.Add(this.btnRollbackProductService, 1, 1);
            this.tlpProductService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProductService.Location = new System.Drawing.Point(3, 16);
            this.tlpProductService.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProductService.Name = "tlpProductService";
            this.tlpProductService.RowCount = 2;
            this.tlpProductService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductService.Size = new System.Drawing.Size(229, 60);
            this.tlpProductService.TabIndex = 0;
            // 
            // btnDeployProductService
            // 
            this.btnDeployProductService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployProductService.Location = new System.Drawing.Point(3, 33);
            this.btnDeployProductService.Name = "btnDeployProductService";
            this.btnDeployProductService.Size = new System.Drawing.Size(108, 24);
            this.btnDeployProductService.TabIndex = 0;
            this.btnDeployProductService.Text = "Deploy";
            this.btnDeployProductService.UseVisualStyleBackColor = true;
            this.btnDeployProductService.Click += new System.EventHandler(this.OnDeployProductService);
            // 
            // cbProductServiceImage
            // 
            this.tlpProductService.SetColumnSpan(this.cbProductServiceImage, 2);
            this.cbProductServiceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductServiceImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductServiceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductServiceImage.FormattingEnabled = true;
            this.cbProductServiceImage.Items.AddRange(new object[] {
            "parameshg/northwind.product:v1"});
            this.cbProductServiceImage.Location = new System.Drawing.Point(3, 3);
            this.cbProductServiceImage.Name = "cbProductServiceImage";
            this.cbProductServiceImage.Size = new System.Drawing.Size(223, 24);
            this.cbProductServiceImage.TabIndex = 1;
            this.cbProductServiceImage.SelectedIndexChanged += new System.EventHandler(this.OnProductServiceChanged);
            // 
            // btnRollbackProductService
            // 
            this.btnRollbackProductService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackProductService.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackProductService.Name = "btnRollbackProductService";
            this.btnRollbackProductService.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackProductService.TabIndex = 2;
            this.btnRollbackProductService.Text = "Rollback";
            this.btnRollbackProductService.UseVisualStyleBackColor = true;
            this.btnRollbackProductService.Click += new System.EventHandler(this.OnRollbackProductService);
            // 
            // gbLogs
            // 
            this.gbLogs.Controls.Add(this.txtLogs);
            this.gbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLogs.Location = new System.Drawing.Point(3, 403);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(958, 159);
            this.gbLogs.TabIndex = 2;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Location = new System.Drawing.Point(3, 16);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(952, 140);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "";
            // 
            // gbEndpoint
            // 
            this.gbEndpoint.Controls.Add(this.txtEndpoint);
            this.gbEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEndpoint.Location = new System.Drawing.Point(3, 3);
            this.gbEndpoint.Name = "gbEndpoint";
            this.gbEndpoint.Size = new System.Drawing.Size(958, 44);
            this.gbEndpoint.TabIndex = 3;
            this.gbEndpoint.TabStop = false;
            this.gbEndpoint.Text = "Kubernetes Endpoint";
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndpoint.Location = new System.Drawing.Point(3, 16);
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.ReadOnly = true;
            this.txtEndpoint.Size = new System.Drawing.Size(952, 23);
            this.txtEndpoint.TabIndex = 0;
            // 
            // gbMesh
            // 
            this.gbMesh.Controls.Add(this.tlpMesh);
            this.gbMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMesh.Location = new System.Drawing.Point(3, 138);
            this.gbMesh.Name = "gbMesh";
            this.gbMesh.Size = new System.Drawing.Size(958, 94);
            this.gbMesh.TabIndex = 4;
            this.gbMesh.TabStop = false;
            this.gbMesh.Text = "Service Mesh";
            // 
            // tlpMesh
            // 
            this.tlpMesh.ColumnCount = 5;
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMesh.Controls.Add(this.button4, 4, 0);
            this.tlpMesh.Controls.Add(this.button3, 3, 0);
            this.tlpMesh.Controls.Add(this.button2, 2, 0);
            this.tlpMesh.Controls.Add(this.btnDeployMeshMaster, 0, 0);
            this.tlpMesh.Controls.Add(this.button1, 1, 0);
            this.tlpMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesh.Location = new System.Drawing.Point(3, 16);
            this.tlpMesh.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMesh.Name = "tlpMesh";
            this.tlpMesh.RowCount = 1;
            this.tlpMesh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMesh.Size = new System.Drawing.Size(952, 75);
            this.tlpMesh.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(763, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "Install Address Sidecar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(573, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "Install Payment Sidecar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(383, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Install Order Sidecar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDeployMeshMaster
            // 
            this.btnDeployMeshMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployMeshMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployMeshMaster.Location = new System.Drawing.Point(3, 3);
            this.btnDeployMeshMaster.Name = "btnDeployMeshMaster";
            this.btnDeployMeshMaster.Size = new System.Drawing.Size(184, 69);
            this.btnDeployMeshMaster.TabIndex = 0;
            this.btnDeployMeshMaster.Text = "Install Istio Master";
            this.btnDeployMeshMaster.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Install Product Sidecar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 591);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind: Operations";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbAddressService.ResumeLayout(false);
            this.tlpAddressService.ResumeLayout(false);
            this.gbPaymentService.ResumeLayout(false);
            this.tlpPaymentService.ResumeLayout(false);
            this.gbOrderService.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbProductService.ResumeLayout(false);
            this.tlpProductService.ResumeLayout(false);
            this.gbLogs.ResumeLayout(false);
            this.gbEndpoint.ResumeLayout(false);
            this.gbEndpoint.PerformLayout();
            this.gbMesh.ResumeLayout(false);
            this.tlpMesh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbProductService;
        private System.Windows.Forms.TableLayoutPanel tlpProductService;
        private System.Windows.Forms.Button btnDeployProductService;
        private System.Windows.Forms.ComboBox cbProductServiceImage;
        private System.Windows.Forms.GroupBox gbAddressService;
        private System.Windows.Forms.TableLayoutPanel tlpAddressService;
        private System.Windows.Forms.Button btnDeployAddressService;
        private System.Windows.Forms.ComboBox cbAddressServiceImage;
        private System.Windows.Forms.GroupBox gbPaymentService;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentService;
        private System.Windows.Forms.Button btnDeployPaymentService;
        private System.Windows.Forms.ComboBox cbPaymentServiceImage;
        private System.Windows.Forms.GroupBox gbOrderService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDeployOrderService;
        private System.Windows.Forms.ComboBox cbOrderServiceImage;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.Button btnRollbackProductService;
        private System.Windows.Forms.GroupBox gbEndpoint;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Button btnRollbackOrderService;
        private System.Windows.Forms.Button btnRollbackPaymentService;
        private System.Windows.Forms.Button btnRollbackAddressService;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.GroupBox gbMesh;
        private System.Windows.Forms.TableLayoutPanel tlpMesh;
        private System.Windows.Forms.Button btnDeployMeshMaster;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

