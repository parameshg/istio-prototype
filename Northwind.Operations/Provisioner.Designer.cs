namespace Northwind.Operations
{
    partial class Provisioner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provisioner));
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
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
            this.gbEndpoint = new System.Windows.Forms.GroupBox();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.gbMesh = new System.Windows.Forms.GroupBox();
            this.tlpMesh = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeploySidecarAddress = new System.Windows.Forms.Button();
            this.btnDeploySidecarPayment = new System.Windows.Forms.Button();
            this.btnDeploySidecarOrder = new System.Windows.Forms.Button();
            this.btnDeployMesh = new System.Windows.Forms.Button();
            this.btnDeploySidecarProduct = new System.Windows.Forms.Button();
            this.btnUninstallMesh = new System.Windows.Forms.Button();
            this.gbIstioPath = new System.Windows.Forms.GroupBox();
            this.txtIstioPath = new System.Windows.Forms.TextBox();
            this.gbKubeObjects = new System.Windows.Forms.GroupBox();
            this.tlpKubeObject = new System.Windows.Forms.TableLayoutPanel();
            this.btnInstallIngress = new System.Windows.Forms.Button();
            this.btnUninstallIngress = new System.Windows.Forms.Button();
            this.btnInstallIngressController = new System.Windows.Forms.Button();
            this.btnUninstallIngressController = new System.Windows.Forms.Button();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabTerminal = new System.Windows.Forms.TabPage();
            this.txtTerminal = new System.Windows.Forms.RichTextBox();
            this.tabComponents = new System.Windows.Forms.TabPage();
            this.tlpComponents = new System.Windows.Forms.TableLayoutPanel();
            this.gbObjects = new System.Windows.Forms.GroupBox();
            this.lstObjects = new System.Windows.Forms.ListView();
            this.colNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpDashboard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAddressApi.SuspendLayout();
            this.tlpAddressService.SuspendLayout();
            this.gbPaymentApi.SuspendLayout();
            this.tlpPaymentService.SuspendLayout();
            this.gbOrderApi.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbProductApi.SuspendLayout();
            this.tlpProductService.SuspendLayout();
            this.gbEndpoint.SuspendLayout();
            this.gbMesh.SuspendLayout();
            this.tlpMesh.SuspendLayout();
            this.gbIstioPath.SuspendLayout();
            this.gbKubeObjects.SuspendLayout();
            this.tlpKubeObject.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabTerminal.SuspendLayout();
            this.tabComponents.SuspendLayout();
            this.tlpComponents.SuspendLayout();
            this.gbObjects.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.ColumnCount = 1;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpDashboard.Controls.Add(this.gbEndpoint, 0, 0);
            this.tlpDashboard.Controls.Add(this.gbMesh, 0, 4);
            this.tlpDashboard.Controls.Add(this.gbIstioPath, 0, 3);
            this.tlpDashboard.Controls.Add(this.gbKubeObjects, 0, 1);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(3, 3);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 6;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Size = new System.Drawing.Size(944, 598);
            this.tlpDashboard.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 85);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbAddressApi
            // 
            this.gbAddressApi.Controls.Add(this.tlpAddressService);
            this.gbAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressApi.Location = new System.Drawing.Point(711, 3);
            this.gbAddressApi.Name = "gbAddressApi";
            this.gbAddressApi.Size = new System.Drawing.Size(230, 79);
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
            this.tlpAddressService.Size = new System.Drawing.Size(224, 60);
            this.tlpAddressService.TabIndex = 0;
            // 
            // btnDeployAddressApi
            // 
            this.btnDeployAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployAddressApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployAddressApi.Name = "btnDeployAddressApi";
            this.btnDeployAddressApi.Size = new System.Drawing.Size(106, 24);
            this.btnDeployAddressApi.TabIndex = 0;
            this.btnDeployAddressApi.Tag = "address";
            this.btnDeployAddressApi.Text = "Deploy";
            this.btnDeployAddressApi.UseVisualStyleBackColor = true;
            this.btnDeployAddressApi.Click += new System.EventHandler(this.OnDeployApi);
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
            this.cbAddressApiImage.Size = new System.Drawing.Size(218, 24);
            this.cbAddressApiImage.TabIndex = 1;
            // 
            // btnRollbackAddressApi
            // 
            this.btnRollbackAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackAddressApi.Location = new System.Drawing.Point(115, 33);
            this.btnRollbackAddressApi.Name = "btnRollbackAddressApi";
            this.btnRollbackAddressApi.Size = new System.Drawing.Size(106, 24);
            this.btnRollbackAddressApi.TabIndex = 2;
            this.btnRollbackAddressApi.Tag = "address";
            this.btnRollbackAddressApi.Text = "Rollback";
            this.btnRollbackAddressApi.UseVisualStyleBackColor = true;
            this.btnRollbackAddressApi.Click += new System.EventHandler(this.OnRollbackApi);
            // 
            // gbPaymentApi
            // 
            this.gbPaymentApi.Controls.Add(this.tlpPaymentService);
            this.gbPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentApi.Location = new System.Drawing.Point(475, 3);
            this.gbPaymentApi.Name = "gbPaymentApi";
            this.gbPaymentApi.Size = new System.Drawing.Size(230, 79);
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
            this.tlpPaymentService.Size = new System.Drawing.Size(224, 60);
            this.tlpPaymentService.TabIndex = 0;
            // 
            // btnDeployPaymentApi
            // 
            this.btnDeployPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployPaymentApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployPaymentApi.Name = "btnDeployPaymentApi";
            this.btnDeployPaymentApi.Size = new System.Drawing.Size(106, 24);
            this.btnDeployPaymentApi.TabIndex = 0;
            this.btnDeployPaymentApi.Tag = "payment";
            this.btnDeployPaymentApi.Text = "Deploy";
            this.btnDeployPaymentApi.UseVisualStyleBackColor = true;
            this.btnDeployPaymentApi.Click += new System.EventHandler(this.OnDeployApi);
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
            this.cbPaymentApiImage.Size = new System.Drawing.Size(218, 24);
            this.cbPaymentApiImage.TabIndex = 1;
            // 
            // btnRollbackPaymentApi
            // 
            this.btnRollbackPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackPaymentApi.Location = new System.Drawing.Point(115, 33);
            this.btnRollbackPaymentApi.Name = "btnRollbackPaymentApi";
            this.btnRollbackPaymentApi.Size = new System.Drawing.Size(106, 24);
            this.btnRollbackPaymentApi.TabIndex = 2;
            this.btnRollbackPaymentApi.Tag = "payment";
            this.btnRollbackPaymentApi.Text = "Rollback";
            this.btnRollbackPaymentApi.UseVisualStyleBackColor = true;
            this.btnRollbackPaymentApi.Click += new System.EventHandler(this.OnRollbackApi);
            // 
            // gbOrderApi
            // 
            this.gbOrderApi.Controls.Add(this.tableLayoutPanel2);
            this.gbOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderApi.Location = new System.Drawing.Point(239, 3);
            this.gbOrderApi.Name = "gbOrderApi";
            this.gbOrderApi.Size = new System.Drawing.Size(230, 79);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDeployOrderApi
            // 
            this.btnDeployOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployOrderApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployOrderApi.Name = "btnDeployOrderApi";
            this.btnDeployOrderApi.Size = new System.Drawing.Size(106, 24);
            this.btnDeployOrderApi.TabIndex = 0;
            this.btnDeployOrderApi.Tag = "order";
            this.btnDeployOrderApi.Text = "Deploy";
            this.btnDeployOrderApi.UseVisualStyleBackColor = true;
            this.btnDeployOrderApi.Click += new System.EventHandler(this.OnDeployApi);
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
            this.cbOrderApiImage.Size = new System.Drawing.Size(218, 24);
            this.cbOrderApiImage.TabIndex = 1;
            // 
            // btnRollbackOrderApi
            // 
            this.btnRollbackOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackOrderApi.Location = new System.Drawing.Point(115, 33);
            this.btnRollbackOrderApi.Name = "btnRollbackOrderApi";
            this.btnRollbackOrderApi.Size = new System.Drawing.Size(106, 24);
            this.btnRollbackOrderApi.TabIndex = 2;
            this.btnRollbackOrderApi.Tag = "order";
            this.btnRollbackOrderApi.Text = "Rollback";
            this.btnRollbackOrderApi.UseVisualStyleBackColor = true;
            this.btnRollbackOrderApi.Click += new System.EventHandler(this.OnRollbackApi);
            // 
            // gbProductApi
            // 
            this.gbProductApi.Controls.Add(this.tlpProductService);
            this.gbProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductApi.Location = new System.Drawing.Point(3, 3);
            this.gbProductApi.Name = "gbProductApi";
            this.gbProductApi.Size = new System.Drawing.Size(230, 79);
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
            this.tlpProductService.Size = new System.Drawing.Size(224, 60);
            this.tlpProductService.TabIndex = 0;
            // 
            // btnDeployProductApi
            // 
            this.btnDeployProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployProductApi.Location = new System.Drawing.Point(3, 33);
            this.btnDeployProductApi.Name = "btnDeployProductApi";
            this.btnDeployProductApi.Size = new System.Drawing.Size(106, 24);
            this.btnDeployProductApi.TabIndex = 0;
            this.btnDeployProductApi.Tag = "product";
            this.btnDeployProductApi.Text = "Deploy";
            this.btnDeployProductApi.UseVisualStyleBackColor = true;
            this.btnDeployProductApi.Click += new System.EventHandler(this.OnDeployApi);
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
            this.cbProductApiImage.Size = new System.Drawing.Size(218, 24);
            this.cbProductApiImage.TabIndex = 1;
            // 
            // btnRollbackProductApi
            // 
            this.btnRollbackProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackProductApi.Location = new System.Drawing.Point(115, 33);
            this.btnRollbackProductApi.Name = "btnRollbackProductApi";
            this.btnRollbackProductApi.Size = new System.Drawing.Size(106, 24);
            this.btnRollbackProductApi.TabIndex = 2;
            this.btnRollbackProductApi.Tag = "product";
            this.btnRollbackProductApi.Text = "Rollback";
            this.btnRollbackProductApi.UseVisualStyleBackColor = true;
            this.btnRollbackProductApi.Click += new System.EventHandler(this.OnRollbackApi);
            // 
            // gbEndpoint
            // 
            this.gbEndpoint.Controls.Add(this.txtEndpoint);
            this.gbEndpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEndpoint.Location = new System.Drawing.Point(3, 3);
            this.gbEndpoint.Name = "gbEndpoint";
            this.gbEndpoint.Size = new System.Drawing.Size(938, 44);
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
            this.txtEndpoint.Size = new System.Drawing.Size(932, 23);
            this.txtEndpoint.TabIndex = 0;
            // 
            // gbMesh
            // 
            this.gbMesh.Controls.Add(this.tlpMesh);
            this.gbMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMesh.Location = new System.Drawing.Point(3, 288);
            this.gbMesh.Name = "gbMesh";
            this.gbMesh.Size = new System.Drawing.Size(938, 94);
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
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMesh.Controls.Add(this.btnDeploySidecarAddress, 4, 0);
            this.tlpMesh.Controls.Add(this.btnDeploySidecarPayment, 3, 0);
            this.tlpMesh.Controls.Add(this.btnDeploySidecarOrder, 2, 0);
            this.tlpMesh.Controls.Add(this.btnDeployMesh, 0, 0);
            this.tlpMesh.Controls.Add(this.btnDeploySidecarProduct, 1, 0);
            this.tlpMesh.Controls.Add(this.btnUninstallMesh, 0, 1);
            this.tlpMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMesh.Location = new System.Drawing.Point(3, 16);
            this.tlpMesh.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMesh.Name = "tlpMesh";
            this.tlpMesh.RowCount = 2;
            this.tlpMesh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesh.Size = new System.Drawing.Size(932, 75);
            this.tlpMesh.TabIndex = 0;
            // 
            // btnDeploySidecarAddress
            // 
            this.btnDeploySidecarAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeploySidecarAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploySidecarAddress.Location = new System.Drawing.Point(747, 3);
            this.btnDeploySidecarAddress.Name = "btnDeploySidecarAddress";
            this.btnDeploySidecarAddress.Size = new System.Drawing.Size(182, 31);
            this.btnDeploySidecarAddress.TabIndex = 4;
            this.btnDeploySidecarAddress.Tag = "address-v1-deployment";
            this.btnDeploySidecarAddress.Text = "Install Address Sidecar";
            this.btnDeploySidecarAddress.UseVisualStyleBackColor = true;
            this.btnDeploySidecarAddress.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnDeploySidecarPayment
            // 
            this.btnDeploySidecarPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeploySidecarPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploySidecarPayment.Location = new System.Drawing.Point(561, 3);
            this.btnDeploySidecarPayment.Name = "btnDeploySidecarPayment";
            this.btnDeploySidecarPayment.Size = new System.Drawing.Size(180, 31);
            this.btnDeploySidecarPayment.TabIndex = 3;
            this.btnDeploySidecarPayment.Tag = "payment-v1-deployment";
            this.btnDeploySidecarPayment.Text = "Install Payment Sidecar";
            this.btnDeploySidecarPayment.UseVisualStyleBackColor = true;
            this.btnDeploySidecarPayment.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnDeploySidecarOrder
            // 
            this.btnDeploySidecarOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeploySidecarOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploySidecarOrder.Location = new System.Drawing.Point(375, 3);
            this.btnDeploySidecarOrder.Name = "btnDeploySidecarOrder";
            this.btnDeploySidecarOrder.Size = new System.Drawing.Size(180, 31);
            this.btnDeploySidecarOrder.TabIndex = 2;
            this.btnDeploySidecarOrder.Tag = "order-v1-deployment";
            this.btnDeploySidecarOrder.Text = "Install Order Sidecar";
            this.btnDeploySidecarOrder.UseVisualStyleBackColor = true;
            this.btnDeploySidecarOrder.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnDeployMesh
            // 
            this.btnDeployMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployMesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployMesh.Location = new System.Drawing.Point(3, 3);
            this.btnDeployMesh.Name = "btnDeployMesh";
            this.btnDeployMesh.Size = new System.Drawing.Size(180, 31);
            this.btnDeployMesh.TabIndex = 0;
            this.btnDeployMesh.Text = "Install Istio System";
            this.btnDeployMesh.UseVisualStyleBackColor = true;
            this.btnDeployMesh.Click += new System.EventHandler(this.OnDeployMesh);
            // 
            // btnDeploySidecarProduct
            // 
            this.btnDeploySidecarProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeploySidecarProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploySidecarProduct.Location = new System.Drawing.Point(189, 3);
            this.btnDeploySidecarProduct.Name = "btnDeploySidecarProduct";
            this.btnDeploySidecarProduct.Size = new System.Drawing.Size(180, 31);
            this.btnDeploySidecarProduct.TabIndex = 1;
            this.btnDeploySidecarProduct.Tag = "product-v1-deployment";
            this.btnDeploySidecarProduct.Text = "Install Product Sidecar";
            this.btnDeploySidecarProduct.UseVisualStyleBackColor = true;
            this.btnDeploySidecarProduct.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnUninstallMesh
            // 
            this.btnUninstallMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallMesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstallMesh.Location = new System.Drawing.Point(3, 40);
            this.btnUninstallMesh.Name = "btnUninstallMesh";
            this.btnUninstallMesh.Size = new System.Drawing.Size(180, 32);
            this.btnUninstallMesh.TabIndex = 5;
            this.btnUninstallMesh.Text = "Uninstall Istio";
            this.btnUninstallMesh.UseVisualStyleBackColor = true;
            this.btnUninstallMesh.Click += new System.EventHandler(this.OnRollbackMesh);
            // 
            // gbIstioPath
            // 
            this.gbIstioPath.Controls.Add(this.txtIstioPath);
            this.gbIstioPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIstioPath.Location = new System.Drawing.Point(3, 238);
            this.gbIstioPath.Name = "gbIstioPath";
            this.gbIstioPath.Size = new System.Drawing.Size(938, 44);
            this.gbIstioPath.TabIndex = 7;
            this.gbIstioPath.TabStop = false;
            this.gbIstioPath.Text = "Istio Path";
            // 
            // txtIstioPath
            // 
            this.txtIstioPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIstioPath.Location = new System.Drawing.Point(3, 16);
            this.txtIstioPath.Name = "txtIstioPath";
            this.txtIstioPath.Size = new System.Drawing.Size(932, 20);
            this.txtIstioPath.TabIndex = 0;
            this.txtIstioPath.Text = "C:\\istio\\istio-1.0.1-win\\istio-1.0.1";
            // 
            // gbKubeObjects
            // 
            this.gbKubeObjects.Controls.Add(this.tlpKubeObject);
            this.gbKubeObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKubeObjects.Location = new System.Drawing.Point(3, 53);
            this.gbKubeObjects.Name = "gbKubeObjects";
            this.gbKubeObjects.Size = new System.Drawing.Size(938, 94);
            this.gbKubeObjects.TabIndex = 8;
            this.gbKubeObjects.TabStop = false;
            this.gbKubeObjects.Text = "Kubernetes Components";
            // 
            // tlpKubeObject
            // 
            this.tlpKubeObject.ColumnCount = 5;
            this.tlpKubeObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpKubeObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpKubeObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpKubeObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpKubeObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpKubeObject.Controls.Add(this.btnInstallIngress, 1, 0);
            this.tlpKubeObject.Controls.Add(this.btnUninstallIngress, 1, 1);
            this.tlpKubeObject.Controls.Add(this.btnInstallIngressController, 0, 0);
            this.tlpKubeObject.Controls.Add(this.btnUninstallIngressController, 0, 1);
            this.tlpKubeObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKubeObject.Location = new System.Drawing.Point(3, 16);
            this.tlpKubeObject.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKubeObject.Name = "tlpKubeObject";
            this.tlpKubeObject.RowCount = 2;
            this.tlpKubeObject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKubeObject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKubeObject.Size = new System.Drawing.Size(932, 75);
            this.tlpKubeObject.TabIndex = 0;
            // 
            // btnInstallIngress
            // 
            this.btnInstallIngress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallIngress.Location = new System.Drawing.Point(189, 3);
            this.btnInstallIngress.Name = "btnInstallIngress";
            this.btnInstallIngress.Size = new System.Drawing.Size(180, 31);
            this.btnInstallIngress.TabIndex = 1;
            this.btnInstallIngress.Text = "Install Ingress";
            this.btnInstallIngress.UseVisualStyleBackColor = true;
            this.btnInstallIngress.Click += new System.EventHandler(this.OnDeployIngress);
            // 
            // btnUninstallIngress
            // 
            this.btnUninstallIngress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallIngress.Location = new System.Drawing.Point(189, 40);
            this.btnUninstallIngress.Name = "btnUninstallIngress";
            this.btnUninstallIngress.Size = new System.Drawing.Size(180, 32);
            this.btnUninstallIngress.TabIndex = 2;
            this.btnUninstallIngress.Text = "Uninstall Ingress";
            this.btnUninstallIngress.UseVisualStyleBackColor = true;
            this.btnUninstallIngress.Click += new System.EventHandler(this.OnRollbackIngress);
            // 
            // btnInstallIngressController
            // 
            this.btnInstallIngressController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallIngressController.Location = new System.Drawing.Point(3, 3);
            this.btnInstallIngressController.Name = "btnInstallIngressController";
            this.btnInstallIngressController.Size = new System.Drawing.Size(180, 31);
            this.btnInstallIngressController.TabIndex = 3;
            this.btnInstallIngressController.Text = "Install Ingress Controlle";
            this.btnInstallIngressController.UseVisualStyleBackColor = true;
            // 
            // btnUninstallIngressController
            // 
            this.btnUninstallIngressController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallIngressController.Location = new System.Drawing.Point(3, 40);
            this.btnUninstallIngressController.Name = "btnUninstallIngressController";
            this.btnUninstallIngressController.Size = new System.Drawing.Size(180, 32);
            this.btnUninstallIngressController.TabIndex = 4;
            this.btnUninstallIngressController.Text = "Uninstall Ingress Controller";
            this.btnUninstallIngressController.UseVisualStyleBackColor = true;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrlMain.Controls.Add(this.tabDashboard);
            this.tabCtrlMain.Controls.Add(this.tabTerminal);
            this.tabCtrlMain.Controls.Add(this.tabComponents);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(3, 3);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(958, 630);
            this.tabCtrlMain.TabIndex = 3;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.tlpDashboard);
            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(950, 604);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabTerminal
            // 
            this.tabTerminal.Controls.Add(this.txtTerminal);
            this.tabTerminal.Location = new System.Drawing.Point(4, 4);
            this.tabTerminal.Name = "tabTerminal";
            this.tabTerminal.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerminal.Size = new System.Drawing.Size(950, 604);
            this.tabTerminal.TabIndex = 1;
            this.tabTerminal.Text = "Terminal";
            this.tabTerminal.UseVisualStyleBackColor = true;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminal.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.Location = new System.Drawing.Point(3, 3);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(944, 598);
            this.txtTerminal.TabIndex = 1;
            this.txtTerminal.Text = "";
            // 
            // tabComponents
            // 
            this.tabComponents.Controls.Add(this.gbObjects);
            this.tabComponents.Location = new System.Drawing.Point(4, 4);
            this.tabComponents.Name = "tabComponents";
            this.tabComponents.Size = new System.Drawing.Size(950, 604);
            this.tabComponents.TabIndex = 2;
            this.tabComponents.Text = "Components";
            this.tabComponents.UseVisualStyleBackColor = true;
            // 
            // tlpComponents
            // 
            this.tlpComponents.ColumnCount = 1;
            this.tlpComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComponents.Controls.Add(this.lstObjects, 0, 1);
            this.tlpComponents.Controls.Add(this.ToolBar, 0, 0);
            this.tlpComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComponents.Location = new System.Drawing.Point(3, 16);
            this.tlpComponents.Name = "tlpComponents";
            this.tlpComponents.RowCount = 2;
            this.tlpComponents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpComponents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComponents.Size = new System.Drawing.Size(944, 585);
            this.tlpComponents.TabIndex = 0;
            // 
            // gbObjects
            // 
            this.gbObjects.Controls.Add(this.tlpComponents);
            this.gbObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbObjects.Location = new System.Drawing.Point(0, 0);
            this.gbObjects.Name = "gbObjects";
            this.gbObjects.Size = new System.Drawing.Size(950, 604);
            this.gbObjects.TabIndex = 7;
            this.gbObjects.TabStop = false;
            this.gbObjects.Text = "Kubernetes Components";
            // 
            // lstObjects
            // 
            this.lstObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNamespace,
            this.colType,
            this.colName,
            this.colAddress});
            this.lstObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstObjects.FullRowSelect = true;
            this.lstObjects.GridLines = true;
            this.lstObjects.Location = new System.Drawing.Point(3, 28);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(938, 554);
            this.lstObjects.TabIndex = 5;
            this.lstObjects.UseCompatibleStateImageBehavior = false;
            this.lstObjects.View = System.Windows.Forms.View.Details;
            // 
            // colNamespace
            // 
            this.colNamespace.Text = "Namespace";
            this.colNamespace.Width = 100;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 500;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 200;
            // 
            // ToolBar
            // 
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolBar.Size = new System.Drawing.Size(944, 25);
            this.ToolBar.TabIndex = 4;
            this.ToolBar.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.OnRefresh);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tabCtrlMain, 0, 0);
            this.tlpMain.Controls.Add(this.StatusBar, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(964, 661);
            this.tlpMain.TabIndex = 4;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage});
            this.StatusBar.Location = new System.Drawing.Point(0, 637);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(964, 24);
            this.StatusBar.TabIndex = 5;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusMessage
            // 
            this.StatusMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusMessage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(949, 19);
            this.StatusMessage.Spring = true;
            this.StatusMessage.Text = "Ready";
            this.StatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Provisioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.tlpMain);
            this.Name = "Provisioner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind: Provisioner";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tlpDashboard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbAddressApi.ResumeLayout(false);
            this.tlpAddressService.ResumeLayout(false);
            this.gbPaymentApi.ResumeLayout(false);
            this.tlpPaymentService.ResumeLayout(false);
            this.gbOrderApi.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbProductApi.ResumeLayout(false);
            this.tlpProductService.ResumeLayout(false);
            this.gbEndpoint.ResumeLayout(false);
            this.gbEndpoint.PerformLayout();
            this.gbMesh.ResumeLayout(false);
            this.tlpMesh.ResumeLayout(false);
            this.gbIstioPath.ResumeLayout(false);
            this.gbIstioPath.PerformLayout();
            this.gbKubeObjects.ResumeLayout(false);
            this.tlpKubeObject.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabTerminal.ResumeLayout(false);
            this.tabComponents.ResumeLayout(false);
            this.tlpComponents.ResumeLayout(false);
            this.tlpComponents.PerformLayout();
            this.gbObjects.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
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
        private System.Windows.Forms.Button btnRollbackProductApi;
        private System.Windows.Forms.GroupBox gbEndpoint;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Button btnRollbackOrderApi;
        private System.Windows.Forms.Button btnRollbackPaymentApi;
        private System.Windows.Forms.Button btnRollbackAddressApi;
        private System.Windows.Forms.GroupBox gbMesh;
        private System.Windows.Forms.TableLayoutPanel tlpMesh;
        private System.Windows.Forms.Button btnDeployMesh;
        private System.Windows.Forms.Button btnDeploySidecarAddress;
        private System.Windows.Forms.Button btnDeploySidecarPayment;
        private System.Windows.Forms.Button btnDeploySidecarOrder;
        private System.Windows.Forms.Button btnDeploySidecarProduct;
        private System.Windows.Forms.GroupBox gbIstioPath;
        private System.Windows.Forms.TextBox txtIstioPath;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabTerminal;
        private System.Windows.Forms.RichTextBox txtTerminal;
        private System.Windows.Forms.GroupBox gbKubeObjects;
        private System.Windows.Forms.TableLayoutPanel tlpKubeObject;
        private System.Windows.Forms.Button btnInstallIngress;
        private System.Windows.Forms.Button btnUninstallIngress;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessage;
        private System.Windows.Forms.TabPage tabComponents;
        private System.Windows.Forms.TableLayoutPanel tlpComponents;
        private System.Windows.Forms.GroupBox gbObjects;
        private System.Windows.Forms.ListView lstObjects;
        private System.Windows.Forms.ColumnHeader colNamespace;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.Button btnInstallIngressController;
        private System.Windows.Forms.Button btnUninstallIngressController;
        private System.Windows.Forms.Button btnUninstallMesh;
    }
}

