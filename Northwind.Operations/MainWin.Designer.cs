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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnInstallAddressSidecar = new System.Windows.Forms.Button();
            this.btnInstallPaymentSidecar = new System.Windows.Forms.Button();
            this.btnInstallOrderSidecar = new System.Windows.Forms.Button();
            this.btnDeployMesh = new System.Windows.Forms.Button();
            this.btnInstallProductSidecar = new System.Windows.Forms.Button();
            this.btnUninstallMesh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbIstioPath = new System.Windows.Forms.GroupBox();
            this.txtIstioPath = new System.Windows.Forms.TextBox();
            this.gbKubeObjects = new System.Windows.Forms.GroupBox();
            this.tlpKubeObject = new System.Windows.Forms.TableLayoutPanel();
            this.btnInstallIngress = new System.Windows.Forms.Button();
            this.btnUninstallIngress = new System.Windows.Forms.Button();
            this.btnInstallIngressController = new System.Windows.Forms.Button();
            this.btnUninstallIngressController = new System.Windows.Forms.Button();
            this.btnDeployAllApi = new System.Windows.Forms.Button();
            this.btnRollbackAllApi = new System.Windows.Forms.Button();
            this.btnInstallSIdecars = new System.Windows.Forms.Button();
            this.btnUninstallSidecars = new System.Windows.Forms.Button();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabTerminal = new System.Windows.Forms.TabPage();
            this.gbTerminal = new System.Windows.Forms.GroupBox();
            this.tlpTerminal = new System.Windows.Forms.TableLayoutPanel();
            this.txtTerminal = new System.Windows.Forms.RichTextBox();
            this.tsTerminal = new System.Windows.Forms.ToolStrip();
            this.btnClearTerminal = new System.Windows.Forms.ToolStripButton();
            this.tabComponents = new System.Windows.Forms.TabPage();
            this.gbObjects = new System.Windows.Forms.GroupBox();
            this.tlpComponents = new System.Windows.Forms.TableLayoutPanel();
            this.lstObjects = new System.Windows.Forms.ListView();
            this.colNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tabTransaction = new System.Windows.Forms.TabPage();
            this.tlpTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.tlpOrder = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabFeatures = new System.Windows.Forms.TabPage();
            this.tlpFeatures = new System.Windows.Forms.TableLayoutPanel();
            this.gbBlueGreenDeployment = new System.Windows.Forms.GroupBox();
            this.tlpBlueGreenDeployment = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnAddressVersion1 = new System.Windows.Forms.RadioButton();
            this.rbtnAddressVersion2 = new System.Windows.Forms.RadioButton();
            this.rbtnAddressVersion3 = new System.Windows.Forms.RadioButton();
            this.pnlPaymentVersions = new System.Windows.Forms.Panel();
            this.tlpPaymentVersions = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnPaymentVersion2 = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentVersion1 = new System.Windows.Forms.RadioButton();
            this.gbPaymentCanaryRelease = new System.Windows.Forms.GroupBox();
            this.tbPaymentCanaryRelease = new System.Windows.Forms.TrackBar();
            this.gbAddressCanaryRelease = new System.Windows.Forms.GroupBox();
            this.tbAddressCanaryRelease = new System.Windows.Forms.TrackBar();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.tlpFeaturesTest = new System.Windows.Forms.TableLayoutPanel();
            this.tlpOrderFeatureTest = new System.Windows.Forms.TableLayoutPanel();
            this.cbAddressTest = new System.Windows.Forms.ComboBox();
            this.cbPaymentTest = new System.Windows.Forms.ComboBox();
            this.btnSubmitOrderTest = new System.Windows.Forms.Button();
            this.nOrders = new System.Windows.Forms.NumericUpDown();
            this.tlpTestPodMetrics = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddressPod3 = new System.Windows.Forms.GroupBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.gbAddressPod2 = new System.Windows.Forms.GroupBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.gbAddressPod1 = new System.Windows.Forms.GroupBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.gbPaymentPod2 = new System.Windows.Forms.GroupBox();
            this.txtPayment2 = new System.Windows.Forms.TextBox();
            this.gbPaymentPod1 = new System.Windows.Forms.GroupBox();
            this.txtPayment1 = new System.Windows.Forms.TextBox();
            this.tlpRequestMetrics = new System.Windows.Forms.TableLayoutPanel();
            this.gbRequestFailed = new System.Windows.Forms.GroupBox();
            this.txtRequestFailed = new System.Windows.Forms.TextBox();
            this.gbRequestPassed = new System.Windows.Forms.GroupBox();
            this.txtRequestPassed = new System.Windows.Forms.TextBox();
            this.gbRequestSent = new System.Windows.Forms.GroupBox();
            this.txtRequestSent = new System.Windows.Forms.TextBox();
            this.pbTestProgress = new System.Windows.Forms.ProgressBar();
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
            this.gbTerminal.SuspendLayout();
            this.tlpTerminal.SuspendLayout();
            this.tsTerminal.SuspendLayout();
            this.tabComponents.SuspendLayout();
            this.gbObjects.SuspendLayout();
            this.tlpComponents.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.tabTransaction.SuspendLayout();
            this.tlpTransaction.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.tlpOrder.SuspendLayout();
            this.gbProduct.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            this.tabFeatures.SuspendLayout();
            this.tlpFeatures.SuspendLayout();
            this.gbBlueGreenDeployment.SuspendLayout();
            this.tlpBlueGreenDeployment.SuspendLayout();
            this.pnlPaymentVersions.SuspendLayout();
            this.tlpPaymentVersions.SuspendLayout();
            this.gbPaymentCanaryRelease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPaymentCanaryRelease)).BeginInit();
            this.gbAddressCanaryRelease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddressCanaryRelease)).BeginInit();
            this.gbTest.SuspendLayout();
            this.tlpFeaturesTest.SuspendLayout();
            this.tlpOrderFeatureTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOrders)).BeginInit();
            this.tlpTestPodMetrics.SuspendLayout();
            this.gbAddressPod3.SuspendLayout();
            this.gbAddressPod2.SuspendLayout();
            this.gbAddressPod1.SuspendLayout();
            this.gbPaymentPod2.SuspendLayout();
            this.gbPaymentPod1.SuspendLayout();
            this.tlpRequestMetrics.SuspendLayout();
            this.gbRequestFailed.SuspendLayout();
            this.gbRequestPassed.SuspendLayout();
            this.gbRequestSent.SuspendLayout();
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
            this.tlpDashboard.Size = new System.Drawing.Size(964, 598);
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
            this.cbAddressApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbAddressApiImage.TabIndex = 1;
            this.cbAddressApiImage.Tag = "address";
            // 
            // btnRollbackAddressApi
            // 
            this.btnRollbackAddressApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackAddressApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackAddressApi.Name = "btnRollbackAddressApi";
            this.btnRollbackAddressApi.Size = new System.Drawing.Size(109, 24);
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
            this.cbPaymentApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbPaymentApiImage.TabIndex = 1;
            this.cbPaymentApiImage.Tag = "payment";
            // 
            // btnRollbackPaymentApi
            // 
            this.btnRollbackPaymentApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackPaymentApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackPaymentApi.Name = "btnRollbackPaymentApi";
            this.btnRollbackPaymentApi.Size = new System.Drawing.Size(109, 24);
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
            this.cbOrderApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbOrderApiImage.TabIndex = 1;
            this.cbOrderApiImage.Tag = "order";
            // 
            // btnRollbackOrderApi
            // 
            this.btnRollbackOrderApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackOrderApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackOrderApi.Name = "btnRollbackOrderApi";
            this.btnRollbackOrderApi.Size = new System.Drawing.Size(109, 24);
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
            this.cbProductApiImage.Size = new System.Drawing.Size(223, 24);
            this.cbProductApiImage.TabIndex = 1;
            this.cbProductApiImage.Tag = "product";
            // 
            // btnRollbackProductApi
            // 
            this.btnRollbackProductApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackProductApi.Location = new System.Drawing.Point(117, 33);
            this.btnRollbackProductApi.Name = "btnRollbackProductApi";
            this.btnRollbackProductApi.Size = new System.Drawing.Size(109, 24);
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
            this.gbMesh.Location = new System.Drawing.Point(3, 288);
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
            this.tlpMesh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMesh.Controls.Add(this.button6, 4, 1);
            this.tlpMesh.Controls.Add(this.button5, 3, 1);
            this.tlpMesh.Controls.Add(this.button4, 2, 1);
            this.tlpMesh.Controls.Add(this.btnInstallAddressSidecar, 4, 0);
            this.tlpMesh.Controls.Add(this.btnInstallPaymentSidecar, 3, 0);
            this.tlpMesh.Controls.Add(this.btnInstallOrderSidecar, 2, 0);
            this.tlpMesh.Controls.Add(this.btnDeployMesh, 0, 0);
            this.tlpMesh.Controls.Add(this.btnInstallProductSidecar, 1, 0);
            this.tlpMesh.Controls.Add(this.btnUninstallMesh, 0, 1);
            this.tlpMesh.Controls.Add(this.button3, 1, 1);
            this.tlpMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMesh.Location = new System.Drawing.Point(3, 16);
            this.tlpMesh.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMesh.Name = "tlpMesh";
            this.tlpMesh.RowCount = 2;
            this.tlpMesh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesh.Size = new System.Drawing.Size(952, 75);
            this.tlpMesh.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(763, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 32);
            this.button6.TabIndex = 9;
            this.button6.Text = "Uninstall Address Sidecar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(573, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Uninstall Payment Sidecar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(383, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Uninstall Order Sidecar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnInstallAddressSidecar
            // 
            this.btnInstallAddressSidecar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallAddressSidecar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallAddressSidecar.Location = new System.Drawing.Point(763, 3);
            this.btnInstallAddressSidecar.Name = "btnInstallAddressSidecar";
            this.btnInstallAddressSidecar.Size = new System.Drawing.Size(186, 31);
            this.btnInstallAddressSidecar.TabIndex = 4;
            this.btnInstallAddressSidecar.Tag = "address";
            this.btnInstallAddressSidecar.Text = "Install Address Sidecar";
            this.btnInstallAddressSidecar.UseVisualStyleBackColor = true;
            this.btnInstallAddressSidecar.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnInstallPaymentSidecar
            // 
            this.btnInstallPaymentSidecar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallPaymentSidecar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallPaymentSidecar.Location = new System.Drawing.Point(573, 3);
            this.btnInstallPaymentSidecar.Name = "btnInstallPaymentSidecar";
            this.btnInstallPaymentSidecar.Size = new System.Drawing.Size(184, 31);
            this.btnInstallPaymentSidecar.TabIndex = 3;
            this.btnInstallPaymentSidecar.Tag = "payment";
            this.btnInstallPaymentSidecar.Text = "Install Payment Sidecar";
            this.btnInstallPaymentSidecar.UseVisualStyleBackColor = true;
            this.btnInstallPaymentSidecar.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnInstallOrderSidecar
            // 
            this.btnInstallOrderSidecar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallOrderSidecar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallOrderSidecar.Location = new System.Drawing.Point(383, 3);
            this.btnInstallOrderSidecar.Name = "btnInstallOrderSidecar";
            this.btnInstallOrderSidecar.Size = new System.Drawing.Size(184, 31);
            this.btnInstallOrderSidecar.TabIndex = 2;
            this.btnInstallOrderSidecar.Tag = "order";
            this.btnInstallOrderSidecar.Text = "Install Order Sidecar";
            this.btnInstallOrderSidecar.UseVisualStyleBackColor = true;
            this.btnInstallOrderSidecar.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnDeployMesh
            // 
            this.btnDeployMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployMesh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployMesh.Location = new System.Drawing.Point(3, 3);
            this.btnDeployMesh.Name = "btnDeployMesh";
            this.btnDeployMesh.Size = new System.Drawing.Size(184, 31);
            this.btnDeployMesh.TabIndex = 0;
            this.btnDeployMesh.Text = "Install Istio";
            this.btnDeployMesh.UseVisualStyleBackColor = true;
            this.btnDeployMesh.Click += new System.EventHandler(this.OnDeployMesh);
            // 
            // btnInstallProductSidecar
            // 
            this.btnInstallProductSidecar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallProductSidecar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallProductSidecar.Location = new System.Drawing.Point(193, 3);
            this.btnInstallProductSidecar.Name = "btnInstallProductSidecar";
            this.btnInstallProductSidecar.Size = new System.Drawing.Size(184, 31);
            this.btnInstallProductSidecar.TabIndex = 1;
            this.btnInstallProductSidecar.Tag = "product";
            this.btnInstallProductSidecar.Text = "Install Product Sidecar";
            this.btnInstallProductSidecar.UseVisualStyleBackColor = true;
            this.btnInstallProductSidecar.Click += new System.EventHandler(this.OnDeploySidecar);
            // 
            // btnUninstallMesh
            // 
            this.btnUninstallMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallMesh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstallMesh.Location = new System.Drawing.Point(3, 40);
            this.btnUninstallMesh.Name = "btnUninstallMesh";
            this.btnUninstallMesh.Size = new System.Drawing.Size(184, 32);
            this.btnUninstallMesh.TabIndex = 5;
            this.btnUninstallMesh.Text = "Uninstall Istio";
            this.btnUninstallMesh.UseVisualStyleBackColor = true;
            this.btnUninstallMesh.Click += new System.EventHandler(this.OnRollbackMesh);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(193, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Uninstall Product Sidecar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gbIstioPath
            // 
            this.gbIstioPath.Controls.Add(this.txtIstioPath);
            this.gbIstioPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIstioPath.Location = new System.Drawing.Point(3, 238);
            this.gbIstioPath.Name = "gbIstioPath";
            this.gbIstioPath.Size = new System.Drawing.Size(958, 44);
            this.gbIstioPath.TabIndex = 7;
            this.gbIstioPath.TabStop = false;
            this.gbIstioPath.Text = "Istio Path";
            // 
            // txtIstioPath
            // 
            this.txtIstioPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIstioPath.Location = new System.Drawing.Point(3, 16);
            this.txtIstioPath.Name = "txtIstioPath";
            this.txtIstioPath.Size = new System.Drawing.Size(952, 20);
            this.txtIstioPath.TabIndex = 0;
            this.txtIstioPath.Text = "C:\\istio\\istio-1.0.1-win\\istio-1.0.1";
            // 
            // gbKubeObjects
            // 
            this.gbKubeObjects.Controls.Add(this.tlpKubeObject);
            this.gbKubeObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKubeObjects.Location = new System.Drawing.Point(3, 53);
            this.gbKubeObjects.Name = "gbKubeObjects";
            this.gbKubeObjects.Size = new System.Drawing.Size(958, 94);
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
            this.tlpKubeObject.Controls.Add(this.btnDeployAllApi, 2, 0);
            this.tlpKubeObject.Controls.Add(this.btnRollbackAllApi, 2, 1);
            this.tlpKubeObject.Controls.Add(this.btnInstallSIdecars, 3, 0);
            this.tlpKubeObject.Controls.Add(this.btnUninstallSidecars, 3, 1);
            this.tlpKubeObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKubeObject.Location = new System.Drawing.Point(3, 16);
            this.tlpKubeObject.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKubeObject.Name = "tlpKubeObject";
            this.tlpKubeObject.RowCount = 2;
            this.tlpKubeObject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKubeObject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKubeObject.Size = new System.Drawing.Size(952, 75);
            this.tlpKubeObject.TabIndex = 0;
            // 
            // btnInstallIngress
            // 
            this.btnInstallIngress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallIngress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallIngress.Location = new System.Drawing.Point(193, 3);
            this.btnInstallIngress.Name = "btnInstallIngress";
            this.btnInstallIngress.Size = new System.Drawing.Size(184, 31);
            this.btnInstallIngress.TabIndex = 1;
            this.btnInstallIngress.Text = "Install Ingress";
            this.btnInstallIngress.UseVisualStyleBackColor = true;
            this.btnInstallIngress.Click += new System.EventHandler(this.OnDeployIngress);
            // 
            // btnUninstallIngress
            // 
            this.btnUninstallIngress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallIngress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstallIngress.Location = new System.Drawing.Point(193, 40);
            this.btnUninstallIngress.Name = "btnUninstallIngress";
            this.btnUninstallIngress.Size = new System.Drawing.Size(184, 32);
            this.btnUninstallIngress.TabIndex = 2;
            this.btnUninstallIngress.Text = "Uninstall Ingress";
            this.btnUninstallIngress.UseVisualStyleBackColor = true;
            this.btnUninstallIngress.Click += new System.EventHandler(this.OnRollbackIngress);
            // 
            // btnInstallIngressController
            // 
            this.btnInstallIngressController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallIngressController.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallIngressController.Location = new System.Drawing.Point(3, 3);
            this.btnInstallIngressController.Name = "btnInstallIngressController";
            this.btnInstallIngressController.Size = new System.Drawing.Size(184, 31);
            this.btnInstallIngressController.TabIndex = 3;
            this.btnInstallIngressController.Text = "Install Ingress Controller";
            this.btnInstallIngressController.UseVisualStyleBackColor = true;
            // 
            // btnUninstallIngressController
            // 
            this.btnUninstallIngressController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallIngressController.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstallIngressController.Location = new System.Drawing.Point(3, 40);
            this.btnUninstallIngressController.Name = "btnUninstallIngressController";
            this.btnUninstallIngressController.Size = new System.Drawing.Size(184, 32);
            this.btnUninstallIngressController.TabIndex = 4;
            this.btnUninstallIngressController.Text = "Uninstall Ingress Controller";
            this.btnUninstallIngressController.UseVisualStyleBackColor = true;
            // 
            // btnDeployAllApi
            // 
            this.btnDeployAllApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeployAllApi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployAllApi.Location = new System.Drawing.Point(383, 3);
            this.btnDeployAllApi.Name = "btnDeployAllApi";
            this.btnDeployAllApi.Size = new System.Drawing.Size(184, 31);
            this.btnDeployAllApi.TabIndex = 5;
            this.btnDeployAllApi.Text = "Deploy Api";
            this.btnDeployAllApi.UseVisualStyleBackColor = true;
            this.btnDeployAllApi.Click += new System.EventHandler(this.OnDeployAllApi);
            // 
            // btnRollbackAllApi
            // 
            this.btnRollbackAllApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRollbackAllApi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollbackAllApi.Location = new System.Drawing.Point(383, 40);
            this.btnRollbackAllApi.Name = "btnRollbackAllApi";
            this.btnRollbackAllApi.Size = new System.Drawing.Size(184, 32);
            this.btnRollbackAllApi.TabIndex = 6;
            this.btnRollbackAllApi.Text = "Rollback Api";
            this.btnRollbackAllApi.UseVisualStyleBackColor = true;
            this.btnRollbackAllApi.Click += new System.EventHandler(this.OnRollbackAllApi);
            // 
            // btnInstallSIdecars
            // 
            this.btnInstallSIdecars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallSIdecars.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallSIdecars.Location = new System.Drawing.Point(573, 3);
            this.btnInstallSIdecars.Name = "btnInstallSIdecars";
            this.btnInstallSIdecars.Size = new System.Drawing.Size(184, 31);
            this.btnInstallSIdecars.TabIndex = 7;
            this.btnInstallSIdecars.Text = "Install Sidecars";
            this.btnInstallSIdecars.UseVisualStyleBackColor = true;
            this.btnInstallSIdecars.Click += new System.EventHandler(this.OnInstallSidecars);
            // 
            // btnUninstallSidecars
            // 
            this.btnUninstallSidecars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallSidecars.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstallSidecars.Location = new System.Drawing.Point(573, 40);
            this.btnUninstallSidecars.Name = "btnUninstallSidecars";
            this.btnUninstallSidecars.Size = new System.Drawing.Size(184, 32);
            this.btnUninstallSidecars.TabIndex = 8;
            this.btnUninstallSidecars.Text = "Uninstall Sidecars";
            this.btnUninstallSidecars.UseVisualStyleBackColor = true;
            this.btnUninstallSidecars.Click += new System.EventHandler(this.OnUninstallSidecars);
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrlMain.Controls.Add(this.tabDashboard);
            this.tabCtrlMain.Controls.Add(this.tabTerminal);
            this.tabCtrlMain.Controls.Add(this.tabComponents);
            this.tabCtrlMain.Controls.Add(this.tabTransaction);
            this.tabCtrlMain.Controls.Add(this.tabFeatures);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(3, 3);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(978, 630);
            this.tabCtrlMain.TabIndex = 3;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.tlpDashboard);
            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(970, 604);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabTerminal
            // 
            this.tabTerminal.Controls.Add(this.gbTerminal);
            this.tabTerminal.Location = new System.Drawing.Point(4, 4);
            this.tabTerminal.Name = "tabTerminal";
            this.tabTerminal.Size = new System.Drawing.Size(970, 604);
            this.tabTerminal.TabIndex = 1;
            this.tabTerminal.Text = "Terminal";
            this.tabTerminal.UseVisualStyleBackColor = true;
            // 
            // gbTerminal
            // 
            this.gbTerminal.Controls.Add(this.tlpTerminal);
            this.gbTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTerminal.Location = new System.Drawing.Point(0, 0);
            this.gbTerminal.Name = "gbTerminal";
            this.gbTerminal.Size = new System.Drawing.Size(970, 604);
            this.gbTerminal.TabIndex = 3;
            this.gbTerminal.TabStop = false;
            this.gbTerminal.Text = "Terminal";
            // 
            // tlpTerminal
            // 
            this.tlpTerminal.ColumnCount = 1;
            this.tlpTerminal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTerminal.Controls.Add(this.txtTerminal, 0, 1);
            this.tlpTerminal.Controls.Add(this.tsTerminal, 0, 0);
            this.tlpTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTerminal.Location = new System.Drawing.Point(3, 16);
            this.tlpTerminal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTerminal.Name = "tlpTerminal";
            this.tlpTerminal.RowCount = 2;
            this.tlpTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTerminal.Size = new System.Drawing.Size(964, 585);
            this.tlpTerminal.TabIndex = 2;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminal.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.Location = new System.Drawing.Point(3, 28);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(958, 554);
            this.txtTerminal.TabIndex = 1;
            this.txtTerminal.Text = "";
            // 
            // tsTerminal
            // 
            this.tsTerminal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTerminal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearTerminal});
            this.tsTerminal.Location = new System.Drawing.Point(0, 0);
            this.tsTerminal.Name = "tsTerminal";
            this.tsTerminal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTerminal.Size = new System.Drawing.Size(964, 25);
            this.tsTerminal.TabIndex = 2;
            // 
            // btnClearTerminal
            // 
            this.btnClearTerminal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClearTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTerminal.Image")));
            this.btnClearTerminal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearTerminal.Name = "btnClearTerminal";
            this.btnClearTerminal.Size = new System.Drawing.Size(54, 22);
            this.btnClearTerminal.Text = "Clear";
            this.btnClearTerminal.Click += new System.EventHandler(this.OnClearTerminal);
            // 
            // tabComponents
            // 
            this.tabComponents.Controls.Add(this.gbObjects);
            this.tabComponents.Location = new System.Drawing.Point(4, 4);
            this.tabComponents.Name = "tabComponents";
            this.tabComponents.Size = new System.Drawing.Size(970, 604);
            this.tabComponents.TabIndex = 2;
            this.tabComponents.Text = "Components";
            this.tabComponents.UseVisualStyleBackColor = true;
            // 
            // gbObjects
            // 
            this.gbObjects.Controls.Add(this.tlpComponents);
            this.gbObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbObjects.Location = new System.Drawing.Point(0, 0);
            this.gbObjects.Name = "gbObjects";
            this.gbObjects.Size = new System.Drawing.Size(970, 604);
            this.gbObjects.TabIndex = 7;
            this.gbObjects.TabStop = false;
            this.gbObjects.Text = "Kubernetes Components";
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
            this.tlpComponents.Size = new System.Drawing.Size(964, 585);
            this.tlpComponents.TabIndex = 0;
            // 
            // lstObjects
            // 
            this.lstObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNamespace,
            this.colType,
            this.colName,
            this.colAddress});
            this.lstObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstObjects.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstObjects.FullRowSelect = true;
            this.lstObjects.GridLines = true;
            this.lstObjects.Location = new System.Drawing.Point(3, 28);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(958, 554);
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
            this.ToolBar.Size = new System.Drawing.Size(964, 25);
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
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.tlpTransaction);
            this.tabTransaction.Location = new System.Drawing.Point(4, 4);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Size = new System.Drawing.Size(970, 604);
            this.tabTransaction.TabIndex = 3;
            this.tabTransaction.Text = "Transaction";
            this.tabTransaction.UseVisualStyleBackColor = true;
            // 
            // tlpTransaction
            // 
            this.tlpTransaction.ColumnCount = 1;
            this.tlpTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransaction.Controls.Add(this.txtResponse, 0, 2);
            this.tlpTransaction.Controls.Add(this.gbOrder, 0, 1);
            this.tlpTransaction.Controls.Add(this.gbProduct, 0, 0);
            this.tlpTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransaction.Location = new System.Drawing.Point(0, 0);
            this.tlpTransaction.Name = "tlpTransaction";
            this.tlpTransaction.RowCount = 3;
            this.tlpTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTransaction.Size = new System.Drawing.Size(970, 604);
            this.tlpTransaction.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(3, 123);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(964, 478);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.Text = "";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.tlpOrder);
            this.gbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrder.Location = new System.Drawing.Point(3, 63);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(964, 54);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // tlpOrder
            // 
            this.tlpOrder.ColumnCount = 5;
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpOrder.Controls.Add(this.btnSubmitOrder, 3, 0);
            this.tlpOrder.Controls.Add(this.cbProducts, 0, 0);
            this.tlpOrder.Controls.Add(this.cbPayment, 1, 0);
            this.tlpOrder.Controls.Add(this.cbArea, 2, 0);
            this.tlpOrder.Controls.Add(this.button2, 4, 0);
            this.tlpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrder.Location = new System.Drawing.Point(3, 16);
            this.tlpOrder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOrder.Name = "tlpOrder";
            this.tlpOrder.RowCount = 1;
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrder.Size = new System.Drawing.Size(958, 35);
            this.tlpOrder.TabIndex = 4;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(759, 3);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(94, 29);
            this.btnSubmitOrder.TabIndex = 1;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.OnOrderSubmitted);
            // 
            // cbProducts
            // 
            this.cbProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(3, 3);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(372, 27);
            this.cbProducts.TabIndex = 0;
            // 
            // cbPayment
            // 
            this.cbPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Items.AddRange(new object[] {
            "MasterCard",
            "Maestro",
            "Visa",
            "AmericanExpress",
            "DinersClub",
            "Discover",
            "Rupay"});
            this.cbPayment.Location = new System.Drawing.Point(381, 3);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(183, 27);
            this.cbPayment.TabIndex = 2;
            // 
            // cbArea
            // 
            this.cbArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Central and Northern Sydney",
            "Western Sydney and Blue Mountains",
            "Greystanes - 2145 (Western Sydney)"});
            this.cbArea.Location = new System.Drawing.Point(570, 3);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(183, 27);
            this.cbArea.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(859, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Health";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnOrderHealth);
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.tlpProduct);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProduct.Location = new System.Drawing.Point(3, 3);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(964, 54);
            this.gbProduct.TabIndex = 2;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product";
            // 
            // tlpProduct
            // 
            this.tlpProduct.ColumnCount = 3;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpProduct.Controls.Add(this.txtSearch, 0, 0);
            this.tlpProduct.Controls.Add(this.btnProductSearch, 1, 0);
            this.tlpProduct.Controls.Add(this.button1, 2, 0);
            this.tlpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProduct.Location = new System.Drawing.Point(3, 16);
            this.tlpProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.RowCount = 1;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.Size = new System.Drawing.Size(958, 35);
            this.tlpProduct.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(752, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSearch.Location = new System.Drawing.Point(761, 3);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(94, 29);
            this.btnProductSearch.TabIndex = 1;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.OnProductSearch);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(861, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Health";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnProductHealth);
            // 
            // tabFeatures
            // 
            this.tabFeatures.Controls.Add(this.tlpFeatures);
            this.tabFeatures.Location = new System.Drawing.Point(4, 4);
            this.tabFeatures.Margin = new System.Windows.Forms.Padding(0);
            this.tabFeatures.Name = "tabFeatures";
            this.tabFeatures.Size = new System.Drawing.Size(970, 604);
            this.tabFeatures.TabIndex = 4;
            this.tabFeatures.Text = "Features";
            this.tabFeatures.UseVisualStyleBackColor = true;
            // 
            // tlpFeatures
            // 
            this.tlpFeatures.ColumnCount = 1;
            this.tlpFeatures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFeatures.Controls.Add(this.gbBlueGreenDeployment, 0, 0);
            this.tlpFeatures.Controls.Add(this.gbPaymentCanaryRelease, 0, 1);
            this.tlpFeatures.Controls.Add(this.gbAddressCanaryRelease, 0, 2);
            this.tlpFeatures.Controls.Add(this.gbTest, 0, 3);
            this.tlpFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFeatures.Location = new System.Drawing.Point(0, 0);
            this.tlpFeatures.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFeatures.Name = "tlpFeatures";
            this.tlpFeatures.RowCount = 4;
            this.tlpFeatures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpFeatures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpFeatures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpFeatures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFeatures.Size = new System.Drawing.Size(970, 604);
            this.tlpFeatures.TabIndex = 0;
            // 
            // gbBlueGreenDeployment
            // 
            this.gbBlueGreenDeployment.Controls.Add(this.tlpBlueGreenDeployment);
            this.gbBlueGreenDeployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBlueGreenDeployment.Location = new System.Drawing.Point(3, 3);
            this.gbBlueGreenDeployment.Name = "gbBlueGreenDeployment";
            this.gbBlueGreenDeployment.Size = new System.Drawing.Size(964, 69);
            this.gbBlueGreenDeployment.TabIndex = 0;
            this.gbBlueGreenDeployment.TabStop = false;
            this.gbBlueGreenDeployment.Text = "Blue-Green Deployment";
            // 
            // tlpBlueGreenDeployment
            // 
            this.tlpBlueGreenDeployment.ColumnCount = 6;
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBlueGreenDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBlueGreenDeployment.Controls.Add(this.rbtnAddressVersion1, 2, 0);
            this.tlpBlueGreenDeployment.Controls.Add(this.rbtnAddressVersion2, 3, 0);
            this.tlpBlueGreenDeployment.Controls.Add(this.rbtnAddressVersion3, 4, 0);
            this.tlpBlueGreenDeployment.Controls.Add(this.pnlPaymentVersions, 1, 0);
            this.tlpBlueGreenDeployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBlueGreenDeployment.Location = new System.Drawing.Point(3, 16);
            this.tlpBlueGreenDeployment.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBlueGreenDeployment.Name = "tlpBlueGreenDeployment";
            this.tlpBlueGreenDeployment.RowCount = 1;
            this.tlpBlueGreenDeployment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBlueGreenDeployment.Size = new System.Drawing.Size(958, 50);
            this.tlpBlueGreenDeployment.TabIndex = 2;
            // 
            // rbtnAddressVersion1
            // 
            this.rbtnAddressVersion1.AutoSize = true;
            this.rbtnAddressVersion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnAddressVersion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAddressVersion1.Location = new System.Drawing.Point(419, 3);
            this.rbtnAddressVersion1.Name = "rbtnAddressVersion1";
            this.rbtnAddressVersion1.Size = new System.Drawing.Size(119, 44);
            this.rbtnAddressVersion1.TabIndex = 2;
            this.rbtnAddressVersion1.TabStop = true;
            this.rbtnAddressVersion1.Tag = "address-1";
            this.rbtnAddressVersion1.Text = "Address v1.0";
            this.rbtnAddressVersion1.UseVisualStyleBackColor = true;
            this.rbtnAddressVersion1.CheckedChanged += new System.EventHandler(this.OnBlueGreenDeployment);
            // 
            // rbtnAddressVersion2
            // 
            this.rbtnAddressVersion2.AutoSize = true;
            this.rbtnAddressVersion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnAddressVersion2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAddressVersion2.Location = new System.Drawing.Point(544, 3);
            this.rbtnAddressVersion2.Name = "rbtnAddressVersion2";
            this.rbtnAddressVersion2.Size = new System.Drawing.Size(119, 44);
            this.rbtnAddressVersion2.TabIndex = 3;
            this.rbtnAddressVersion2.TabStop = true;
            this.rbtnAddressVersion2.Tag = "address-2";
            this.rbtnAddressVersion2.Text = "Address v2.0";
            this.rbtnAddressVersion2.UseVisualStyleBackColor = true;
            this.rbtnAddressVersion2.CheckedChanged += new System.EventHandler(this.OnBlueGreenDeployment);
            // 
            // rbtnAddressVersion3
            // 
            this.rbtnAddressVersion3.AutoSize = true;
            this.rbtnAddressVersion3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnAddressVersion3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAddressVersion3.Location = new System.Drawing.Point(669, 3);
            this.rbtnAddressVersion3.Name = "rbtnAddressVersion3";
            this.rbtnAddressVersion3.Size = new System.Drawing.Size(119, 44);
            this.rbtnAddressVersion3.TabIndex = 4;
            this.rbtnAddressVersion3.TabStop = true;
            this.rbtnAddressVersion3.Tag = "address-3";
            this.rbtnAddressVersion3.Text = "Address v3.0";
            this.rbtnAddressVersion3.UseVisualStyleBackColor = true;
            this.rbtnAddressVersion3.CheckedChanged += new System.EventHandler(this.OnBlueGreenDeployment);
            // 
            // pnlPaymentVersions
            // 
            this.pnlPaymentVersions.Controls.Add(this.tlpPaymentVersions);
            this.pnlPaymentVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentVersions.Location = new System.Drawing.Point(166, 0);
            this.pnlPaymentVersions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPaymentVersions.Name = "pnlPaymentVersions";
            this.pnlPaymentVersions.Size = new System.Drawing.Size(250, 50);
            this.pnlPaymentVersions.TabIndex = 5;
            // 
            // tlpPaymentVersions
            // 
            this.tlpPaymentVersions.ColumnCount = 2;
            this.tlpPaymentVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentVersions.Controls.Add(this.rbtnPaymentVersion2, 1, 0);
            this.tlpPaymentVersions.Controls.Add(this.rbtnPaymentVersion1, 0, 0);
            this.tlpPaymentVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentVersions.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentVersions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPaymentVersions.Name = "tlpPaymentVersions";
            this.tlpPaymentVersions.RowCount = 1;
            this.tlpPaymentVersions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentVersions.Size = new System.Drawing.Size(250, 50);
            this.tlpPaymentVersions.TabIndex = 0;
            // 
            // rbtnPaymentVersion2
            // 
            this.rbtnPaymentVersion2.AutoSize = true;
            this.rbtnPaymentVersion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnPaymentVersion2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaymentVersion2.Location = new System.Drawing.Point(128, 3);
            this.rbtnPaymentVersion2.Name = "rbtnPaymentVersion2";
            this.rbtnPaymentVersion2.Size = new System.Drawing.Size(119, 44);
            this.rbtnPaymentVersion2.TabIndex = 1;
            this.rbtnPaymentVersion2.TabStop = true;
            this.rbtnPaymentVersion2.Tag = "payment-2";
            this.rbtnPaymentVersion2.Text = "Payment v2.0";
            this.rbtnPaymentVersion2.UseVisualStyleBackColor = true;
            this.rbtnPaymentVersion2.CheckedChanged += new System.EventHandler(this.OnBlueGreenDeployment);
            // 
            // rbtnPaymentVersion1
            // 
            this.rbtnPaymentVersion1.AutoSize = true;
            this.rbtnPaymentVersion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnPaymentVersion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaymentVersion1.Location = new System.Drawing.Point(3, 3);
            this.rbtnPaymentVersion1.Name = "rbtnPaymentVersion1";
            this.rbtnPaymentVersion1.Size = new System.Drawing.Size(119, 44);
            this.rbtnPaymentVersion1.TabIndex = 0;
            this.rbtnPaymentVersion1.TabStop = true;
            this.rbtnPaymentVersion1.Tag = "payment-1";
            this.rbtnPaymentVersion1.Text = "Payment v1.0";
            this.rbtnPaymentVersion1.UseVisualStyleBackColor = true;
            this.rbtnPaymentVersion1.CheckedChanged += new System.EventHandler(this.OnBlueGreenDeployment);
            // 
            // gbPaymentCanaryRelease
            // 
            this.gbPaymentCanaryRelease.Controls.Add(this.tbPaymentCanaryRelease);
            this.gbPaymentCanaryRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentCanaryRelease.Location = new System.Drawing.Point(3, 78);
            this.gbPaymentCanaryRelease.Name = "gbPaymentCanaryRelease";
            this.gbPaymentCanaryRelease.Size = new System.Drawing.Size(964, 69);
            this.gbPaymentCanaryRelease.TabIndex = 1;
            this.gbPaymentCanaryRelease.TabStop = false;
            this.gbPaymentCanaryRelease.Text = "Canary Release: Payment";
            // 
            // tbPaymentCanaryRelease
            // 
            this.tbPaymentCanaryRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPaymentCanaryRelease.LargeChange = 10;
            this.tbPaymentCanaryRelease.Location = new System.Drawing.Point(3, 16);
            this.tbPaymentCanaryRelease.Maximum = 100;
            this.tbPaymentCanaryRelease.Name = "tbPaymentCanaryRelease";
            this.tbPaymentCanaryRelease.Size = new System.Drawing.Size(958, 50);
            this.tbPaymentCanaryRelease.SmallChange = 10;
            this.tbPaymentCanaryRelease.TabIndex = 0;
            this.tbPaymentCanaryRelease.TickFrequency = 10;
            this.tbPaymentCanaryRelease.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPaymentCanaryRelease.ValueChanged += new System.EventHandler(this.OnCanaryRelease);
            // 
            // gbAddressCanaryRelease
            // 
            this.gbAddressCanaryRelease.Controls.Add(this.tbAddressCanaryRelease);
            this.gbAddressCanaryRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressCanaryRelease.Location = new System.Drawing.Point(3, 153);
            this.gbAddressCanaryRelease.Name = "gbAddressCanaryRelease";
            this.gbAddressCanaryRelease.Size = new System.Drawing.Size(964, 69);
            this.gbAddressCanaryRelease.TabIndex = 2;
            this.gbAddressCanaryRelease.TabStop = false;
            this.gbAddressCanaryRelease.Text = "Canary Release: Address";
            // 
            // tbAddressCanaryRelease
            // 
            this.tbAddressCanaryRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddressCanaryRelease.LargeChange = 10;
            this.tbAddressCanaryRelease.Location = new System.Drawing.Point(3, 16);
            this.tbAddressCanaryRelease.Maximum = 100;
            this.tbAddressCanaryRelease.Name = "tbAddressCanaryRelease";
            this.tbAddressCanaryRelease.Size = new System.Drawing.Size(958, 50);
            this.tbAddressCanaryRelease.SmallChange = 10;
            this.tbAddressCanaryRelease.TabIndex = 0;
            this.tbAddressCanaryRelease.TickFrequency = 10;
            this.tbAddressCanaryRelease.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.tlpFeaturesTest);
            this.gbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTest.Location = new System.Drawing.Point(3, 228);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(964, 373);
            this.gbTest.TabIndex = 3;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Test";
            // 
            // tlpFeaturesTest
            // 
            this.tlpFeaturesTest.ColumnCount = 1;
            this.tlpFeaturesTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFeaturesTest.Controls.Add(this.tlpOrderFeatureTest, 0, 0);
            this.tlpFeaturesTest.Controls.Add(this.tlpTestPodMetrics, 0, 2);
            this.tlpFeaturesTest.Controls.Add(this.tlpRequestMetrics, 0, 1);
            this.tlpFeaturesTest.Controls.Add(this.pbTestProgress, 0, 4);
            this.tlpFeaturesTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFeaturesTest.Location = new System.Drawing.Point(3, 16);
            this.tlpFeaturesTest.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFeaturesTest.Name = "tlpFeaturesTest";
            this.tlpFeaturesTest.RowCount = 5;
            this.tlpFeaturesTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFeaturesTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpFeaturesTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpFeaturesTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFeaturesTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFeaturesTest.Size = new System.Drawing.Size(958, 354);
            this.tlpFeaturesTest.TabIndex = 0;
            // 
            // tlpOrderFeatureTest
            // 
            this.tlpOrderFeatureTest.ColumnCount = 4;
            this.tlpOrderFeatureTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrderFeatureTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrderFeatureTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpOrderFeatureTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpOrderFeatureTest.Controls.Add(this.cbAddressTest, 1, 0);
            this.tlpOrderFeatureTest.Controls.Add(this.cbPaymentTest, 0, 0);
            this.tlpOrderFeatureTest.Controls.Add(this.btnSubmitOrderTest, 3, 0);
            this.tlpOrderFeatureTest.Controls.Add(this.nOrders, 2, 0);
            this.tlpOrderFeatureTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrderFeatureTest.Location = new System.Drawing.Point(0, 0);
            this.tlpOrderFeatureTest.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOrderFeatureTest.Name = "tlpOrderFeatureTest";
            this.tlpOrderFeatureTest.RowCount = 1;
            this.tlpOrderFeatureTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrderFeatureTest.Size = new System.Drawing.Size(958, 35);
            this.tlpOrderFeatureTest.TabIndex = 0;
            // 
            // cbAddressTest
            // 
            this.cbAddressTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAddressTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddressTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddressTest.FormattingEnabled = true;
            this.cbAddressTest.Items.AddRange(new object[] {
            "Central and Northern Sydney",
            "Western Sydney and Blue Mountains",
            "Greystanes - 2145 (Western Sydney)"});
            this.cbAddressTest.Location = new System.Drawing.Point(332, 3);
            this.cbAddressTest.Name = "cbAddressTest";
            this.cbAddressTest.Size = new System.Drawing.Size(323, 27);
            this.cbAddressTest.TabIndex = 1;
            // 
            // cbPaymentTest
            // 
            this.cbPaymentTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPaymentTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentTest.FormattingEnabled = true;
            this.cbPaymentTest.Items.AddRange(new object[] {
            "MasterCard",
            "Maestro",
            "Visa",
            "AmericanExpress",
            "DinersClub",
            "Discover",
            "Rupay"});
            this.cbPaymentTest.Location = new System.Drawing.Point(3, 3);
            this.cbPaymentTest.Name = "cbPaymentTest";
            this.cbPaymentTest.Size = new System.Drawing.Size(323, 27);
            this.cbPaymentTest.TabIndex = 0;
            // 
            // btnSubmitOrderTest
            // 
            this.btnSubmitOrderTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmitOrderTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrderTest.Location = new System.Drawing.Point(761, 3);
            this.btnSubmitOrderTest.Name = "btnSubmitOrderTest";
            this.btnSubmitOrderTest.Size = new System.Drawing.Size(194, 29);
            this.btnSubmitOrderTest.TabIndex = 2;
            this.btnSubmitOrderTest.Text = "Submit Orders";
            this.btnSubmitOrderTest.UseVisualStyleBackColor = true;
            this.btnSubmitOrderTest.Click += new System.EventHandler(this.OnSubmitTestOrders);
            // 
            // nOrders
            // 
            this.nOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nOrders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOrders.Location = new System.Drawing.Point(661, 3);
            this.nOrders.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nOrders.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nOrders.Name = "nOrders";
            this.nOrders.Size = new System.Drawing.Size(94, 27);
            this.nOrders.TabIndex = 3;
            this.nOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nOrders.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tlpTestPodMetrics
            // 
            this.tlpTestPodMetrics.ColumnCount = 5;
            this.tlpTestPodMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTestPodMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTestPodMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTestPodMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTestPodMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTestPodMetrics.Controls.Add(this.gbAddressPod3, 4, 0);
            this.tlpTestPodMetrics.Controls.Add(this.gbAddressPod2, 3, 0);
            this.tlpTestPodMetrics.Controls.Add(this.gbAddressPod1, 2, 0);
            this.tlpTestPodMetrics.Controls.Add(this.gbPaymentPod2, 1, 0);
            this.tlpTestPodMetrics.Controls.Add(this.gbPaymentPod1, 0, 0);
            this.tlpTestPodMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTestPodMetrics.Location = new System.Drawing.Point(0, 90);
            this.tlpTestPodMetrics.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTestPodMetrics.Name = "tlpTestPodMetrics";
            this.tlpTestPodMetrics.RowCount = 1;
            this.tlpTestPodMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTestPodMetrics.Size = new System.Drawing.Size(958, 55);
            this.tlpTestPodMetrics.TabIndex = 1;
            // 
            // gbAddressPod3
            // 
            this.gbAddressPod3.Controls.Add(this.txtAddress3);
            this.gbAddressPod3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressPod3.Location = new System.Drawing.Point(767, 3);
            this.gbAddressPod3.Name = "gbAddressPod3";
            this.gbAddressPod3.Size = new System.Drawing.Size(188, 49);
            this.gbAddressPod3.TabIndex = 2;
            this.gbAddressPod3.TabStop = false;
            this.gbAddressPod3.Text = "Address v3.0";
            // 
            // txtAddress3
            // 
            this.txtAddress3.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress3.Location = new System.Drawing.Point(3, 16);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.ReadOnly = true;
            this.txtAddress3.Size = new System.Drawing.Size(182, 27);
            this.txtAddress3.TabIndex = 4;
            this.txtAddress3.Text = "0";
            this.txtAddress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAddressPod2
            // 
            this.gbAddressPod2.Controls.Add(this.txtAddress2);
            this.gbAddressPod2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressPod2.Location = new System.Drawing.Point(576, 3);
            this.gbAddressPod2.Name = "gbAddressPod2";
            this.gbAddressPod2.Size = new System.Drawing.Size(185, 49);
            this.gbAddressPod2.TabIndex = 2;
            this.gbAddressPod2.TabStop = false;
            this.gbAddressPod2.Text = "Address v2.0";
            // 
            // txtAddress2
            // 
            this.txtAddress2.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(3, 16);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(179, 27);
            this.txtAddress2.TabIndex = 3;
            this.txtAddress2.Text = "0";
            this.txtAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAddressPod1
            // 
            this.gbAddressPod1.Controls.Add(this.txtAddress1);
            this.gbAddressPod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressPod1.Location = new System.Drawing.Point(385, 3);
            this.gbAddressPod1.Name = "gbAddressPod1";
            this.gbAddressPod1.Size = new System.Drawing.Size(185, 49);
            this.gbAddressPod1.TabIndex = 1;
            this.gbAddressPod1.TabStop = false;
            this.gbAddressPod1.Text = "Address v1.0";
            // 
            // txtAddress1
            // 
            this.txtAddress1.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(3, 16);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(179, 27);
            this.txtAddress1.TabIndex = 2;
            this.txtAddress1.Text = "0";
            this.txtAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPaymentPod2
            // 
            this.gbPaymentPod2.Controls.Add(this.txtPayment2);
            this.gbPaymentPod2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentPod2.Location = new System.Drawing.Point(194, 3);
            this.gbPaymentPod2.Name = "gbPaymentPod2";
            this.gbPaymentPod2.Size = new System.Drawing.Size(185, 49);
            this.gbPaymentPod2.TabIndex = 1;
            this.gbPaymentPod2.TabStop = false;
            this.gbPaymentPod2.Text = "Payment v2.0";
            // 
            // txtPayment2
            // 
            this.txtPayment2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayment2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPayment2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment2.Location = new System.Drawing.Point(3, 16);
            this.txtPayment2.Name = "txtPayment2";
            this.txtPayment2.ReadOnly = true;
            this.txtPayment2.Size = new System.Drawing.Size(179, 27);
            this.txtPayment2.TabIndex = 1;
            this.txtPayment2.Text = "0";
            this.txtPayment2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPaymentPod1
            // 
            this.gbPaymentPod1.Controls.Add(this.txtPayment1);
            this.gbPaymentPod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentPod1.Location = new System.Drawing.Point(3, 3);
            this.gbPaymentPod1.Name = "gbPaymentPod1";
            this.gbPaymentPod1.Size = new System.Drawing.Size(185, 49);
            this.gbPaymentPod1.TabIndex = 0;
            this.gbPaymentPod1.TabStop = false;
            this.gbPaymentPod1.Text = "Payment v1.0";
            // 
            // txtPayment1
            // 
            this.txtPayment1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPayment1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment1.Location = new System.Drawing.Point(3, 16);
            this.txtPayment1.Name = "txtPayment1";
            this.txtPayment1.ReadOnly = true;
            this.txtPayment1.Size = new System.Drawing.Size(179, 27);
            this.txtPayment1.TabIndex = 0;
            this.txtPayment1.Text = "0";
            this.txtPayment1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpRequestMetrics
            // 
            this.tlpRequestMetrics.ColumnCount = 3;
            this.tlpRequestMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRequestMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRequestMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRequestMetrics.Controls.Add(this.gbRequestFailed, 2, 0);
            this.tlpRequestMetrics.Controls.Add(this.gbRequestPassed, 1, 0);
            this.tlpRequestMetrics.Controls.Add(this.gbRequestSent, 0, 0);
            this.tlpRequestMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRequestMetrics.Location = new System.Drawing.Point(0, 35);
            this.tlpRequestMetrics.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRequestMetrics.Name = "tlpRequestMetrics";
            this.tlpRequestMetrics.RowCount = 1;
            this.tlpRequestMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRequestMetrics.Size = new System.Drawing.Size(958, 55);
            this.tlpRequestMetrics.TabIndex = 2;
            // 
            // gbRequestFailed
            // 
            this.gbRequestFailed.Controls.Add(this.txtRequestFailed);
            this.gbRequestFailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRequestFailed.Location = new System.Drawing.Point(641, 3);
            this.gbRequestFailed.Name = "gbRequestFailed";
            this.gbRequestFailed.Size = new System.Drawing.Size(314, 49);
            this.gbRequestFailed.TabIndex = 1;
            this.gbRequestFailed.TabStop = false;
            this.gbRequestFailed.Text = "Request Failed";
            // 
            // txtRequestFailed
            // 
            this.txtRequestFailed.BackColor = System.Drawing.SystemColors.Window;
            this.txtRequestFailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestFailed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestFailed.Location = new System.Drawing.Point(3, 16);
            this.txtRequestFailed.Name = "txtRequestFailed";
            this.txtRequestFailed.ReadOnly = true;
            this.txtRequestFailed.Size = new System.Drawing.Size(308, 27);
            this.txtRequestFailed.TabIndex = 2;
            this.txtRequestFailed.Text = "0";
            this.txtRequestFailed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbRequestPassed
            // 
            this.gbRequestPassed.Controls.Add(this.txtRequestPassed);
            this.gbRequestPassed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRequestPassed.Location = new System.Drawing.Point(322, 3);
            this.gbRequestPassed.Name = "gbRequestPassed";
            this.gbRequestPassed.Size = new System.Drawing.Size(313, 49);
            this.gbRequestPassed.TabIndex = 1;
            this.gbRequestPassed.TabStop = false;
            this.gbRequestPassed.Text = "Request Passed";
            // 
            // txtRequestPassed
            // 
            this.txtRequestPassed.BackColor = System.Drawing.SystemColors.Window;
            this.txtRequestPassed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestPassed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestPassed.Location = new System.Drawing.Point(3, 16);
            this.txtRequestPassed.Name = "txtRequestPassed";
            this.txtRequestPassed.ReadOnly = true;
            this.txtRequestPassed.Size = new System.Drawing.Size(307, 27);
            this.txtRequestPassed.TabIndex = 1;
            this.txtRequestPassed.Text = "0";
            this.txtRequestPassed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbRequestSent
            // 
            this.gbRequestSent.Controls.Add(this.txtRequestSent);
            this.gbRequestSent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRequestSent.Location = new System.Drawing.Point(3, 3);
            this.gbRequestSent.Name = "gbRequestSent";
            this.gbRequestSent.Size = new System.Drawing.Size(313, 49);
            this.gbRequestSent.TabIndex = 0;
            this.gbRequestSent.TabStop = false;
            this.gbRequestSent.Text = "Request Sent";
            // 
            // txtRequestSent
            // 
            this.txtRequestSent.BackColor = System.Drawing.SystemColors.Window;
            this.txtRequestSent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestSent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestSent.Location = new System.Drawing.Point(3, 16);
            this.txtRequestSent.Name = "txtRequestSent";
            this.txtRequestSent.ReadOnly = true;
            this.txtRequestSent.Size = new System.Drawing.Size(307, 27);
            this.txtRequestSent.TabIndex = 0;
            this.txtRequestSent.Text = "0";
            this.txtRequestSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbTestProgress
            // 
            this.pbTestProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTestProgress.Location = new System.Drawing.Point(3, 327);
            this.pbTestProgress.Name = "pbTestProgress";
            this.pbTestProgress.Size = new System.Drawing.Size(952, 24);
            this.pbTestProgress.Step = 1;
            this.pbTestProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTestProgress.TabIndex = 3;
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
            this.tlpMain.Size = new System.Drawing.Size(984, 661);
            this.tlpMain.TabIndex = 4;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage});
            this.StatusBar.Location = new System.Drawing.Point(0, 637);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(984, 24);
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
            this.StatusMessage.Size = new System.Drawing.Size(969, 19);
            this.StatusMessage.Spring = true;
            this.StatusMessage.Text = "Ready";
            this.StatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind: Dashboard";
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
            this.gbTerminal.ResumeLayout(false);
            this.tlpTerminal.ResumeLayout(false);
            this.tlpTerminal.PerformLayout();
            this.tsTerminal.ResumeLayout(false);
            this.tsTerminal.PerformLayout();
            this.tabComponents.ResumeLayout(false);
            this.gbObjects.ResumeLayout(false);
            this.tlpComponents.ResumeLayout(false);
            this.tlpComponents.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.tabTransaction.ResumeLayout(false);
            this.tlpTransaction.ResumeLayout(false);
            this.gbOrder.ResumeLayout(false);
            this.tlpOrder.ResumeLayout(false);
            this.gbProduct.ResumeLayout(false);
            this.tlpProduct.ResumeLayout(false);
            this.tlpProduct.PerformLayout();
            this.tabFeatures.ResumeLayout(false);
            this.tlpFeatures.ResumeLayout(false);
            this.gbBlueGreenDeployment.ResumeLayout(false);
            this.tlpBlueGreenDeployment.ResumeLayout(false);
            this.tlpBlueGreenDeployment.PerformLayout();
            this.pnlPaymentVersions.ResumeLayout(false);
            this.tlpPaymentVersions.ResumeLayout(false);
            this.tlpPaymentVersions.PerformLayout();
            this.gbPaymentCanaryRelease.ResumeLayout(false);
            this.gbPaymentCanaryRelease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPaymentCanaryRelease)).EndInit();
            this.gbAddressCanaryRelease.ResumeLayout(false);
            this.gbAddressCanaryRelease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddressCanaryRelease)).EndInit();
            this.gbTest.ResumeLayout(false);
            this.tlpFeaturesTest.ResumeLayout(false);
            this.tlpOrderFeatureTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nOrders)).EndInit();
            this.tlpTestPodMetrics.ResumeLayout(false);
            this.gbAddressPod3.ResumeLayout(false);
            this.gbAddressPod3.PerformLayout();
            this.gbAddressPod2.ResumeLayout(false);
            this.gbAddressPod2.PerformLayout();
            this.gbAddressPod1.ResumeLayout(false);
            this.gbAddressPod1.PerformLayout();
            this.gbPaymentPod2.ResumeLayout(false);
            this.gbPaymentPod2.PerformLayout();
            this.gbPaymentPod1.ResumeLayout(false);
            this.gbPaymentPod1.PerformLayout();
            this.tlpRequestMetrics.ResumeLayout(false);
            this.gbRequestFailed.ResumeLayout(false);
            this.gbRequestFailed.PerformLayout();
            this.gbRequestPassed.ResumeLayout(false);
            this.gbRequestPassed.PerformLayout();
            this.gbRequestSent.ResumeLayout(false);
            this.gbRequestSent.PerformLayout();
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
        private System.Windows.Forms.Button btnInstallAddressSidecar;
        private System.Windows.Forms.Button btnInstallPaymentSidecar;
        private System.Windows.Forms.Button btnInstallOrderSidecar;
        private System.Windows.Forms.Button btnInstallProductSidecar;
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
        private System.Windows.Forms.TabPage tabTransaction;
        private System.Windows.Forms.TableLayoutPanel tlpTransaction;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.TableLayoutPanel tlpOrder;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeployAllApi;
        private System.Windows.Forms.Button btnRollbackAllApi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInstallSIdecars;
        private System.Windows.Forms.Button btnUninstallSidecars;
        private System.Windows.Forms.GroupBox gbTerminal;
        private System.Windows.Forms.TableLayoutPanel tlpTerminal;
        private System.Windows.Forms.ToolStrip tsTerminal;
        private System.Windows.Forms.ToolStripButton btnClearTerminal;
        private System.Windows.Forms.TabPage tabFeatures;
        private System.Windows.Forms.TableLayoutPanel tlpFeatures;
        private System.Windows.Forms.GroupBox gbBlueGreenDeployment;
        private System.Windows.Forms.RadioButton rbtnPaymentVersion2;
        private System.Windows.Forms.RadioButton rbtnPaymentVersion1;
        private System.Windows.Forms.TableLayoutPanel tlpBlueGreenDeployment;
        private System.Windows.Forms.RadioButton rbtnAddressVersion1;
        private System.Windows.Forms.RadioButton rbtnAddressVersion2;
        private System.Windows.Forms.RadioButton rbtnAddressVersion3;
        private System.Windows.Forms.GroupBox gbPaymentCanaryRelease;
        private System.Windows.Forms.TrackBar tbPaymentCanaryRelease;
        private System.Windows.Forms.GroupBox gbAddressCanaryRelease;
        private System.Windows.Forms.TrackBar tbAddressCanaryRelease;
        private System.Windows.Forms.Panel pnlPaymentVersions;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentVersions;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.TableLayoutPanel tlpFeaturesTest;
        private System.Windows.Forms.TableLayoutPanel tlpOrderFeatureTest;
        private System.Windows.Forms.ComboBox cbAddressTest;
        private System.Windows.Forms.ComboBox cbPaymentTest;
        private System.Windows.Forms.Button btnSubmitOrderTest;
        private System.Windows.Forms.NumericUpDown nOrders;
        private System.Windows.Forms.TableLayoutPanel tlpTestPodMetrics;
        private System.Windows.Forms.GroupBox gbAddressPod3;
        private System.Windows.Forms.GroupBox gbAddressPod2;
        private System.Windows.Forms.GroupBox gbAddressPod1;
        private System.Windows.Forms.GroupBox gbPaymentPod2;
        private System.Windows.Forms.GroupBox gbPaymentPod1;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPayment2;
        private System.Windows.Forms.TextBox txtPayment1;
        private System.Windows.Forms.TableLayoutPanel tlpRequestMetrics;
        private System.Windows.Forms.GroupBox gbRequestFailed;
        private System.Windows.Forms.GroupBox gbRequestPassed;
        private System.Windows.Forms.GroupBox gbRequestSent;
        private System.Windows.Forms.TextBox txtRequestFailed;
        private System.Windows.Forms.TextBox txtRequestPassed;
        private System.Windows.Forms.TextBox txtRequestSent;
        private System.Windows.Forms.ProgressBar pbTestProgress;
    }
}

