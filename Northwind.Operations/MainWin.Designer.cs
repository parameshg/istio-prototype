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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddressApi = new System.Windows.Forms.GroupBox();
            this.tlpAddressService = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployAddressApi = new System.Windows.Forms.Button();
            this.cbAddressApiImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackAddressApi = new System.Windows.Forms.Button();
            this.gbPaymentApi = new System.Windows.Forms.GroupBox();
            this.tlpPaymentService = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployPaymentApi = new System.Windows.Forms.Button();
            this.cbPaymentApiImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackPaymentApi = new System.Windows.Forms.Button();
            this.gbOrderApi = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployOrderApi = new System.Windows.Forms.Button();
            this.cbOrderApiImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackOrderApi = new System.Windows.Forms.Button();
            this.gbProductApi = new System.Windows.Forms.GroupBox();
            this.tlpProductService = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeployProductApi = new System.Windows.Forms.Button();
            this.cbProductApiImage = new System.Windows.Forms.ComboBox();
            this.btnRollbackProductApi = new System.Windows.Forms.Button();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.gbEndpoint = new System.Windows.Forms.GroupBox();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.gbMesh = new System.Windows.Forms.GroupBox();
            this.tlpMesh = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeployMesh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpKubeObjects = new System.Windows.Forms.TableLayoutPanel();
            this.gbPods = new System.Windows.Forms.GroupBox();
            this.lstPods = new System.Windows.Forms.ListView();
            this.colPod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPods = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRefreshPods = new System.Windows.Forms.ToolStripMenuItem();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.lstServices = new System.Windows.Forms.ListView();
            this.colServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServiceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServiceAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRefreshServices = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNamespaces = new System.Windows.Forms.GroupBox();
            this.lstNamespaces = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsNamespaces = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAddressApi.SuspendLayout();
            this.tlpAddressService.SuspendLayout();
            this.gbPaymentApi.SuspendLayout();
            this.tlpPaymentService.SuspendLayout();
            this.gbOrderApi.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbProductApi.SuspendLayout();
            this.tlpProductService.SuspendLayout();
            this.gbLogs.SuspendLayout();
            this.gbEndpoint.SuspendLayout();
            this.gbMesh.SuspendLayout();
            this.tlpMesh.SuspendLayout();
            this.tlpKubeObjects.SuspendLayout();
            this.gbPods.SuspendLayout();
            this.cmsPods.SuspendLayout();
            this.gbServices.SuspendLayout();
            this.cmsServices.SuspendLayout();
            this.gbNamespaces.SuspendLayout();
            this.cmsNamespaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.StatusBar, 0, 6);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMain.Controls.Add(this.gbLogs, 0, 5);
            this.tlpMain.Controls.Add(this.gbEndpoint, 0, 0);
            this.tlpMain.Controls.Add(this.gbMesh, 0, 2);
            this.tlpMain.Controls.Add(this.tlpKubeObjects, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.Size = new System.Drawing.Size(964, 591);
            this.tlpMain.TabIndex = 0;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage,
            this.ProgressBar});
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
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 18);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.Value = 50;
            this.ProgressBar.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gbAddressApi, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbPaymentApi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbOrderApi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbProductApi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 85);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbAddressApi
            // 
            this.gbAddressApi.Controls.Add(this.tlpAddressService);
            this.gbAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressApi.Location = new System.Drawing.Point(726, 3);
            this.gbAddressApi.Name = "gbAddressApi";
            this.gbAddressApi.Size = new System.Drawing.Size(235, 79);
            this.gbAddressApi.TabIndex = 1;
            this.gbAddressApi.TabStop = false;
            this.gbAddressApi.Text = "Address Api";
            // 
            // tlpAddressService
            // 
            this.tlpAddressService.ColumnCount = 2;
            this.tlpAddressService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddressService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddressService.Controls.Add(this.btnDeployAddressApi, 0, 1);
            this.tlpAddressService.Controls.Add(this.cbAddressApiImage, 0, 0);
            this.tlpAddressService.Controls.Add(this.btnRollbackAddressApi, 1, 1);
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
            // btnDeployAddressApi
            // 
            this.btnDeployAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployAddressApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployAddressApi.Name = "btnDeployAddressApi";
            this.btnDeployAddressApi.Size = new System.Drawing.Size(108, 24);
            this.btnDeployAddressApi.TabIndex = 0;
            this.btnDeployAddressApi.Text = "Deploy";
            this.btnDeployAddressApi.UseVisualStyleBackColor = true;
            this.btnDeployAddressApi.Click += new System.EventHandler(this.OnDeployAddressApi);
            // 
            // cbAddressApiImage
            // 
            this.tlpAddressService.SetColumnSpan(this.cbAddressApiImage, 2);
            this.cbAddressApiImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAddressApiImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddressApiImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddressApiImage.FormattingEnabled = true;
            this.cbAddressApiImage.Items.AddRange(new object[] {
            "parameshg/northwind.address:v1",
            "parameshg/northwind.address:v2",
            "parameshg/northwind.address:v3"});
            this.cbAddressApiImage.Location = new System.Drawing.Point(3, 3);
            this.cbAddressApiImage.Name = "cbAddressApiImage";
            this.cbAddressApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbAddressApiImage.TabIndex = 1;
            this.cbAddressApiImage.SelectedIndexChanged += new System.EventHandler(this.OnAddressServiceChanged);
            // 
            // btnRollbackAddressApi
            // 
            this.btnRollbackAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackAddressApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackAddressApi.Name = "btnRollbackAddressApi";
            this.btnRollbackAddressApi.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackAddressApi.TabIndex = 2;
            this.btnRollbackAddressApi.Text = "Rollback";
            this.btnRollbackAddressApi.UseVisualStyleBackColor = true;
            this.btnRollbackAddressApi.Click += new System.EventHandler(this.OnRollbackAddressApi);
            // 
            // gbPaymentApi
            // 
            this.gbPaymentApi.Controls.Add(this.tlpPaymentService);
            this.gbPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentApi.Location = new System.Drawing.Point(485, 3);
            this.gbPaymentApi.Name = "gbPaymentApi";
            this.gbPaymentApi.Size = new System.Drawing.Size(235, 79);
            this.gbPaymentApi.TabIndex = 1;
            this.gbPaymentApi.TabStop = false;
            this.gbPaymentApi.Text = "Payment Api";
            // 
            // tlpPaymentService
            // 
            this.tlpPaymentService.ColumnCount = 2;
            this.tlpPaymentService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentService.Controls.Add(this.btnDeployPaymentApi, 0, 1);
            this.tlpPaymentService.Controls.Add(this.cbPaymentApiImage, 0, 0);
            this.tlpPaymentService.Controls.Add(this.btnRollbackPaymentApi, 1, 1);
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
            // btnDeployPaymentApi
            // 
            this.btnDeployPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployPaymentApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployPaymentApi.Name = "btnDeployPaymentApi";
            this.btnDeployPaymentApi.Size = new System.Drawing.Size(108, 24);
            this.btnDeployPaymentApi.TabIndex = 0;
            this.btnDeployPaymentApi.Text = "Deploy";
            this.btnDeployPaymentApi.UseVisualStyleBackColor = true;
            this.btnDeployPaymentApi.Click += new System.EventHandler(this.OnDeployPaymentApi);
            // 
            // cbPaymentApiImage
            // 
            this.tlpPaymentService.SetColumnSpan(this.cbPaymentApiImage, 2);
            this.cbPaymentApiImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPaymentApiImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentApiImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentApiImage.FormattingEnabled = true;
            this.cbPaymentApiImage.Items.AddRange(new object[] {
            "parameshg/northwind.payment:v1",
            "parameshg/northwind.payment:v2"});
            this.cbPaymentApiImage.Location = new System.Drawing.Point(3, 3);
            this.cbPaymentApiImage.Name = "cbPaymentApiImage";
            this.cbPaymentApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbPaymentApiImage.TabIndex = 1;
            this.cbPaymentApiImage.SelectedIndexChanged += new System.EventHandler(this.OnPaymentServiceChanged);
            // 
            // btnRollbackPaymentApi
            // 
            this.btnRollbackPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackPaymentApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackPaymentApi.Name = "btnRollbackPaymentApi";
            this.btnRollbackPaymentApi.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackPaymentApi.TabIndex = 2;
            this.btnRollbackPaymentApi.Text = "Rollback";
            this.btnRollbackPaymentApi.UseVisualStyleBackColor = true;
            this.btnRollbackPaymentApi.Click += new System.EventHandler(this.OnRollbackPaymentApi);
            // 
            // gbOrderApi
            // 
            this.gbOrderApi.Controls.Add(this.tableLayoutPanel2);
            this.gbOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderApi.Location = new System.Drawing.Point(244, 3);
            this.gbOrderApi.Name = "gbOrderApi";
            this.gbOrderApi.Size = new System.Drawing.Size(235, 79);
            this.gbOrderApi.TabIndex = 1;
            this.gbOrderApi.TabStop = false;
            this.gbOrderApi.Text = "Order Api";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeployOrderApi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbOrderApiImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRollbackOrderApi, 1, 1);
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
            // btnDeployOrderApi
            // 
            this.btnDeployOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployOrderApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployOrderApi.Name = "btnDeployOrderApi";
            this.btnDeployOrderApi.Size = new System.Drawing.Size(108, 24);
            this.btnDeployOrderApi.TabIndex = 0;
            this.btnDeployOrderApi.Text = "Deploy";
            this.btnDeployOrderApi.UseVisualStyleBackColor = true;
            this.btnDeployOrderApi.Click += new System.EventHandler(this.OnDeployOrderApi);
            // 
            // cbOrderApiImage
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbOrderApiImage, 2);
            this.cbOrderApiImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOrderApiImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderApiImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderApiImage.FormattingEnabled = true;
            this.cbOrderApiImage.Items.AddRange(new object[] {
            "parameshg/northwind.order:v1"});
            this.cbOrderApiImage.Location = new System.Drawing.Point(3, 3);
            this.cbOrderApiImage.Name = "cbOrderApiImage";
            this.cbOrderApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbOrderApiImage.TabIndex = 1;
            this.cbOrderApiImage.SelectedIndexChanged += new System.EventHandler(this.OnOrderServiceChanged);
            // 
            // btnRollbackOrderApi
            // 
            this.btnRollbackOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackOrderApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackOrderApi.Name = "btnRollbackOrderApi";
            this.btnRollbackOrderApi.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackOrderApi.TabIndex = 2;
            this.btnRollbackOrderApi.Text = "Rollback";
            this.btnRollbackOrderApi.UseVisualStyleBackColor = true;
            this.btnRollbackOrderApi.Click += new System.EventHandler(this.OnRollbackOrderApi);
            // 
            // gbProductApi
            // 
            this.gbProductApi.Controls.Add(this.tlpProductService);
            this.gbProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductApi.Location = new System.Drawing.Point(3, 3);
            this.gbProductApi.Name = "gbProductApi";
            this.gbProductApi.Size = new System.Drawing.Size(235, 79);
            this.gbProductApi.TabIndex = 0;
            this.gbProductApi.TabStop = false;
            this.gbProductApi.Text = "Product Api";
            // 
            // tlpProductService
            // 
            this.tlpProductService.ColumnCount = 2;
            this.tlpProductService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductService.Controls.Add(this.btnDeployProductApi, 0, 1);
            this.tlpProductService.Controls.Add(this.cbProductApiImage, 0, 0);
            this.tlpProductService.Controls.Add(this.btnRollbackProductApi, 1, 1);
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
            // btnDeployProductApi
            // 
            this.btnDeployProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployProductApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployProductApi.Name = "btnDeployProductApi";
            this.btnDeployProductApi.Size = new System.Drawing.Size(108, 24);
            this.btnDeployProductApi.TabIndex = 0;
            this.btnDeployProductApi.Text = "Deploy";
            this.btnDeployProductApi.UseVisualStyleBackColor = true;
            this.btnDeployProductApi.Click += new System.EventHandler(this.OnDeployProductApi);
            // 
            // cbProductApiImage
            // 
            this.tlpProductService.SetColumnSpan(this.cbProductApiImage, 2);
            this.cbProductApiImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductApiImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductApiImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductApiImage.FormattingEnabled = true;
            this.cbProductApiImage.Items.AddRange(new object[] {
            "parameshg/northwind.product:v1"});
            this.cbProductApiImage.Location = new System.Drawing.Point(3, 3);
            this.cbProductApiImage.Name = "cbProductApiImage";
            this.cbProductApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbProductApiImage.TabIndex = 1;
            this.cbProductApiImage.SelectedIndexChanged += new System.EventHandler(this.OnProductServiceChanged);
            // 
            // btnRollbackProductApi
            // 
            this.btnRollbackProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackProductApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackProductApi.Name = "btnRollbackProductApi";
            this.btnRollbackProductApi.Size = new System.Drawing.Size(109, 24);
            this.btnRollbackProductApi.TabIndex = 2;
            this.btnRollbackProductApi.Text = "Rollback";
            this.btnRollbackProductApi.UseVisualStyleBackColor = true;
            this.btnRollbackProductApi.Click += new System.EventHandler(this.OnRollbackProductApi);
            // 
            // gbLogs
            // 
            this.gbLogs.Controls.Add(this.txtLogs);
            this.gbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLogs.Location = new System.Drawing.Point(3, 413);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(958, 149);
            this.gbLogs.TabIndex = 2;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Location = new System.Drawing.Point(3, 16);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(952, 130);
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
            this.tlpMesh.Controls.Add(this.btnDeployMesh, 0, 0);
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
            // btnDeployMesh
            // 
            this.btnDeployMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployMesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployMesh.Location = new System.Drawing.Point(3, 3);
            this.btnDeployMesh.Name = "btnDeployMesh";
            this.btnDeployMesh.Size = new System.Drawing.Size(184, 69);
            this.btnDeployMesh.TabIndex = 0;
            this.btnDeployMesh.Text = "Install Istio";
            this.btnDeployMesh.UseVisualStyleBackColor = true;
            this.btnDeployMesh.Click += new System.EventHandler(this.OnDeployMesh);
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
            // tlpKubeObjects
            // 
            this.tlpKubeObjects.ColumnCount = 3;
            this.tlpKubeObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpKubeObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKubeObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKubeObjects.Controls.Add(this.gbPods, 1, 0);
            this.tlpKubeObjects.Controls.Add(this.gbServices, 2, 0);
            this.tlpKubeObjects.Controls.Add(this.gbNamespaces, 0, 0);
            this.tlpKubeObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKubeObjects.Location = new System.Drawing.Point(0, 255);
            this.tlpKubeObjects.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKubeObjects.Name = "tlpKubeObjects";
            this.tlpKubeObjects.RowCount = 1;
            this.tlpKubeObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKubeObjects.Size = new System.Drawing.Size(964, 155);
            this.tlpKubeObjects.TabIndex = 6;
            // 
            // gbPods
            // 
            this.gbPods.Controls.Add(this.lstPods);
            this.gbPods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPods.Location = new System.Drawing.Point(153, 3);
            this.gbPods.Name = "gbPods";
            this.gbPods.Size = new System.Drawing.Size(401, 149);
            this.gbPods.TabIndex = 6;
            this.gbPods.TabStop = false;
            this.gbPods.Text = "Pods";
            // 
            // lstPods
            // 
            this.lstPods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPod,
            this.colStatus,
            this.colAddress});
            this.lstPods.ContextMenuStrip = this.cmsPods;
            this.lstPods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPods.FullRowSelect = true;
            this.lstPods.GridLines = true;
            this.lstPods.Location = new System.Drawing.Point(3, 16);
            this.lstPods.Name = "lstPods";
            this.lstPods.Size = new System.Drawing.Size(395, 130);
            this.lstPods.TabIndex = 5;
            this.lstPods.UseCompatibleStateImageBehavior = false;
            this.lstPods.View = System.Windows.Forms.View.Details;
            // 
            // colPod
            // 
            this.colPod.Text = "Name";
            this.colPod.Width = 175;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 100;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 100;
            // 
            // cmsPods
            // 
            this.cmsPods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefreshPods});
            this.cmsPods.Name = "cmsPods";
            this.cmsPods.Size = new System.Drawing.Size(114, 26);
            // 
            // tsmiRefreshPods
            // 
            this.tsmiRefreshPods.Name = "tsmiRefreshPods";
            this.tsmiRefreshPods.Size = new System.Drawing.Size(113, 22);
            this.tsmiRefreshPods.Text = "Refresh";
            this.tsmiRefreshPods.Click += new System.EventHandler(this.OnPodRefreshed);
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.lstServices);
            this.gbServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServices.Location = new System.Drawing.Point(560, 3);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(401, 149);
            this.gbServices.TabIndex = 7;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Services";
            // 
            // lstServices
            // 
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colServiceName,
            this.colServiceStatus,
            this.colServiceAddress});
            this.lstServices.ContextMenuStrip = this.cmsServices;
            this.lstServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstServices.FullRowSelect = true;
            this.lstServices.GridLines = true;
            this.lstServices.Location = new System.Drawing.Point(3, 16);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(395, 130);
            this.lstServices.TabIndex = 6;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            this.lstServices.View = System.Windows.Forms.View.Details;
            this.lstServices.DoubleClick += new System.EventHandler(this.OnServicesDoubleClicked);
            // 
            // colServiceName
            // 
            this.colServiceName.Text = "Name";
            this.colServiceName.Width = 175;
            // 
            // colServiceStatus
            // 
            this.colServiceStatus.Text = "Status";
            this.colServiceStatus.Width = 100;
            // 
            // colServiceAddress
            // 
            this.colServiceAddress.Text = "Address";
            this.colServiceAddress.Width = 100;
            // 
            // cmsServices
            // 
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefreshServices});
            this.cmsServices.Name = "cmsServices";
            this.cmsServices.Size = new System.Drawing.Size(114, 26);
            // 
            // tsmiRefreshServices
            // 
            this.tsmiRefreshServices.Name = "tsmiRefreshServices";
            this.tsmiRefreshServices.Size = new System.Drawing.Size(113, 22);
            this.tsmiRefreshServices.Text = "Refresh";
            this.tsmiRefreshServices.Click += new System.EventHandler(this.OnServiceRefreshed);
            // 
            // gbNamespaces
            // 
            this.gbNamespaces.Controls.Add(this.lstNamespaces);
            this.gbNamespaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNamespaces.Location = new System.Drawing.Point(3, 3);
            this.gbNamespaces.Name = "gbNamespaces";
            this.gbNamespaces.Size = new System.Drawing.Size(144, 149);
            this.gbNamespaces.TabIndex = 8;
            this.gbNamespaces.TabStop = false;
            this.gbNamespaces.Text = "Namespaces";
            // 
            // lstNamespaces
            // 
            this.lstNamespaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.lstNamespaces.ContextMenuStrip = this.cmsNamespaces;
            this.lstNamespaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNamespaces.FullRowSelect = true;
            this.lstNamespaces.GridLines = true;
            this.lstNamespaces.Location = new System.Drawing.Point(3, 16);
            this.lstNamespaces.Name = "lstNamespaces";
            this.lstNamespaces.Size = new System.Drawing.Size(138, 130);
            this.lstNamespaces.TabIndex = 0;
            this.lstNamespaces.UseCompatibleStateImageBehavior = false;
            this.lstNamespaces.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 125;
            // 
            // cmsNamespaces
            // 
            this.cmsNamespaces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.cmsNamespaces.Name = "cmsNamespaces";
            this.cmsNamespaces.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.OnNamespaceRefreshed);
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
            this.gbAddressApi.ResumeLayout(false);
            this.tlpAddressService.ResumeLayout(false);
            this.gbPaymentApi.ResumeLayout(false);
            this.tlpPaymentService.ResumeLayout(false);
            this.gbOrderApi.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbProductApi.ResumeLayout(false);
            this.tlpProductService.ResumeLayout(false);
            this.gbLogs.ResumeLayout(false);
            this.gbEndpoint.ResumeLayout(false);
            this.gbEndpoint.PerformLayout();
            this.gbMesh.ResumeLayout(false);
            this.tlpMesh.ResumeLayout(false);
            this.tlpKubeObjects.ResumeLayout(false);
            this.gbPods.ResumeLayout(false);
            this.cmsPods.ResumeLayout(false);
            this.gbServices.ResumeLayout(false);
            this.cmsServices.ResumeLayout(false);
            this.gbNamespaces.ResumeLayout(false);
            this.cmsNamespaces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbProductApi;
        private System.Windows.Forms.TableLayoutPanel tlpProductService;
        private System.Windows.Forms.Button btnDeployProductApi;
        private System.Windows.Forms.ComboBox cbProductApiImage;
        private System.Windows.Forms.GroupBox gbAddressApi;
        private System.Windows.Forms.TableLayoutPanel tlpAddressService;
        private System.Windows.Forms.Button btnDeployAddressApi;
        private System.Windows.Forms.ComboBox cbAddressApiImage;
        private System.Windows.Forms.GroupBox gbPaymentApi;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentService;
        private System.Windows.Forms.Button btnDeployPaymentApi;
        private System.Windows.Forms.ComboBox cbPaymentApiImage;
        private System.Windows.Forms.GroupBox gbOrderApi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDeployOrderApi;
        private System.Windows.Forms.ComboBox cbOrderApiImage;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.Button btnRollbackProductApi;
        private System.Windows.Forms.GroupBox gbEndpoint;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Button btnRollbackOrderApi;
        private System.Windows.Forms.Button btnRollbackPaymentApi;
        private System.Windows.Forms.Button btnRollbackAddressApi;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.GroupBox gbMesh;
        private System.Windows.Forms.TableLayoutPanel tlpMesh;
        private System.Windows.Forms.Button btnDeployMesh;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ListView lstPods;
        private System.Windows.Forms.ColumnHeader colPod;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.TableLayoutPanel tlpKubeObjects;
        private System.Windows.Forms.GroupBox gbPods;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.ContextMenuStrip cmsPods;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshPods;
        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.ColumnHeader colServiceName;
        private System.Windows.Forms.ColumnHeader colServiceStatus;
        private System.Windows.Forms.ColumnHeader colServiceAddress;
        private System.Windows.Forms.ContextMenuStrip cmsServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshServices;
        private System.Windows.Forms.GroupBox gbNamespaces;
        private System.Windows.Forms.ContextMenuStrip cmsNamespaces;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ListView lstNamespaces;
        private System.Windows.Forms.ColumnHeader colName;
    }
}

