using System;

namespace ShopX
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.txtCustomersHome = new System.Windows.Forms.TextBox();
            this.txtLowStock = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtOrderToday = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grBoxHome = new System.Windows.Forms.GroupBox();
            this.listBoxHome = new System.Windows.Forms.ListBox();
            this.btBackup = new System.Windows.Forms.Button();
            this.btReports = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btCreateOrder = new System.Windows.Forms.Button();
            this.lbQuickActions = new System.Windows.Forms.Label();
            this.lbCustomers = new System.Windows.Forms.Label();
            this.lbLowStock = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbOrderToDay = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.tabManageEmployees = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtCurrentUserRoleEmployees = new System.Windows.Forms.TextBox();
            this.lbTipEmployees = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btDeleteEmployees = new System.Windows.Forms.Button();
            this.btEditEmployees = new System.Windows.Forms.Button();
            this.btExportEmployees = new System.Windows.Forms.Button();
            this.btAddEmployees = new System.Windows.Forms.Button();
            this.btClearEmployees = new System.Windows.Forms.Button();
            this.btSearchEmployees = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtKeyWordEmployees = new System.Windows.Forms.TextBox();
            this.lbCountEmployees = new System.Windows.Forms.Label();
            this.lbStatusEmployees = new System.Windows.Forms.Label();
            this.lbActionsEmployees = new System.Windows.Forms.Label();
            this.lbEmployeesSearch = new System.Windows.Forms.Label();
            this.tabManageCustomers = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTipCustomer = new System.Windows.Forms.Label();
            this.txtStatusManageCustomer = new System.Windows.Forms.TextBox();
            this.lbStatusCustomer = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.lbCountCustomer = new System.Windows.Forms.Label();
            this.btExportCustomer = new System.Windows.Forms.Button();
            this.btDeleteCustomer = new System.Windows.Forms.Button();
            this.btEditCustomer = new System.Windows.Forms.Button();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.lbActionsCustomer = new System.Windows.Forms.Label();
            this.btClearCustomer = new System.Windows.Forms.Button();
            this.btSearchCustomer = new System.Windows.Forms.Button();
            this.txtKeyWordCustomer = new System.Windows.Forms.TextBox();
            this.lbCustomersSearchFilters = new System.Windows.Forms.Label();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.btExportCategories = new System.Windows.Forms.Button();
            this.btDeleteCategories = new System.Windows.Forms.Button();
            this.btEditCategories = new System.Windows.Forms.Button();
            this.btAddCategories = new System.Windows.Forms.Button();
            this.btClearCategories = new System.Windows.Forms.Button();
            this.btSearchCategories = new System.Windows.Forms.Button();
            this.txtKeywordCategories = new System.Windows.Forms.TextBox();
            this.lbCountCategories = new System.Windows.Forms.Label();
            this.lbTipCategories = new System.Windows.Forms.Label();
            this.lbActionsCategories = new System.Windows.Forms.Label();
            this.lbCategoriesSearch = new System.Windows.Forms.Label();
            this.tabManageProducts = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridViewManageProduct = new System.Windows.Forms.DataGridView();
            this.lbCountManageProduct = new System.Windows.Forms.Label();
            this.btImportManageProduct = new System.Windows.Forms.Button();
            this.btExportManageProduct = new System.Windows.Forms.Button();
            this.btImageManageProduct = new System.Windows.Forms.Button();
            this.btDeleteManageDelete = new System.Windows.Forms.Button();
            this.btEditManageProduct = new System.Windows.Forms.Button();
            this.btAddManageProduct = new System.Windows.Forms.Button();
            this.lbTipManageProduct = new System.Windows.Forms.Label();
            this.lbActionsProduct = new System.Windows.Forms.Label();
            this.btClearProduct = new System.Windows.Forms.Button();
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.lbMaxPrice = new System.Windows.Forms.Label();
            this.lbMinPrice = new System.Windows.Forms.Label();
            this.numericUpDownMaxManageProduct = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinManageProduct = new System.Windows.Forms.NumericUpDown();
            this.cbManageProduct = new System.Windows.Forms.ComboBox();
            this.txtKeyWordManageProduct = new System.Windows.Forms.TextBox();
            this.lbProductsSearchFilters = new System.Windows.Forms.Label();
            this.tabManageOrders = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataGridViewOrderMaster = new System.Windows.Forms.DataGridView();
            this.btRefundManageOrder = new System.Windows.Forms.Button();
            this.btExportManageOrder = new System.Windows.Forms.Button();
            this.btCancelManageOrder = new System.Windows.Forms.Button();
            this.btPrintManageOrder = new System.Windows.Forms.Button();
            this.btRefreshManageOrder = new System.Windows.Forms.Button();
            this.btViewEditManageOrder = new System.Windows.Forms.Button();
            this.btNewOrderManageOrder = new System.Windows.Forms.Button();
            this.lbToManageOrder = new System.Windows.Forms.Label();
            this.lbFromManageOrder = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btSearchManageOrder = new System.Windows.Forms.Button();
            this.cbCustomerManageOrder = new System.Windows.Forms.ComboBox();
            this.cbStatusManageOrder = new System.Windows.Forms.ComboBox();
            this.txtManageOrderId = new System.Windows.Forms.TextBox();
            this.lbActionsManageOrder = new System.Windows.Forms.Label();
            this.lbOrderSearchFilters = new System.Windows.Forms.Label();
            this.tabManageOrderDetails = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtTotalSaleManageDetails = new System.Windows.Forms.TextBox();
            this.lbTotalSalesManageDetails = new System.Windows.Forms.Label();
            this.txtTotalQuantityManageOrderDetails = new System.Windows.Forms.TextBox();
            this.lbTotalQuantity = new System.Windows.Forms.Label();
            this.txtTotalRowsManageOrderDetails = new System.Windows.Forms.TextBox();
            this.lbTotalQuantityManageOrderDetails = new System.Windows.Forms.Label();
            this.dataGridViewManageOrderDetails = new System.Windows.Forms.DataGridView();
            this.lbCountManageOrderDetails = new System.Windows.Forms.Label();
            this.btExportManageOrderDetails = new System.Windows.Forms.Button();
            this.btRefreshManageOrderDetails = new System.Windows.Forms.Button();
            this.btSearchManageOrderDetails = new System.Windows.Forms.Button();
            this.lbActionsManageOrderDetails = new System.Windows.Forms.Label();
            this.lbToManageOrderDetails = new System.Windows.Forms.Label();
            this.lbFromManageOrderDetails = new System.Windows.Forms.Label();
            this.dateTimePickerToManageOrderDetails = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromManageOrderDetails = new System.Windows.Forms.DateTimePicker();
            this.txtProductNameManageOrderDetails = new System.Windows.Forms.TextBox();
            this.txtOrderIDManageOrderDetails = new System.Windows.Forms.TextBox();
            this.lbOrderDetailsSearchFilters = new System.Windows.Forms.Label();
            this.tabGoodReceipt = new System.Windows.Forms.TabPage();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbTotalQuantityGoodReceipt = new System.Windows.Forms.TextBox();
            this.txtTotalReceipt = new System.Windows.Forms.TextBox();
            this.lbTotalQuantityTotalReceipt = new System.Windows.Forms.Label();
            this.lbSummaryTotalReceipts = new System.Windows.Forms.Label();
            this.dataGridViewGoodsReceipt = new System.Windows.Forms.DataGridView();
            this.btClearGoodReceipt = new System.Windows.Forms.Button();
            this.btSearchGoodsReceipt = new System.Windows.Forms.Button();
            this.lbToGoodsReceipt = new System.Windows.Forms.Label();
            this.lbFromGoodsReceipt = new System.Windows.Forms.Label();
            this.dateTimePickerToGoodReceipt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromGoodReceipt = new System.Windows.Forms.DateTimePicker();
            this.lbReceiptsHistory = new System.Windows.Forms.Label();
            this.btAddReceipt = new System.Windows.Forms.Button();
            this.txtNoteGoodsReceipt = new System.Windows.Forms.TextBox();
            this.numericUpDownUnitCostGoodsReceipt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGoodsReceipt = new System.Windows.Forms.NumericUpDown();
            this.cbProductGoodsReceipt = new System.Windows.Forms.ComboBox();
            this.lbProductGoodsReceipt = new System.Windows.Forms.Label();
            this.lbUnitcost = new System.Windows.Forms.Label();
            this.lbNoteGoodsReceipt = new System.Windows.Forms.Label();
            this.lbQuantityGoodsReceipt = new System.Windows.Forms.Label();
            this.lbGoodsReceiptAddNewEntry = new System.Windows.Forms.Label();
            this.tabInventoryLog = new System.Windows.Forms.TabPage();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dataGridViewMovementsInventoryLog = new System.Windows.Forms.DataGridView();
            this.lbSummary = new System.Windows.Forms.Label();
            this.btExprotInventoryLog = new System.Windows.Forms.Button();
            this.btAdjustStockInventoryLog = new System.Windows.Forms.Button();
            this.lbActionsInventoryLog = new System.Windows.Forms.Label();
            this.btClearInventory = new System.Windows.Forms.Button();
            this.btSearchInventoryLog = new System.Windows.Forms.Button();
            this.lbToInventoryLog = new System.Windows.Forms.Label();
            this.lbFromInventoryLog = new System.Windows.Forms.Label();
            this.dateTimePickerToInventoryLog = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromInventoryLog = new System.Windows.Forms.DateTimePicker();
            this.cbTyleInventoryLog = new System.Windows.Forms.ComboBox();
            this.cbProductInventoryLog = new System.Windows.Forms.ComboBox();
            this.lbInventoryLogFilters = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btSearchReport = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.lbChartViewReport = new System.Windows.Forms.Label();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerToReport = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromReport = new System.Windows.Forms.DateTimePicker();
            this.lbToReport = new System.Windows.Forms.Label();
            this.lbFromReport = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.lbReportsType = new System.Windows.Forms.Label();
            this.lbReportsFilters = new System.Windows.Forms.Label();
            this.tabUserAccounts = new System.Windows.Forms.TabPage();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.dataGridViewUserAccounts = new System.Windows.Forms.DataGridView();
            this.btLockUnLock = new System.Windows.Forms.Button();
            this.btExportUser = new System.Windows.Forms.Button();
            this.lbCountUser = new System.Windows.Forms.Button();
            this.btEditUser = new System.Windows.Forms.Button();
            this.btDeleteUser = new System.Windows.Forms.Button();
            this.btResetPasswordUser = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.lbActionsUser = new System.Windows.Forms.Label();
            this.btClearUser = new System.Windows.Forms.Button();
            this.btSearchUser = new System.Windows.Forms.Button();
            this.cbRoleUser = new System.Windows.Forms.ComboBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lbUserAccounts = new System.Windows.Forms.Label();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.lbCountRole = new System.Windows.Forms.Label();
            this.btExportRole = new System.Windows.Forms.Button();
            this.btDeleteRole = new System.Windows.Forms.Button();
            this.btEditRole = new System.Windows.Forms.Button();
            this.btAddRole = new System.Windows.Forms.Button();
            this.lbActionsRole = new System.Windows.Forms.Label();
            this.btClearRole = new System.Windows.Forms.Button();
            this.btSearchRole = new System.Windows.Forms.Button();
            this.txtKeywordRole = new System.Windows.Forms.TextBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.tabBackupRestore = new System.Windows.Forms.TabPage();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.listboxLogWindow = new System.Windows.Forms.ListBox();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.lbRestoreDatabase = new System.Windows.Forms.Label();
            this.btRestoreData = new System.Windows.Forms.Button();
            this.btBrowseRestore = new System.Windows.Forms.Button();
            this.btBackupData = new System.Windows.Forms.Button();
            this.btBrowseBackup = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.lbBackupDatabase = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grBoxHome.SuspendLayout();
            this.tabManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabManageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.tabManageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxManageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinManageProduct)).BeginInit();
            this.tabManageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderMaster)).BeginInit();
            this.tabManageOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageOrderDetails)).BeginInit();
            this.tabGoodReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitCostGoodsReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodsReceipt)).BeginInit();
            this.tabInventoryLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovementsInventoryLog)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.tabUserAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAccounts)).BeginInit();
            this.tabRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.tabBackupRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabManageEmployees);
            this.tabControl.Controls.Add(this.tabManageCustomers);
            this.tabControl.Controls.Add(this.tabCategories);
            this.tabControl.Controls.Add(this.tabManageProducts);
            this.tabControl.Controls.Add(this.tabManageOrders);
            this.tabControl.Controls.Add(this.tabManageOrderDetails);
            this.tabControl.Controls.Add(this.tabGoodReceipt);
            this.tabControl.Controls.Add(this.tabInventoryLog);
            this.tabControl.Controls.Add(this.tabReports);
            this.tabControl.Controls.Add(this.tabUserAccounts);
            this.tabControl.Controls.Add(this.tabRoles);
            this.tabControl.Controls.Add(this.tabBackupRestore);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1276, 787);
            this.tabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.txtCustomersHome);
            this.tabHome.Controls.Add(this.txtLowStock);
            this.tabHome.Controls.Add(this.txtRevenue);
            this.tabHome.Controls.Add(this.txtOrderToday);
            this.tabHome.Controls.Add(this.pictureBox2);
            this.tabHome.Controls.Add(this.grBoxHome);
            this.tabHome.Controls.Add(this.btBackup);
            this.tabHome.Controls.Add(this.btReports);
            this.tabHome.Controls.Add(this.btAddProduct);
            this.tabHome.Controls.Add(this.btCreateOrder);
            this.tabHome.Controls.Add(this.lbQuickActions);
            this.tabHome.Controls.Add(this.lbCustomers);
            this.tabHome.Controls.Add(this.lbLowStock);
            this.tabHome.Controls.Add(this.lbRevenue);
            this.tabHome.Controls.Add(this.lbOrderToDay);
            this.tabHome.Controls.Add(this.lbTime);
            this.tabHome.Controls.Add(this.lbWelcome);
            this.tabHome.Location = new System.Drawing.Point(4, 28);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1268, 755);
            this.tabHome.TabIndex = 1;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
            // 
            // txtCustomersHome
            // 
            this.txtCustomersHome.Location = new System.Drawing.Point(1110, 262);
            this.txtCustomersHome.Name = "txtCustomersHome";
            this.txtCustomersHome.ReadOnly = true;
            this.txtCustomersHome.Size = new System.Drawing.Size(100, 26);
            this.txtCustomersHome.TabIndex = 16;
            // 
            // txtLowStock
            // 
            this.txtLowStock.Location = new System.Drawing.Point(819, 262);
            this.txtLowStock.Name = "txtLowStock";
            this.txtLowStock.ReadOnly = true;
            this.txtLowStock.Size = new System.Drawing.Size(100, 26);
            this.txtLowStock.TabIndex = 15;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(510, 263);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(100, 26);
            this.txtRevenue.TabIndex = 14;
            // 
            // txtOrderToday
            // 
            this.txtOrderToday.Location = new System.Drawing.Point(233, 262);
            this.txtOrderToday.Name = "txtOrderToday";
            this.txtOrderToday.ReadOnly = true;
            this.txtOrderToday.Size = new System.Drawing.Size(100, 26);
            this.txtOrderToday.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox2.Location = new System.Drawing.Point(1110, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // grBoxHome
            // 
            this.grBoxHome.Controls.Add(this.listBoxHome);
            this.grBoxHome.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxHome.Location = new System.Drawing.Point(85, 470);
            this.grBoxHome.Name = "grBoxHome";
            this.grBoxHome.Size = new System.Drawing.Size(1107, 266);
            this.grBoxHome.TabIndex = 11;
            this.grBoxHome.TabStop = false;
            this.grBoxHome.Text = "Recent Activity or Notice:";
            // 
            // listBoxHome
            // 
            this.listBoxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHome.FormattingEnabled = true;
            this.listBoxHome.ItemHeight = 31;
            this.listBoxHome.Location = new System.Drawing.Point(3, 35);
            this.listBoxHome.Name = "listBoxHome";
            this.listBoxHome.Size = new System.Drawing.Size(1101, 228);
            this.listBoxHome.TabIndex = 0;
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(976, 405);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(137, 31);
            this.btBackup.TabIndex = 10;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            // 
            // btReports
            // 
            this.btReports.Location = new System.Drawing.Point(752, 405);
            this.btReports.Name = "btReports";
            this.btReports.Size = new System.Drawing.Size(137, 31);
            this.btReports.TabIndex = 9;
            this.btReports.Text = "Reports";
            this.btReports.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(534, 405);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(137, 31);
            this.btAddProduct.TabIndex = 8;
            this.btAddProduct.Text = "Add Product";
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // btCreateOrder
            // 
            this.btCreateOrder.Location = new System.Drawing.Point(333, 405);
            this.btCreateOrder.Name = "btCreateOrder";
            this.btCreateOrder.Size = new System.Drawing.Size(137, 31);
            this.btCreateOrder.TabIndex = 7;
            this.btCreateOrder.Text = "Create Order";
            this.btCreateOrder.UseVisualStyleBackColor = true;
            // 
            // lbQuickActions
            // 
            this.lbQuickActions.AutoSize = true;
            this.lbQuickActions.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQuickActions.Location = new System.Drawing.Point(79, 405);
            this.lbQuickActions.Name = "lbQuickActions";
            this.lbQuickActions.Size = new System.Drawing.Size(169, 31);
            this.lbQuickActions.TabIndex = 6;
            this.lbQuickActions.Text = "Quick Actions";
            // 
            // lbCustomers
            // 
            this.lbCustomers.AutoSize = true;
            this.lbCustomers.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCustomers.Location = new System.Drawing.Point(981, 257);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(142, 31);
            this.lbCustomers.TabIndex = 5;
            this.lbCustomers.Text = "Customers: ";
            // 
            // lbLowStock
            // 
            this.lbLowStock.AutoSize = true;
            this.lbLowStock.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLowStock.Location = new System.Drawing.Point(677, 257);
            this.lbLowStock.Name = "lbLowStock";
            this.lbLowStock.Size = new System.Drawing.Size(145, 31);
            this.lbLowStock.TabIndex = 4;
            this.lbLowStock.Text = "Low Stock: ";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRevenue.Location = new System.Drawing.Point(399, 257);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(121, 31);
            this.lbRevenue.TabIndex = 3;
            this.lbRevenue.Text = "Revenue: ";
            // 
            // lbOrderToDay
            // 
            this.lbOrderToDay.AutoSize = true;
            this.lbOrderToDay.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOrderToDay.Location = new System.Drawing.Point(79, 257);
            this.lbOrderToDay.Name = "lbOrderToDay";
            this.lbOrderToDay.Size = new System.Drawing.Size(157, 31);
            this.lbOrderToDay.TabIndex = 2;
            this.lbOrderToDay.Text = "Order Today:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTime.Location = new System.Drawing.Point(746, 72);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(78, 31);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Date: ";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWelcome.Location = new System.Drawing.Point(144, 72);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(128, 31);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome: ";
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // tabManageEmployees
            // 
            this.tabManageEmployees.Controls.Add(this.pictureBox3);
            this.tabManageEmployees.Controls.Add(this.txtCurrentUserRoleEmployees);
            this.tabManageEmployees.Controls.Add(this.lbTipEmployees);
            this.tabManageEmployees.Controls.Add(this.dataGridViewEmployees);
            this.tabManageEmployees.Controls.Add(this.btDeleteEmployees);
            this.tabManageEmployees.Controls.Add(this.btEditEmployees);
            this.tabManageEmployees.Controls.Add(this.btExportEmployees);
            this.tabManageEmployees.Controls.Add(this.btAddEmployees);
            this.tabManageEmployees.Controls.Add(this.btClearEmployees);
            this.tabManageEmployees.Controls.Add(this.btSearchEmployees);
            this.tabManageEmployees.Controls.Add(this.cbPosition);
            this.tabManageEmployees.Controls.Add(this.txtKeyWordEmployees);
            this.tabManageEmployees.Controls.Add(this.lbCountEmployees);
            this.tabManageEmployees.Controls.Add(this.lbStatusEmployees);
            this.tabManageEmployees.Controls.Add(this.lbActionsEmployees);
            this.tabManageEmployees.Controls.Add(this.lbEmployeesSearch);
            this.tabManageEmployees.Location = new System.Drawing.Point(4, 28);
            this.tabManageEmployees.Name = "tabManageEmployees";
            this.tabManageEmployees.Size = new System.Drawing.Size(1268, 755);
            this.tabManageEmployees.TabIndex = 6;
            this.tabManageEmployees.Text = "Manage Employees";
            this.tabManageEmployees.UseVisualStyleBackColor = true;
            this.tabManageEmployees.Click += new System.EventHandler(this.tabManageEmployees_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox3.Location = new System.Drawing.Point(1134, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // txtCurrentUserRoleEmployees
            // 
            this.txtCurrentUserRoleEmployees.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCurrentUserRoleEmployees.Location = new System.Drawing.Point(142, 687);
            this.txtCurrentUserRoleEmployees.Name = "txtCurrentUserRoleEmployees";
            this.txtCurrentUserRoleEmployees.Size = new System.Drawing.Size(311, 39);
            this.txtCurrentUserRoleEmployees.TabIndex = 14;
            // 
            // lbTipEmployees
            // 
            this.lbTipEmployees.AutoSize = true;
            this.lbTipEmployees.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTipEmployees.Location = new System.Drawing.Point(866, 687);
            this.lbTipEmployees.Name = "lbTipEmployees";
            this.lbTipEmployees.Size = new System.Drawing.Size(346, 31);
            this.lbTipEmployees.TabIndex = 13;
            this.lbTipEmployees.Text = "Tips: Double-click row to Edit";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(55, 353);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1157, 293);
            this.dataGridViewEmployees.TabIndex = 12;
            // 
            // btDeleteEmployees
            // 
            this.btDeleteEmployees.Location = new System.Drawing.Point(532, 271);
            this.btDeleteEmployees.Name = "btDeleteEmployees";
            this.btDeleteEmployees.Size = new System.Drawing.Size(139, 39);
            this.btDeleteEmployees.TabIndex = 11;
            this.btDeleteEmployees.Text = "Delete";
            this.btDeleteEmployees.UseVisualStyleBackColor = true;
            // 
            // btEditEmployees
            // 
            this.btEditEmployees.Location = new System.Drawing.Point(284, 271);
            this.btEditEmployees.Name = "btEditEmployees";
            this.btEditEmployees.Size = new System.Drawing.Size(139, 39);
            this.btEditEmployees.TabIndex = 10;
            this.btEditEmployees.Text = "Edit";
            this.btEditEmployees.UseVisualStyleBackColor = true;
            // 
            // btExportEmployees
            // 
            this.btExportEmployees.Location = new System.Drawing.Point(781, 271);
            this.btExportEmployees.Name = "btExportEmployees";
            this.btExportEmployees.Size = new System.Drawing.Size(139, 39);
            this.btExportEmployees.TabIndex = 9;
            this.btExportEmployees.Text = "Export";
            this.btExportEmployees.UseVisualStyleBackColor = true;
            // 
            // btAddEmployees
            // 
            this.btAddEmployees.Location = new System.Drawing.Point(55, 271);
            this.btAddEmployees.Name = "btAddEmployees";
            this.btAddEmployees.Size = new System.Drawing.Size(139, 39);
            this.btAddEmployees.TabIndex = 8;
            this.btAddEmployees.Text = "Add";
            this.btAddEmployees.UseVisualStyleBackColor = true;
            // 
            // btClearEmployees
            // 
            this.btClearEmployees.Location = new System.Drawing.Point(977, 91);
            this.btClearEmployees.Name = "btClearEmployees";
            this.btClearEmployees.Size = new System.Drawing.Size(139, 39);
            this.btClearEmployees.TabIndex = 7;
            this.btClearEmployees.Text = "Clear";
            this.btClearEmployees.UseVisualStyleBackColor = true;
            // 
            // btSearchEmployees
            // 
            this.btSearchEmployees.Location = new System.Drawing.Point(692, 89);
            this.btSearchEmployees.Name = "btSearchEmployees";
            this.btSearchEmployees.Size = new System.Drawing.Size(139, 39);
            this.btSearchEmployees.TabIndex = 6;
            this.btSearchEmployees.Text = "Search";
            this.btSearchEmployees.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(404, 89);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 39);
            this.cbPosition.TabIndex = 5;
            // 
            // txtKeyWordEmployees
            // 
            this.txtKeyWordEmployees.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKeyWordEmployees.Location = new System.Drawing.Point(55, 89);
            this.txtKeyWordEmployees.Name = "txtKeyWordEmployees";
            this.txtKeyWordEmployees.Size = new System.Drawing.Size(204, 39);
            this.txtKeyWordEmployees.TabIndex = 4;
            // 
            // lbCountEmployees
            // 
            this.lbCountEmployees.AutoSize = true;
            this.lbCountEmployees.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountEmployees.Location = new System.Drawing.Point(1034, 272);
            this.lbCountEmployees.Name = "lbCountEmployees";
            this.lbCountEmployees.Size = new System.Drawing.Size(82, 31);
            this.lbCountEmployees.TabIndex = 3;
            this.lbCountEmployees.Text = "Count";
            // 
            // lbStatusEmployees
            // 
            this.lbStatusEmployees.AutoSize = true;
            this.lbStatusEmployees.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatusEmployees.Location = new System.Drawing.Point(49, 690);
            this.lbStatusEmployees.Name = "lbStatusEmployees";
            this.lbStatusEmployees.Size = new System.Drawing.Size(87, 31);
            this.lbStatusEmployees.TabIndex = 2;
            this.lbStatusEmployees.Text = "Status:";
            // 
            // lbActionsEmployees
            // 
            this.lbActionsEmployees.AutoSize = true;
            this.lbActionsEmployees.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsEmployees.Location = new System.Drawing.Point(49, 183);
            this.lbActionsEmployees.Name = "lbActionsEmployees";
            this.lbActionsEmployees.Size = new System.Drawing.Size(98, 31);
            this.lbActionsEmployees.TabIndex = 1;
            this.lbActionsEmployees.Text = "Actions";
            this.lbActionsEmployees.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbEmployeesSearch
            // 
            this.lbEmployeesSearch.AutoSize = true;
            this.lbEmployeesSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmployeesSearch.Location = new System.Drawing.Point(49, 19);
            this.lbEmployeesSearch.Name = "lbEmployeesSearch";
            this.lbEmployeesSearch.Size = new System.Drawing.Size(324, 31);
            this.lbEmployeesSearch.TabIndex = 0;
            this.lbEmployeesSearch.Text = "Employees ▸ Search & Filters";
            // 
            // tabManageCustomers
            // 
            this.tabManageCustomers.Controls.Add(this.pictureBox1);
            this.tabManageCustomers.Controls.Add(this.lbTipCustomer);
            this.tabManageCustomers.Controls.Add(this.txtStatusManageCustomer);
            this.tabManageCustomers.Controls.Add(this.lbStatusCustomer);
            this.tabManageCustomers.Controls.Add(this.dataGridViewCustomer);
            this.tabManageCustomers.Controls.Add(this.lbCountCustomer);
            this.tabManageCustomers.Controls.Add(this.btExportCustomer);
            this.tabManageCustomers.Controls.Add(this.btDeleteCustomer);
            this.tabManageCustomers.Controls.Add(this.btEditCustomer);
            this.tabManageCustomers.Controls.Add(this.btAddCustomer);
            this.tabManageCustomers.Controls.Add(this.lbActionsCustomer);
            this.tabManageCustomers.Controls.Add(this.btClearCustomer);
            this.tabManageCustomers.Controls.Add(this.btSearchCustomer);
            this.tabManageCustomers.Controls.Add(this.txtKeyWordCustomer);
            this.tabManageCustomers.Controls.Add(this.lbCustomersSearchFilters);
            this.tabManageCustomers.Location = new System.Drawing.Point(4, 28);
            this.tabManageCustomers.Name = "tabManageCustomers";
            this.tabManageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageCustomers.Size = new System.Drawing.Size(1268, 755);
            this.tabManageCustomers.TabIndex = 2;
            this.tabManageCustomers.Text = "Manage Customers";
            this.tabManageCustomers.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox1.Location = new System.Drawing.Point(1102, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbTipCustomer
            // 
            this.lbTipCustomer.AutoSize = true;
            this.lbTipCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTipCustomer.Location = new System.Drawing.Point(809, 704);
            this.lbTipCustomer.Name = "lbTipCustomer";
            this.lbTipCustomer.Size = new System.Drawing.Size(346, 31);
            this.lbTipCustomer.TabIndex = 13;
            this.lbTipCustomer.Text = "Tips: Double-click row to Edit";
            // 
            // txtStatusManageCustomer
            // 
            this.txtStatusManageCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStatusManageCustomer.Location = new System.Drawing.Point(155, 701);
            this.txtStatusManageCustomer.Name = "txtStatusManageCustomer";
            this.txtStatusManageCustomer.Size = new System.Drawing.Size(322, 39);
            this.txtStatusManageCustomer.TabIndex = 12;
            // 
            // lbStatusCustomer
            // 
            this.lbStatusCustomer.AutoSize = true;
            this.lbStatusCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatusCustomer.Location = new System.Drawing.Point(48, 704);
            this.lbStatusCustomer.Name = "lbStatusCustomer";
            this.lbStatusCustomer.Size = new System.Drawing.Size(101, 31);
            this.lbStatusCustomer.TabIndex = 11;
            this.lbStatusCustomer.Text = " Status: ";
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(54, 360);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1146, 323);
            this.dataGridViewCustomer.TabIndex = 10;
            // 
            // lbCountCustomer
            // 
            this.lbCountCustomer.AutoSize = true;
            this.lbCountCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountCustomer.Location = new System.Drawing.Point(1021, 278);
            this.lbCountCustomer.Name = "lbCountCustomer";
            this.lbCountCustomer.Size = new System.Drawing.Size(82, 31);
            this.lbCountCustomer.TabIndex = 9;
            this.lbCountCustomer.Text = "Count";
            // 
            // btExportCustomer
            // 
            this.btExportCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportCustomer.Location = new System.Drawing.Point(687, 269);
            this.btExportCustomer.Name = "btExportCustomer";
            this.btExportCustomer.Size = new System.Drawing.Size(145, 48);
            this.btExportCustomer.TabIndex = 8;
            this.btExportCustomer.Text = "Export";
            this.btExportCustomer.UseVisualStyleBackColor = true;
            // 
            // btDeleteCustomer
            // 
            this.btDeleteCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDeleteCustomer.Location = new System.Drawing.Point(469, 269);
            this.btDeleteCustomer.Name = "btDeleteCustomer";
            this.btDeleteCustomer.Size = new System.Drawing.Size(145, 48);
            this.btDeleteCustomer.TabIndex = 7;
            this.btDeleteCustomer.Text = "Delete";
            this.btDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEditCustomer.Location = new System.Drawing.Point(251, 269);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(145, 48);
            this.btEditCustomer.TabIndex = 6;
            this.btEditCustomer.Text = "Edit";
            this.btEditCustomer.UseVisualStyleBackColor = true;
            this.btEditCustomer.Click += new System.EventHandler(this.btEditCustomer_Click);
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddCustomer.Location = new System.Drawing.Point(54, 269);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(145, 48);
            this.btAddCustomer.TabIndex = 5;
            this.btAddCustomer.Text = "Add";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            // 
            // lbActionsCustomer
            // 
            this.lbActionsCustomer.AutoSize = true;
            this.lbActionsCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsCustomer.Location = new System.Drawing.Point(48, 198);
            this.lbActionsCustomer.Name = "lbActionsCustomer";
            this.lbActionsCustomer.Size = new System.Drawing.Size(98, 31);
            this.lbActionsCustomer.TabIndex = 4;
            this.lbActionsCustomer.Text = "Actions";
            // 
            // btClearCustomer
            // 
            this.btClearCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearCustomer.Location = new System.Drawing.Point(748, 91);
            this.btClearCustomer.Name = "btClearCustomer";
            this.btClearCustomer.Size = new System.Drawing.Size(173, 39);
            this.btClearCustomer.TabIndex = 3;
            this.btClearCustomer.Text = "Clear";
            this.btClearCustomer.UseVisualStyleBackColor = true;
            // 
            // btSearchCustomer
            // 
            this.btSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchCustomer.Location = new System.Drawing.Point(457, 89);
            this.btSearchCustomer.Name = "btSearchCustomer";
            this.btSearchCustomer.Size = new System.Drawing.Size(173, 39);
            this.btSearchCustomer.TabIndex = 2;
            this.btSearchCustomer.Text = "Search";
            this.btSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // txtKeyWordCustomer
            // 
            this.txtKeyWordCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKeyWordCustomer.Location = new System.Drawing.Point(54, 89);
            this.txtKeyWordCustomer.Name = "txtKeyWordCustomer";
            this.txtKeyWordCustomer.Size = new System.Drawing.Size(318, 39);
            this.txtKeyWordCustomer.TabIndex = 1;
            // 
            // lbCustomersSearchFilters
            // 
            this.lbCustomersSearchFilters.AutoSize = true;
            this.lbCustomersSearchFilters.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCustomersSearchFilters.Location = new System.Drawing.Point(48, 22);
            this.lbCustomersSearchFilters.Name = "lbCustomersSearchFilters";
            this.lbCustomersSearchFilters.Size = new System.Drawing.Size(348, 31);
            this.lbCustomersSearchFilters.TabIndex = 0;
            this.lbCustomersSearchFilters.Text = "Customers ▸ Search / Filters   ";
            // 
            // tabCategories
            // 
            this.tabCategories.Controls.Add(this.pictureBox4);
            this.tabCategories.Controls.Add(this.dataGridViewCategories);
            this.tabCategories.Controls.Add(this.btExportCategories);
            this.tabCategories.Controls.Add(this.btDeleteCategories);
            this.tabCategories.Controls.Add(this.btEditCategories);
            this.tabCategories.Controls.Add(this.btAddCategories);
            this.tabCategories.Controls.Add(this.btClearCategories);
            this.tabCategories.Controls.Add(this.btSearchCategories);
            this.tabCategories.Controls.Add(this.txtKeywordCategories);
            this.tabCategories.Controls.Add(this.lbCountCategories);
            this.tabCategories.Controls.Add(this.lbTipCategories);
            this.tabCategories.Controls.Add(this.lbActionsCategories);
            this.tabCategories.Controls.Add(this.lbCategoriesSearch);
            this.tabCategories.Location = new System.Drawing.Point(4, 28);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Size = new System.Drawing.Size(1268, 755);
            this.tabCategories.TabIndex = 12;
            this.tabCategories.Text = "Manage Categories";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox4.Location = new System.Drawing.Point(1092, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 146);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(46, 310);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.Size = new System.Drawing.Size(1136, 357);
            this.dataGridViewCategories.TabIndex = 12;
            // 
            // btExportCategories
            // 
            this.btExportCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportCategories.Location = new System.Drawing.Point(736, 230);
            this.btExportCategories.Name = "btExportCategories";
            this.btExportCategories.Size = new System.Drawing.Size(139, 39);
            this.btExportCategories.TabIndex = 11;
            this.btExportCategories.Text = "Export";
            this.btExportCategories.UseVisualStyleBackColor = true;
            // 
            // btDeleteCategories
            // 
            this.btDeleteCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDeleteCategories.Location = new System.Drawing.Point(511, 230);
            this.btDeleteCategories.Name = "btDeleteCategories";
            this.btDeleteCategories.Size = new System.Drawing.Size(139, 39);
            this.btDeleteCategories.TabIndex = 10;
            this.btDeleteCategories.Text = "Delete";
            this.btDeleteCategories.UseVisualStyleBackColor = true;
            // 
            // btEditCategories
            // 
            this.btEditCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEditCategories.Location = new System.Drawing.Point(275, 230);
            this.btEditCategories.Name = "btEditCategories";
            this.btEditCategories.Size = new System.Drawing.Size(139, 39);
            this.btEditCategories.TabIndex = 9;
            this.btEditCategories.Text = "Edit";
            this.btEditCategories.UseVisualStyleBackColor = true;
            // 
            // btAddCategories
            // 
            this.btAddCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddCategories.Location = new System.Drawing.Point(46, 230);
            this.btAddCategories.Name = "btAddCategories";
            this.btAddCategories.Size = new System.Drawing.Size(139, 39);
            this.btAddCategories.TabIndex = 8;
            this.btAddCategories.Text = "Add";
            this.btAddCategories.UseVisualStyleBackColor = true;
            // 
            // btClearCategories
            // 
            this.btClearCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearCategories.Location = new System.Drawing.Point(777, 88);
            this.btClearCategories.Name = "btClearCategories";
            this.btClearCategories.Size = new System.Drawing.Size(139, 39);
            this.btClearCategories.TabIndex = 7;
            this.btClearCategories.Text = "Clear";
            this.btClearCategories.UseVisualStyleBackColor = true;
            // 
            // btSearchCategories
            // 
            this.btSearchCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchCategories.Location = new System.Drawing.Point(459, 89);
            this.btSearchCategories.Name = "btSearchCategories";
            this.btSearchCategories.Size = new System.Drawing.Size(139, 39);
            this.btSearchCategories.TabIndex = 6;
            this.btSearchCategories.Text = "Search";
            this.btSearchCategories.UseVisualStyleBackColor = true;
            // 
            // txtKeywordCategories
            // 
            this.txtKeywordCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKeywordCategories.Location = new System.Drawing.Point(46, 89);
            this.txtKeywordCategories.Name = "txtKeywordCategories";
            this.txtKeywordCategories.Size = new System.Drawing.Size(281, 39);
            this.txtKeywordCategories.TabIndex = 5;
            // 
            // lbCountCategories
            // 
            this.lbCountCategories.AutoSize = true;
            this.lbCountCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountCategories.Location = new System.Drawing.Point(1021, 234);
            this.lbCountCategories.Name = "lbCountCategories";
            this.lbCountCategories.Size = new System.Drawing.Size(82, 31);
            this.lbCountCategories.TabIndex = 3;
            this.lbCountCategories.Text = "Count";
            // 
            // lbTipCategories
            // 
            this.lbTipCategories.AutoSize = true;
            this.lbTipCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTipCategories.Location = new System.Drawing.Point(40, 679);
            this.lbTipCategories.Name = "lbTipCategories";
            this.lbTipCategories.Size = new System.Drawing.Size(1028, 31);
            this.lbTipCategories.TabIndex = 2;
            this.lbTipCategories.Text = "Tip: Double-click row to Edit. Categories are used by Products; delete only if no" +
    "t referenced.";
            // 
            // lbActionsCategories
            // 
            this.lbActionsCategories.AutoSize = true;
            this.lbActionsCategories.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsCategories.Location = new System.Drawing.Point(40, 166);
            this.lbActionsCategories.Name = "lbActionsCategories";
            this.lbActionsCategories.Size = new System.Drawing.Size(98, 31);
            this.lbActionsCategories.TabIndex = 1;
            this.lbActionsCategories.Text = "Actions";
            // 
            // lbCategoriesSearch
            // 
            this.lbCategoriesSearch.AutoSize = true;
            this.lbCategoriesSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCategoriesSearch.Location = new System.Drawing.Point(40, 24);
            this.lbCategoriesSearch.Name = "lbCategoriesSearch";
            this.lbCategoriesSearch.Size = new System.Drawing.Size(235, 31);
            this.lbCategoriesSearch.TabIndex = 0;
            this.lbCategoriesSearch.Text = "Categories ▸ Search";
            // 
            // tabManageProducts
            // 
            this.tabManageProducts.Controls.Add(this.pictureBox5);
            this.tabManageProducts.Controls.Add(this.dataGridViewManageProduct);
            this.tabManageProducts.Controls.Add(this.lbCountManageProduct);
            this.tabManageProducts.Controls.Add(this.btImportManageProduct);
            this.tabManageProducts.Controls.Add(this.btExportManageProduct);
            this.tabManageProducts.Controls.Add(this.btImageManageProduct);
            this.tabManageProducts.Controls.Add(this.btDeleteManageDelete);
            this.tabManageProducts.Controls.Add(this.btEditManageProduct);
            this.tabManageProducts.Controls.Add(this.btAddManageProduct);
            this.tabManageProducts.Controls.Add(this.lbTipManageProduct);
            this.tabManageProducts.Controls.Add(this.lbActionsProduct);
            this.tabManageProducts.Controls.Add(this.btClearProduct);
            this.tabManageProducts.Controls.Add(this.btSearchProduct);
            this.tabManageProducts.Controls.Add(this.lbMaxPrice);
            this.tabManageProducts.Controls.Add(this.lbMinPrice);
            this.tabManageProducts.Controls.Add(this.numericUpDownMaxManageProduct);
            this.tabManageProducts.Controls.Add(this.numericUpDownMinManageProduct);
            this.tabManageProducts.Controls.Add(this.cbManageProduct);
            this.tabManageProducts.Controls.Add(this.txtKeyWordManageProduct);
            this.tabManageProducts.Controls.Add(this.lbProductsSearchFilters);
            this.tabManageProducts.Location = new System.Drawing.Point(4, 28);
            this.tabManageProducts.Name = "tabManageProducts";
            this.tabManageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageProducts.Size = new System.Drawing.Size(1268, 755);
            this.tabManageProducts.TabIndex = 0;
            this.tabManageProducts.Text = "Manage Products";
            this.tabManageProducts.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox5.Location = new System.Drawing.Point(1180, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridViewManageProduct
            // 
            this.dataGridViewManageProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageProduct.Location = new System.Drawing.Point(45, 307);
            this.dataGridViewManageProduct.Name = "dataGridViewManageProduct";
            this.dataGridViewManageProduct.Size = new System.Drawing.Size(1191, 353);
            this.dataGridViewManageProduct.TabIndex = 20;
            // 
            // lbCountManageProduct
            // 
            this.lbCountManageProduct.AutoSize = true;
            this.lbCountManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountManageProduct.Location = new System.Drawing.Point(1092, 221);
            this.lbCountManageProduct.Name = "lbCountManageProduct";
            this.lbCountManageProduct.Size = new System.Drawing.Size(82, 31);
            this.lbCountManageProduct.TabIndex = 19;
            this.lbCountManageProduct.Text = "Count";
            // 
            // btImportManageProduct
            // 
            this.btImportManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btImportManageProduct.Location = new System.Drawing.Point(891, 221);
            this.btImportManageProduct.Name = "btImportManageProduct";
            this.btImportManageProduct.Size = new System.Drawing.Size(115, 37);
            this.btImportManageProduct.TabIndex = 18;
            this.btImportManageProduct.Text = "Import";
            this.btImportManageProduct.UseVisualStyleBackColor = true;
            // 
            // btExportManageProduct
            // 
            this.btExportManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportManageProduct.Location = new System.Drawing.Point(721, 221);
            this.btExportManageProduct.Name = "btExportManageProduct";
            this.btExportManageProduct.Size = new System.Drawing.Size(115, 37);
            this.btExportManageProduct.TabIndex = 17;
            this.btExportManageProduct.Text = "Export";
            this.btExportManageProduct.UseVisualStyleBackColor = true;
            // 
            // btImageManageProduct
            // 
            this.btImageManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btImageManageProduct.Location = new System.Drawing.Point(548, 221);
            this.btImageManageProduct.Name = "btImageManageProduct";
            this.btImageManageProduct.Size = new System.Drawing.Size(115, 37);
            this.btImageManageProduct.TabIndex = 16;
            this.btImageManageProduct.Text = "Image";
            this.btImageManageProduct.UseVisualStyleBackColor = true;
            this.btImageManageProduct.Click += new System.EventHandler(this.btImageManageProduct_Click_1);
            // 
            // btDeleteManageDelete
            // 
            this.btDeleteManageDelete.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDeleteManageDelete.Location = new System.Drawing.Point(382, 221);
            this.btDeleteManageDelete.Name = "btDeleteManageDelete";
            this.btDeleteManageDelete.Size = new System.Drawing.Size(115, 37);
            this.btDeleteManageDelete.TabIndex = 15;
            this.btDeleteManageDelete.Text = "Delete";
            this.btDeleteManageDelete.UseVisualStyleBackColor = true;
            // 
            // btEditManageProduct
            // 
            this.btEditManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEditManageProduct.Location = new System.Drawing.Point(218, 221);
            this.btEditManageProduct.Name = "btEditManageProduct";
            this.btEditManageProduct.Size = new System.Drawing.Size(115, 37);
            this.btEditManageProduct.TabIndex = 14;
            this.btEditManageProduct.Text = "Edit";
            this.btEditManageProduct.UseVisualStyleBackColor = true;
            this.btEditManageProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAddManageProduct
            // 
            this.btAddManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddManageProduct.Location = new System.Drawing.Point(45, 221);
            this.btAddManageProduct.Name = "btAddManageProduct";
            this.btAddManageProduct.Size = new System.Drawing.Size(115, 37);
            this.btAddManageProduct.TabIndex = 13;
            this.btAddManageProduct.Text = "Add";
            this.btAddManageProduct.UseVisualStyleBackColor = true;
            // 
            // lbTipManageProduct
            // 
            this.lbTipManageProduct.AutoSize = true;
            this.lbTipManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTipManageProduct.Location = new System.Drawing.Point(39, 681);
            this.lbTipManageProduct.Name = "lbTipManageProduct";
            this.lbTipManageProduct.Size = new System.Drawing.Size(1007, 31);
            this.lbTipManageProduct.TabIndex = 12;
            this.lbTipManageProduct.Text = "Tips: Double-click row to Edit. Stock updated via Goods Receipt  or Orders automa" +
    "tically. ";
            // 
            // lbActionsProduct
            // 
            this.lbActionsProduct.AutoSize = true;
            this.lbActionsProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsProduct.Location = new System.Drawing.Point(39, 165);
            this.lbActionsProduct.Name = "lbActionsProduct";
            this.lbActionsProduct.Size = new System.Drawing.Size(98, 31);
            this.lbActionsProduct.TabIndex = 9;
            this.lbActionsProduct.Text = "Actions";
            // 
            // btClearProduct
            // 
            this.btClearProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearProduct.Location = new System.Drawing.Point(1084, 73);
            this.btClearProduct.Name = "btClearProduct";
            this.btClearProduct.Size = new System.Drawing.Size(115, 40);
            this.btClearProduct.TabIndex = 8;
            this.btClearProduct.Text = "Clear";
            this.btClearProduct.UseVisualStyleBackColor = true;
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchProduct.Location = new System.Drawing.Point(935, 73);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(115, 40);
            this.btSearchProduct.TabIndex = 7;
            this.btSearchProduct.Text = "Search";
            this.btSearchProduct.UseVisualStyleBackColor = true;
            // 
            // lbMaxPrice
            // 
            this.lbMaxPrice.AutoSize = true;
            this.lbMaxPrice.Location = new System.Drawing.Point(681, 85);
            this.lbMaxPrice.Name = "lbMaxPrice";
            this.lbMaxPrice.Size = new System.Drawing.Size(72, 19);
            this.lbMaxPrice.TabIndex = 6;
            this.lbMaxPrice.Text = "Max Price";
            // 
            // lbMinPrice
            // 
            this.lbMinPrice.AutoSize = true;
            this.lbMinPrice.Location = new System.Drawing.Point(469, 84);
            this.lbMinPrice.Name = "lbMinPrice";
            this.lbMinPrice.Size = new System.Drawing.Size(68, 19);
            this.lbMinPrice.TabIndex = 5;
            this.lbMinPrice.Text = "Min Price";
            // 
            // numericUpDownMaxManageProduct
            // 
            this.numericUpDownMaxManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownMaxManageProduct.Location = new System.Drawing.Point(759, 74);
            this.numericUpDownMaxManageProduct.Name = "numericUpDownMaxManageProduct";
            this.numericUpDownMaxManageProduct.Size = new System.Drawing.Size(120, 39);
            this.numericUpDownMaxManageProduct.TabIndex = 4;
            // 
            // numericUpDownMinManageProduct
            // 
            this.numericUpDownMinManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownMinManageProduct.Location = new System.Drawing.Point(543, 74);
            this.numericUpDownMinManageProduct.Name = "numericUpDownMinManageProduct";
            this.numericUpDownMinManageProduct.Size = new System.Drawing.Size(120, 39);
            this.numericUpDownMinManageProduct.TabIndex = 3;
            // 
            // cbManageProduct
            // 
            this.cbManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbManageProduct.FormattingEnabled = true;
            this.cbManageProduct.Location = new System.Drawing.Point(321, 73);
            this.cbManageProduct.Name = "cbManageProduct";
            this.cbManageProduct.Size = new System.Drawing.Size(121, 39);
            this.cbManageProduct.TabIndex = 2;
            // 
            // txtKeyWordManageProduct
            // 
            this.txtKeyWordManageProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKeyWordManageProduct.Location = new System.Drawing.Point(45, 73);
            this.txtKeyWordManageProduct.Name = "txtKeyWordManageProduct";
            this.txtKeyWordManageProduct.Size = new System.Drawing.Size(251, 39);
            this.txtKeyWordManageProduct.TabIndex = 1;
            // 
            // lbProductsSearchFilters
            // 
            this.lbProductsSearchFilters.AutoSize = true;
            this.lbProductsSearchFilters.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbProductsSearchFilters.Location = new System.Drawing.Point(39, 19);
            this.lbProductsSearchFilters.Name = "lbProductsSearchFilters";
            this.lbProductsSearchFilters.Size = new System.Drawing.Size(305, 31);
            this.lbProductsSearchFilters.TabIndex = 0;
            this.lbProductsSearchFilters.Text = "Products ▸ Search | Filters";
            // 
            // tabManageOrders
            // 
            this.tabManageOrders.Controls.Add(this.pictureBox6);
            this.tabManageOrders.Controls.Add(this.dataGridViewOrderMaster);
            this.tabManageOrders.Controls.Add(this.btRefundManageOrder);
            this.tabManageOrders.Controls.Add(this.btExportManageOrder);
            this.tabManageOrders.Controls.Add(this.btCancelManageOrder);
            this.tabManageOrders.Controls.Add(this.btPrintManageOrder);
            this.tabManageOrders.Controls.Add(this.btRefreshManageOrder);
            this.tabManageOrders.Controls.Add(this.btViewEditManageOrder);
            this.tabManageOrders.Controls.Add(this.btNewOrderManageOrder);
            this.tabManageOrders.Controls.Add(this.lbToManageOrder);
            this.tabManageOrders.Controls.Add(this.lbFromManageOrder);
            this.tabManageOrders.Controls.Add(this.dateTimePickerTo);
            this.tabManageOrders.Controls.Add(this.dateTimePickerFrom);
            this.tabManageOrders.Controls.Add(this.btSearchManageOrder);
            this.tabManageOrders.Controls.Add(this.cbCustomerManageOrder);
            this.tabManageOrders.Controls.Add(this.cbStatusManageOrder);
            this.tabManageOrders.Controls.Add(this.txtManageOrderId);
            this.tabManageOrders.Controls.Add(this.lbActionsManageOrder);
            this.tabManageOrders.Controls.Add(this.lbOrderSearchFilters);
            this.tabManageOrders.Location = new System.Drawing.Point(4, 28);
            this.tabManageOrders.Name = "tabManageOrders";
            this.tabManageOrders.Size = new System.Drawing.Size(1268, 755);
            this.tabManageOrders.TabIndex = 3;
            this.tabManageOrders.Text = "Manage Orders";
            this.tabManageOrders.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox6.Location = new System.Drawing.Point(1200, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // dataGridViewOrderMaster
            // 
            this.dataGridViewOrderMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderMaster.Location = new System.Drawing.Point(33, 251);
            this.dataGridViewOrderMaster.Name = "dataGridViewOrderMaster";
            this.dataGridViewOrderMaster.Size = new System.Drawing.Size(1217, 476);
            this.dataGridViewOrderMaster.TabIndex = 17;
            // 
            // btRefundManageOrder
            // 
            this.btRefundManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRefundManageOrder.Location = new System.Drawing.Point(752, 181);
            this.btRefundManageOrder.Name = "btRefundManageOrder";
            this.btRefundManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btRefundManageOrder.TabIndex = 16;
            this.btRefundManageOrder.Text = "Refund";
            this.btRefundManageOrder.UseVisualStyleBackColor = true;
            // 
            // btExportManageOrder
            // 
            this.btExportManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportManageOrder.Location = new System.Drawing.Point(922, 181);
            this.btExportManageOrder.Name = "btExportManageOrder";
            this.btExportManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btExportManageOrder.TabIndex = 15;
            this.btExportManageOrder.Text = "Export";
            this.btExportManageOrder.UseVisualStyleBackColor = true;
            // 
            // btCancelManageOrder
            // 
            this.btCancelManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCancelManageOrder.Location = new System.Drawing.Point(569, 181);
            this.btCancelManageOrder.Name = "btCancelManageOrder";
            this.btCancelManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btCancelManageOrder.TabIndex = 14;
            this.btCancelManageOrder.Text = "Cancel";
            this.btCancelManageOrder.UseVisualStyleBackColor = true;
            this.btCancelManageOrder.Click += new System.EventHandler(this.button5_Click);
            // 
            // btPrintManageOrder
            // 
            this.btPrintManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPrintManageOrder.Location = new System.Drawing.Point(391, 181);
            this.btPrintManageOrder.Name = "btPrintManageOrder";
            this.btPrintManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btPrintManageOrder.TabIndex = 13;
            this.btPrintManageOrder.Text = "Print";
            this.btPrintManageOrder.UseVisualStyleBackColor = true;
            // 
            // btRefreshManageOrder
            // 
            this.btRefreshManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRefreshManageOrder.Location = new System.Drawing.Point(1100, 181);
            this.btRefreshManageOrder.Name = "btRefreshManageOrder";
            this.btRefreshManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btRefreshManageOrder.TabIndex = 12;
            this.btRefreshManageOrder.Text = "Refresh";
            this.btRefreshManageOrder.UseVisualStyleBackColor = true;
            // 
            // btViewEditManageOrder
            // 
            this.btViewEditManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btViewEditManageOrder.Location = new System.Drawing.Point(208, 181);
            this.btViewEditManageOrder.Name = "btViewEditManageOrder";
            this.btViewEditManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btViewEditManageOrder.TabIndex = 11;
            this.btViewEditManageOrder.Text = "View/Edit";
            this.btViewEditManageOrder.UseVisualStyleBackColor = true;
            // 
            // btNewOrderManageOrder
            // 
            this.btNewOrderManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNewOrderManageOrder.Location = new System.Drawing.Point(33, 181);
            this.btNewOrderManageOrder.Name = "btNewOrderManageOrder";
            this.btNewOrderManageOrder.Size = new System.Drawing.Size(150, 41);
            this.btNewOrderManageOrder.TabIndex = 10;
            this.btNewOrderManageOrder.Text = "New Order";
            this.btNewOrderManageOrder.UseVisualStyleBackColor = true;
            // 
            // lbToManageOrder
            // 
            this.lbToManageOrder.AutoSize = true;
            this.lbToManageOrder.Location = new System.Drawing.Point(843, 81);
            this.lbToManageOrder.Name = "lbToManageOrder";
            this.lbToManageOrder.Size = new System.Drawing.Size(25, 19);
            this.lbToManageOrder.TabIndex = 9;
            this.lbToManageOrder.Text = "To";
            // 
            // lbFromManageOrder
            // 
            this.lbFromManageOrder.AutoSize = true;
            this.lbFromManageOrder.Location = new System.Drawing.Point(604, 81);
            this.lbFromManageOrder.Name = "lbFromManageOrder";
            this.lbFromManageOrder.Size = new System.Drawing.Size(42, 19);
            this.lbFromManageOrder.TabIndex = 8;
            this.lbFromManageOrder.Text = "From";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(874, 75);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(186, 26);
            this.dateTimePickerTo.TabIndex = 7;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(652, 78);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(185, 26);
            this.dateTimePickerFrom.TabIndex = 6;
            // 
            // btSearchManageOrder
            // 
            this.btSearchManageOrder.Location = new System.Drawing.Point(1091, 75);
            this.btSearchManageOrder.Name = "btSearchManageOrder";
            this.btSearchManageOrder.Size = new System.Drawing.Size(159, 39);
            this.btSearchManageOrder.TabIndex = 5;
            this.btSearchManageOrder.Text = "Search";
            this.btSearchManageOrder.UseVisualStyleBackColor = true;
            // 
            // cbCustomerManageOrder
            // 
            this.cbCustomerManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCustomerManageOrder.FormattingEnabled = true;
            this.cbCustomerManageOrder.Location = new System.Drawing.Point(426, 73);
            this.cbCustomerManageOrder.Name = "cbCustomerManageOrder";
            this.cbCustomerManageOrder.Size = new System.Drawing.Size(154, 39);
            this.cbCustomerManageOrder.TabIndex = 4;
            // 
            // cbStatusManageOrder
            // 
            this.cbStatusManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbStatusManageOrder.FormattingEnabled = true;
            this.cbStatusManageOrder.Location = new System.Drawing.Point(256, 73);
            this.cbStatusManageOrder.Name = "cbStatusManageOrder";
            this.cbStatusManageOrder.Size = new System.Drawing.Size(154, 39);
            this.cbStatusManageOrder.TabIndex = 3;
            // 
            // txtManageOrderId
            // 
            this.txtManageOrderId.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtManageOrderId.Location = new System.Drawing.Point(33, 75);
            this.txtManageOrderId.Name = "txtManageOrderId";
            this.txtManageOrderId.Size = new System.Drawing.Size(208, 39);
            this.txtManageOrderId.TabIndex = 2;
            // 
            // lbActionsManageOrder
            // 
            this.lbActionsManageOrder.AutoSize = true;
            this.lbActionsManageOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsManageOrder.Location = new System.Drawing.Point(27, 132);
            this.lbActionsManageOrder.Name = "lbActionsManageOrder";
            this.lbActionsManageOrder.Size = new System.Drawing.Size(98, 31);
            this.lbActionsManageOrder.TabIndex = 1;
            this.lbActionsManageOrder.Text = "Actions";
            // 
            // lbOrderSearchFilters
            // 
            this.lbOrderSearchFilters.AutoSize = true;
            this.lbOrderSearchFilters.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOrderSearchFilters.Location = new System.Drawing.Point(27, 20);
            this.lbOrderSearchFilters.Name = "lbOrderSearchFilters";
            this.lbOrderSearchFilters.Size = new System.Drawing.Size(282, 31);
            this.lbOrderSearchFilters.TabIndex = 0;
            this.lbOrderSearchFilters.Text = "Orders ▸ Search | Filters";
            // 
            // tabManageOrderDetails
            // 
            this.tabManageOrderDetails.Controls.Add(this.pictureBox7);
            this.tabManageOrderDetails.Controls.Add(this.txtTotalSaleManageDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbTotalSalesManageDetails);
            this.tabManageOrderDetails.Controls.Add(this.txtTotalQuantityManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbTotalQuantity);
            this.tabManageOrderDetails.Controls.Add(this.txtTotalRowsManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbTotalQuantityManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.dataGridViewManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbCountManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.btExportManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.btRefreshManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.btSearchManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbActionsManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbToManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbFromManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.dateTimePickerToManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.dateTimePickerFromManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.txtProductNameManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.txtOrderIDManageOrderDetails);
            this.tabManageOrderDetails.Controls.Add(this.lbOrderDetailsSearchFilters);
            this.tabManageOrderDetails.Location = new System.Drawing.Point(4, 28);
            this.tabManageOrderDetails.Name = "tabManageOrderDetails";
            this.tabManageOrderDetails.Size = new System.Drawing.Size(1268, 755);
            this.tabManageOrderDetails.TabIndex = 13;
            this.tabManageOrderDetails.Text = "Manage Order Details";
            this.tabManageOrderDetails.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox7.Location = new System.Drawing.Point(1180, 8);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 61);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // txtTotalSaleManageDetails
            // 
            this.txtTotalSaleManageDetails.Location = new System.Drawing.Point(871, 675);
            this.txtTotalSaleManageDetails.Name = "txtTotalSaleManageDetails";
            this.txtTotalSaleManageDetails.Size = new System.Drawing.Size(59, 26);
            this.txtTotalSaleManageDetails.TabIndex = 19;
            // 
            // lbTotalSalesManageDetails
            // 
            this.lbTotalSalesManageDetails.AutoSize = true;
            this.lbTotalSalesManageDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalSalesManageDetails.Location = new System.Drawing.Point(699, 669);
            this.lbTotalSalesManageDetails.Name = "lbTotalSalesManageDetails";
            this.lbTotalSalesManageDetails.Size = new System.Drawing.Size(140, 31);
            this.lbTotalSalesManageDetails.TabIndex = 18;
            this.lbTotalSalesManageDetails.Text = "Total Sales:";
            // 
            // txtTotalQuantityManageOrderDetails
            // 
            this.txtTotalQuantityManageOrderDetails.Location = new System.Drawing.Point(578, 674);
            this.txtTotalQuantityManageOrderDetails.Name = "txtTotalQuantityManageOrderDetails";
            this.txtTotalQuantityManageOrderDetails.Size = new System.Drawing.Size(59, 26);
            this.txtTotalQuantityManageOrderDetails.TabIndex = 17;
            // 
            // lbTotalQuantity
            // 
            this.lbTotalQuantity.AutoSize = true;
            this.lbTotalQuantity.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalQuantity.Location = new System.Drawing.Point(382, 667);
            this.lbTotalQuantity.Name = "lbTotalQuantity";
            this.lbTotalQuantity.Size = new System.Drawing.Size(178, 31);
            this.lbTotalQuantity.TabIndex = 16;
            this.lbTotalQuantity.Text = "Total Quantity:";
            // 
            // txtTotalRowsManageOrderDetails
            // 
            this.txtTotalRowsManageOrderDetails.Location = new System.Drawing.Point(299, 673);
            this.txtTotalRowsManageOrderDetails.Name = "txtTotalRowsManageOrderDetails";
            this.txtTotalRowsManageOrderDetails.Size = new System.Drawing.Size(59, 26);
            this.txtTotalRowsManageOrderDetails.TabIndex = 15;
            this.txtTotalRowsManageOrderDetails.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbTotalQuantityManageOrderDetails
            // 
            this.lbTotalQuantityManageOrderDetails.AutoSize = true;
            this.lbTotalQuantityManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalQuantityManageOrderDetails.Location = new System.Drawing.Point(38, 668);
            this.lbTotalQuantityManageOrderDetails.Name = "lbTotalQuantityManageOrderDetails";
            this.lbTotalQuantityManageOrderDetails.Size = new System.Drawing.Size(260, 31);
            this.lbTotalQuantityManageOrderDetails.TabIndex = 14;
            this.lbTotalQuantityManageOrderDetails.Text = "Summary: Total Rows:";
            // 
            // dataGridViewManageOrderDetails
            // 
            this.dataGridViewManageOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageOrderDetails.Location = new System.Drawing.Point(30, 287);
            this.dataGridViewManageOrderDetails.Name = "dataGridViewManageOrderDetails";
            this.dataGridViewManageOrderDetails.Size = new System.Drawing.Size(1199, 352);
            this.dataGridViewManageOrderDetails.TabIndex = 13;
            // 
            // lbCountManageOrderDetails
            // 
            this.lbCountManageOrderDetails.AutoSize = true;
            this.lbCountManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountManageOrderDetails.Location = new System.Drawing.Point(447, 215);
            this.lbCountManageOrderDetails.Name = "lbCountManageOrderDetails";
            this.lbCountManageOrderDetails.Size = new System.Drawing.Size(82, 31);
            this.lbCountManageOrderDetails.TabIndex = 12;
            this.lbCountManageOrderDetails.Text = "Count";
            // 
            // btExportManageOrderDetails
            // 
            this.btExportManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportManageOrderDetails.Location = new System.Drawing.Point(250, 208);
            this.btExportManageOrderDetails.Name = "btExportManageOrderDetails";
            this.btExportManageOrderDetails.Size = new System.Drawing.Size(108, 45);
            this.btExportManageOrderDetails.TabIndex = 10;
            this.btExportManageOrderDetails.Text = "Export";
            this.btExportManageOrderDetails.UseVisualStyleBackColor = true;
            // 
            // btRefreshManageOrderDetails
            // 
            this.btRefreshManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRefreshManageOrderDetails.Location = new System.Drawing.Point(30, 208);
            this.btRefreshManageOrderDetails.Name = "btRefreshManageOrderDetails";
            this.btRefreshManageOrderDetails.Size = new System.Drawing.Size(108, 45);
            this.btRefreshManageOrderDetails.TabIndex = 9;
            this.btRefreshManageOrderDetails.Text = "Refresh";
            this.btRefreshManageOrderDetails.UseVisualStyleBackColor = true;
            // 
            // btSearchManageOrderDetails
            // 
            this.btSearchManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchManageOrderDetails.Location = new System.Drawing.Point(1121, 75);
            this.btSearchManageOrderDetails.Name = "btSearchManageOrderDetails";
            this.btSearchManageOrderDetails.Size = new System.Drawing.Size(108, 39);
            this.btSearchManageOrderDetails.TabIndex = 8;
            this.btSearchManageOrderDetails.Text = "Search";
            this.btSearchManageOrderDetails.UseVisualStyleBackColor = true;
            // 
            // lbActionsManageOrderDetails
            // 
            this.lbActionsManageOrderDetails.AutoSize = true;
            this.lbActionsManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsManageOrderDetails.Location = new System.Drawing.Point(24, 149);
            this.lbActionsManageOrderDetails.Name = "lbActionsManageOrderDetails";
            this.lbActionsManageOrderDetails.Size = new System.Drawing.Size(98, 31);
            this.lbActionsManageOrderDetails.TabIndex = 7;
            this.lbActionsManageOrderDetails.Text = "Actions";
            // 
            // lbToManageOrderDetails
            // 
            this.lbToManageOrderDetails.AutoSize = true;
            this.lbToManageOrderDetails.Location = new System.Drawing.Point(797, 90);
            this.lbToManageOrderDetails.Name = "lbToManageOrderDetails";
            this.lbToManageOrderDetails.Size = new System.Drawing.Size(25, 19);
            this.lbToManageOrderDetails.TabIndex = 6;
            this.lbToManageOrderDetails.Text = "To";
            // 
            // lbFromManageOrderDetails
            // 
            this.lbFromManageOrderDetails.AutoSize = true;
            this.lbFromManageOrderDetails.Location = new System.Drawing.Point(472, 90);
            this.lbFromManageOrderDetails.Name = "lbFromManageOrderDetails";
            this.lbFromManageOrderDetails.Size = new System.Drawing.Size(42, 19);
            this.lbFromManageOrderDetails.TabIndex = 5;
            this.lbFromManageOrderDetails.Text = "From";
            // 
            // dateTimePickerToManageOrderDetails
            // 
            this.dateTimePickerToManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerToManageOrderDetails.Location = new System.Drawing.Point(828, 75);
            this.dateTimePickerToManageOrderDetails.Name = "dateTimePickerToManageOrderDetails";
            this.dateTimePickerToManageOrderDetails.Size = new System.Drawing.Size(260, 39);
            this.dateTimePickerToManageOrderDetails.TabIndex = 4;
            // 
            // dateTimePickerFromManageOrderDetails
            // 
            this.dateTimePickerFromManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerFromManageOrderDetails.Location = new System.Drawing.Point(520, 78);
            this.dateTimePickerFromManageOrderDetails.Name = "dateTimePickerFromManageOrderDetails";
            this.dateTimePickerFromManageOrderDetails.Size = new System.Drawing.Size(260, 39);
            this.dateTimePickerFromManageOrderDetails.TabIndex = 3;
            // 
            // txtProductNameManageOrderDetails
            // 
            this.txtProductNameManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProductNameManageOrderDetails.Location = new System.Drawing.Point(250, 78);
            this.txtProductNameManageOrderDetails.Name = "txtProductNameManageOrderDetails";
            this.txtProductNameManageOrderDetails.Size = new System.Drawing.Size(181, 39);
            this.txtProductNameManageOrderDetails.TabIndex = 2;
            // 
            // txtOrderIDManageOrderDetails
            // 
            this.txtOrderIDManageOrderDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOrderIDManageOrderDetails.Location = new System.Drawing.Point(30, 78);
            this.txtOrderIDManageOrderDetails.Name = "txtOrderIDManageOrderDetails";
            this.txtOrderIDManageOrderDetails.Size = new System.Drawing.Size(181, 39);
            this.txtOrderIDManageOrderDetails.TabIndex = 1;
            // 
            // lbOrderDetailsSearchFilters
            // 
            this.lbOrderDetailsSearchFilters.AutoSize = true;
            this.lbOrderDetailsSearchFilters.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOrderDetailsSearchFilters.Location = new System.Drawing.Point(24, 15);
            this.lbOrderDetailsSearchFilters.Name = "lbOrderDetailsSearchFilters";
            this.lbOrderDetailsSearchFilters.Size = new System.Drawing.Size(357, 31);
            this.lbOrderDetailsSearchFilters.TabIndex = 0;
            this.lbOrderDetailsSearchFilters.Text = "Order Details ▸ Search Filters  ";
            // 
            // tabGoodReceipt
            // 
            this.tabGoodReceipt.Controls.Add(this.pictureBox8);
            this.tabGoodReceipt.Controls.Add(this.lbTotalQuantityGoodReceipt);
            this.tabGoodReceipt.Controls.Add(this.txtTotalReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbTotalQuantityTotalReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbSummaryTotalReceipts);
            this.tabGoodReceipt.Controls.Add(this.dataGridViewGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.btClearGoodReceipt);
            this.tabGoodReceipt.Controls.Add(this.btSearchGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbToGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbFromGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.dateTimePickerToGoodReceipt);
            this.tabGoodReceipt.Controls.Add(this.dateTimePickerFromGoodReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbReceiptsHistory);
            this.tabGoodReceipt.Controls.Add(this.btAddReceipt);
            this.tabGoodReceipt.Controls.Add(this.txtNoteGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.numericUpDownUnitCostGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.numericUpDownGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.cbProductGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbProductGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbUnitcost);
            this.tabGoodReceipt.Controls.Add(this.lbNoteGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbQuantityGoodsReceipt);
            this.tabGoodReceipt.Controls.Add(this.lbGoodsReceiptAddNewEntry);
            this.tabGoodReceipt.Location = new System.Drawing.Point(4, 28);
            this.tabGoodReceipt.Name = "tabGoodReceipt";
            this.tabGoodReceipt.Size = new System.Drawing.Size(1268, 755);
            this.tabGoodReceipt.TabIndex = 4;
            this.tabGoodReceipt.Text = "Goods Receipt";
            this.tabGoodReceipt.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox8.Location = new System.Drawing.Point(1172, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 67);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // lbTotalQuantityGoodReceipt
            // 
            this.lbTotalQuantityGoodReceipt.Location = new System.Drawing.Point(734, 703);
            this.lbTotalQuantityGoodReceipt.Name = "lbTotalQuantityGoodReceipt";
            this.lbTotalQuantityGoodReceipt.Size = new System.Drawing.Size(100, 26);
            this.lbTotalQuantityGoodReceipt.TabIndex = 21;
            // 
            // txtTotalReceipt
            // 
            this.txtTotalReceipt.Location = new System.Drawing.Point(327, 702);
            this.txtTotalReceipt.Name = "txtTotalReceipt";
            this.txtTotalReceipt.Size = new System.Drawing.Size(100, 26);
            this.txtTotalReceipt.TabIndex = 20;
            // 
            // lbTotalQuantityTotalReceipt
            // 
            this.lbTotalQuantityTotalReceipt.AutoSize = true;
            this.lbTotalQuantityTotalReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalQuantityTotalReceipt.Location = new System.Drawing.Point(543, 697);
            this.lbTotalQuantityTotalReceipt.Name = "lbTotalQuantityTotalReceipt";
            this.lbTotalQuantityTotalReceipt.Size = new System.Drawing.Size(185, 31);
            this.lbTotalQuantityTotalReceipt.TabIndex = 19;
            this.lbTotalQuantityTotalReceipt.Text = "Total Quantity: ";
            // 
            // lbSummaryTotalReceipts
            // 
            this.lbSummaryTotalReceipts.AutoSize = true;
            this.lbSummaryTotalReceipts.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSummaryTotalReceipts.Location = new System.Drawing.Point(19, 697);
            this.lbSummaryTotalReceipts.Name = "lbSummaryTotalReceipts";
            this.lbSummaryTotalReceipts.Size = new System.Drawing.Size(306, 31);
            this.lbSummaryTotalReceipts.TabIndex = 18;
            this.lbSummaryTotalReceipts.Text = " Summary: Total Receipts: ";
            // 
            // dataGridViewGoodsReceipt
            // 
            this.dataGridViewGoodsReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoodsReceipt.Location = new System.Drawing.Point(25, 316);
            this.dataGridViewGoodsReceipt.Name = "dataGridViewGoodsReceipt";
            this.dataGridViewGoodsReceipt.Size = new System.Drawing.Size(1202, 366);
            this.dataGridViewGoodsReceipt.TabIndex = 17;
            // 
            // btClearGoodReceipt
            // 
            this.btClearGoodReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearGoodReceipt.Location = new System.Drawing.Point(915, 226);
            this.btClearGoodReceipt.Name = "btClearGoodReceipt";
            this.btClearGoodReceipt.Size = new System.Drawing.Size(148, 42);
            this.btClearGoodReceipt.TabIndex = 16;
            this.btClearGoodReceipt.Text = "Clear";
            this.btClearGoodReceipt.UseVisualStyleBackColor = true;
            // 
            // btSearchGoodsReceipt
            // 
            this.btSearchGoodsReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchGoodsReceipt.Location = new System.Drawing.Point(724, 226);
            this.btSearchGoodsReceipt.Name = "btSearchGoodsReceipt";
            this.btSearchGoodsReceipt.Size = new System.Drawing.Size(148, 42);
            this.btSearchGoodsReceipt.TabIndex = 15;
            this.btSearchGoodsReceipt.Text = "Search";
            this.btSearchGoodsReceipt.UseVisualStyleBackColor = true;
            // 
            // lbToGoodsReceipt
            // 
            this.lbToGoodsReceipt.AutoSize = true;
            this.lbToGoodsReceipt.Location = new System.Drawing.Point(405, 235);
            this.lbToGoodsReceipt.Name = "lbToGoodsReceipt";
            this.lbToGoodsReceipt.Size = new System.Drawing.Size(25, 19);
            this.lbToGoodsReceipt.TabIndex = 14;
            this.lbToGoodsReceipt.Text = "To";
            // 
            // lbFromGoodsReceipt
            // 
            this.lbFromGoodsReceipt.AutoSize = true;
            this.lbFromGoodsReceipt.Location = new System.Drawing.Point(59, 235);
            this.lbFromGoodsReceipt.Name = "lbFromGoodsReceipt";
            this.lbFromGoodsReceipt.Size = new System.Drawing.Size(42, 19);
            this.lbFromGoodsReceipt.TabIndex = 13;
            this.lbFromGoodsReceipt.Text = "From";
            // 
            // dateTimePickerToGoodReceipt
            // 
            this.dateTimePickerToGoodReceipt.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerToGoodReceipt.Location = new System.Drawing.Point(436, 235);
            this.dateTimePickerToGoodReceipt.Name = "dateTimePickerToGoodReceipt";
            this.dateTimePickerToGoodReceipt.Size = new System.Drawing.Size(249, 26);
            this.dateTimePickerToGoodReceipt.TabIndex = 12;
            // 
            // dateTimePickerFromGoodReceipt
            // 
            this.dateTimePickerFromGoodReceipt.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerFromGoodReceipt.Location = new System.Drawing.Point(107, 235);
            this.dateTimePickerFromGoodReceipt.Name = "dateTimePickerFromGoodReceipt";
            this.dateTimePickerFromGoodReceipt.Size = new System.Drawing.Size(249, 26);
            this.dateTimePickerFromGoodReceipt.TabIndex = 11;
            // 
            // lbReceiptsHistory
            // 
            this.lbReceiptsHistory.AutoSize = true;
            this.lbReceiptsHistory.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReceiptsHistory.Location = new System.Drawing.Point(19, 175);
            this.lbReceiptsHistory.Name = "lbReceiptsHistory";
            this.lbReceiptsHistory.Size = new System.Drawing.Size(364, 31);
            this.lbReceiptsHistory.TabIndex = 10;
            this.lbReceiptsHistory.Text = "Receipts History (today / filters)";
            // 
            // btAddReceipt
            // 
            this.btAddReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddReceipt.Location = new System.Drawing.Point(1064, 89);
            this.btAddReceipt.Name = "btAddReceipt";
            this.btAddReceipt.Size = new System.Drawing.Size(163, 41);
            this.btAddReceipt.TabIndex = 9;
            this.btAddReceipt.Text = "AddReceipt";
            this.btAddReceipt.UseVisualStyleBackColor = true;
            // 
            // txtNoteGoodsReceipt
            // 
            this.txtNoteGoodsReceipt.Location = new System.Drawing.Point(915, 100);
            this.txtNoteGoodsReceipt.Name = "txtNoteGoodsReceipt";
            this.txtNoteGoodsReceipt.Size = new System.Drawing.Size(100, 26);
            this.txtNoteGoodsReceipt.TabIndex = 8;
            // 
            // numericUpDownUnitCostGoodsReceipt
            // 
            this.numericUpDownUnitCostGoodsReceipt.Location = new System.Drawing.Point(694, 101);
            this.numericUpDownUnitCostGoodsReceipt.Name = "numericUpDownUnitCostGoodsReceipt";
            this.numericUpDownUnitCostGoodsReceipt.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownUnitCostGoodsReceipt.TabIndex = 7;
            // 
            // numericUpDownGoodsReceipt
            // 
            this.numericUpDownGoodsReceipt.Location = new System.Drawing.Point(436, 101);
            this.numericUpDownGoodsReceipt.Name = "numericUpDownGoodsReceipt";
            this.numericUpDownGoodsReceipt.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownGoodsReceipt.TabIndex = 6;
            // 
            // cbProductGoodsReceipt
            // 
            this.cbProductGoodsReceipt.FormattingEnabled = true;
            this.cbProductGoodsReceipt.Location = new System.Drawing.Point(125, 98);
            this.cbProductGoodsReceipt.Name = "cbProductGoodsReceipt";
            this.cbProductGoodsReceipt.Size = new System.Drawing.Size(149, 27);
            this.cbProductGoodsReceipt.TabIndex = 5;
            // 
            // lbProductGoodsReceipt
            // 
            this.lbProductGoodsReceipt.AutoSize = true;
            this.lbProductGoodsReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbProductGoodsReceipt.Location = new System.Drawing.Point(19, 94);
            this.lbProductGoodsReceipt.Name = "lbProductGoodsReceipt";
            this.lbProductGoodsReceipt.Size = new System.Drawing.Size(100, 31);
            this.lbProductGoodsReceipt.TabIndex = 4;
            this.lbProductGoodsReceipt.Text = "Product";
            // 
            // lbUnitcost
            // 
            this.lbUnitcost.AutoSize = true;
            this.lbUnitcost.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUnitcost.Location = new System.Drawing.Point(582, 94);
            this.lbUnitcost.Name = "lbUnitcost";
            this.lbUnitcost.Size = new System.Drawing.Size(106, 31);
            this.lbUnitcost.TabIndex = 3;
            this.lbUnitcost.Text = "Unitcost";
            // 
            // lbNoteGoodsReceipt
            // 
            this.lbNoteGoodsReceipt.AutoSize = true;
            this.lbNoteGoodsReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNoteGoodsReceipt.Location = new System.Drawing.Point(842, 94);
            this.lbNoteGoodsReceipt.Name = "lbNoteGoodsReceipt";
            this.lbNoteGoodsReceipt.Size = new System.Drawing.Size(67, 31);
            this.lbNoteGoodsReceipt.TabIndex = 2;
            this.lbNoteGoodsReceipt.Text = "Note";
            // 
            // lbQuantityGoodsReceipt
            // 
            this.lbQuantityGoodsReceipt.AutoSize = true;
            this.lbQuantityGoodsReceipt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQuantityGoodsReceipt.Location = new System.Drawing.Point(321, 94);
            this.lbQuantityGoodsReceipt.Name = "lbQuantityGoodsReceipt";
            this.lbQuantityGoodsReceipt.Size = new System.Drawing.Size(109, 31);
            this.lbQuantityGoodsReceipt.TabIndex = 1;
            this.lbQuantityGoodsReceipt.Text = "Quantity";
            // 
            // lbGoodsReceiptAddNewEntry
            // 
            this.lbGoodsReceiptAddNewEntry.AutoSize = true;
            this.lbGoodsReceiptAddNewEntry.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGoodsReceiptAddNewEntry.Location = new System.Drawing.Point(19, 16);
            this.lbGoodsReceiptAddNewEntry.Name = "lbGoodsReceiptAddNewEntry";
            this.lbGoodsReceiptAddNewEntry.Size = new System.Drawing.Size(380, 31);
            this.lbGoodsReceiptAddNewEntry.TabIndex = 0;
            this.lbGoodsReceiptAddNewEntry.Text = "Goods Receipt ▸ Add New Entry";
            // 
            // tabInventoryLog
            // 
            this.tabInventoryLog.Controls.Add(this.pictureBox9);
            this.tabInventoryLog.Controls.Add(this.dataGridViewMovementsInventoryLog);
            this.tabInventoryLog.Controls.Add(this.lbSummary);
            this.tabInventoryLog.Controls.Add(this.btExprotInventoryLog);
            this.tabInventoryLog.Controls.Add(this.btAdjustStockInventoryLog);
            this.tabInventoryLog.Controls.Add(this.lbActionsInventoryLog);
            this.tabInventoryLog.Controls.Add(this.btClearInventory);
            this.tabInventoryLog.Controls.Add(this.btSearchInventoryLog);
            this.tabInventoryLog.Controls.Add(this.lbToInventoryLog);
            this.tabInventoryLog.Controls.Add(this.lbFromInventoryLog);
            this.tabInventoryLog.Controls.Add(this.dateTimePickerToInventoryLog);
            this.tabInventoryLog.Controls.Add(this.dateTimePickerFromInventoryLog);
            this.tabInventoryLog.Controls.Add(this.cbTyleInventoryLog);
            this.tabInventoryLog.Controls.Add(this.cbProductInventoryLog);
            this.tabInventoryLog.Controls.Add(this.lbInventoryLogFilters);
            this.tabInventoryLog.Location = new System.Drawing.Point(4, 28);
            this.tabInventoryLog.Name = "tabInventoryLog";
            this.tabInventoryLog.Size = new System.Drawing.Size(1268, 755);
            this.tabInventoryLog.TabIndex = 5;
            this.tabInventoryLog.Text = "Inventory Log";
            this.tabInventoryLog.UseVisualStyleBackColor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox9.Location = new System.Drawing.Point(1193, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 59);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // dataGridViewMovementsInventoryLog
            // 
            this.dataGridViewMovementsInventoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovementsInventoryLog.Location = new System.Drawing.Point(29, 273);
            this.dataGridViewMovementsInventoryLog.Name = "dataGridViewMovementsInventoryLog";
            this.dataGridViewMovementsInventoryLog.Size = new System.Drawing.Size(1210, 415);
            this.dataGridViewMovementsInventoryLog.TabIndex = 13;
            // 
            // lbSummary
            // 
            this.lbSummary.AutoSize = true;
            this.lbSummary.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSummary.Location = new System.Drawing.Point(856, 210);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(117, 31);
            this.lbSummary.TabIndex = 12;
            this.lbSummary.Text = "Summary";
            // 
            // btExprotInventoryLog
            // 
            this.btExprotInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExprotInventoryLog.Location = new System.Drawing.Point(290, 204);
            this.btExprotInventoryLog.Name = "btExprotInventoryLog";
            this.btExprotInventoryLog.Size = new System.Drawing.Size(224, 42);
            this.btExprotInventoryLog.TabIndex = 11;
            this.btExprotInventoryLog.Text = "Export";
            this.btExprotInventoryLog.UseVisualStyleBackColor = true;
            // 
            // btAdjustStockInventoryLog
            // 
            this.btAdjustStockInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAdjustStockInventoryLog.Location = new System.Drawing.Point(29, 204);
            this.btAdjustStockInventoryLog.Name = "btAdjustStockInventoryLog";
            this.btAdjustStockInventoryLog.Size = new System.Drawing.Size(224, 42);
            this.btAdjustStockInventoryLog.TabIndex = 10;
            this.btAdjustStockInventoryLog.Text = "Adjust Stock";
            this.btAdjustStockInventoryLog.UseVisualStyleBackColor = true;
            // 
            // lbActionsInventoryLog
            // 
            this.lbActionsInventoryLog.AutoSize = true;
            this.lbActionsInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsInventoryLog.Location = new System.Drawing.Point(23, 159);
            this.lbActionsInventoryLog.Name = "lbActionsInventoryLog";
            this.lbActionsInventoryLog.Size = new System.Drawing.Size(104, 31);
            this.lbActionsInventoryLog.TabIndex = 9;
            this.lbActionsInventoryLog.Text = " Actions";
            // 
            // btClearInventory
            // 
            this.btClearInventory.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearInventory.Location = new System.Drawing.Point(1037, 75);
            this.btClearInventory.Name = "btClearInventory";
            this.btClearInventory.Size = new System.Drawing.Size(111, 39);
            this.btClearInventory.TabIndex = 8;
            this.btClearInventory.Text = "Clear";
            this.btClearInventory.UseVisualStyleBackColor = true;
            // 
            // btSearchInventoryLog
            // 
            this.btSearchInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchInventoryLog.Location = new System.Drawing.Point(887, 75);
            this.btSearchInventoryLog.Name = "btSearchInventoryLog";
            this.btSearchInventoryLog.Size = new System.Drawing.Size(111, 39);
            this.btSearchInventoryLog.TabIndex = 7;
            this.btSearchInventoryLog.Text = "Search";
            this.btSearchInventoryLog.UseVisualStyleBackColor = true;
            // 
            // lbToInventoryLog
            // 
            this.lbToInventoryLog.AutoSize = true;
            this.lbToInventoryLog.Location = new System.Drawing.Point(657, 85);
            this.lbToInventoryLog.Name = "lbToInventoryLog";
            this.lbToInventoryLog.Size = new System.Drawing.Size(25, 19);
            this.lbToInventoryLog.TabIndex = 6;
            this.lbToInventoryLog.Text = "To";
            // 
            // lbFromInventoryLog
            // 
            this.lbFromInventoryLog.AutoSize = true;
            this.lbFromInventoryLog.Location = new System.Drawing.Point(394, 85);
            this.lbFromInventoryLog.Name = "lbFromInventoryLog";
            this.lbFromInventoryLog.Size = new System.Drawing.Size(42, 19);
            this.lbFromInventoryLog.TabIndex = 5;
            this.lbFromInventoryLog.Text = "From";
            // 
            // dateTimePickerToInventoryLog
            // 
            this.dateTimePickerToInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerToInventoryLog.Location = new System.Drawing.Point(688, 73);
            this.dateTimePickerToInventoryLog.Name = "dateTimePickerToInventoryLog";
            this.dateTimePickerToInventoryLog.Size = new System.Drawing.Size(160, 39);
            this.dateTimePickerToInventoryLog.TabIndex = 4;
            // 
            // dateTimePickerFromInventoryLog
            // 
            this.dateTimePickerFromInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerFromInventoryLog.Location = new System.Drawing.Point(452, 73);
            this.dateTimePickerFromInventoryLog.Name = "dateTimePickerFromInventoryLog";
            this.dateTimePickerFromInventoryLog.Size = new System.Drawing.Size(171, 39);
            this.dateTimePickerFromInventoryLog.TabIndex = 3;
            // 
            // cbTyleInventoryLog
            // 
            this.cbTyleInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTyleInventoryLog.FormattingEnabled = true;
            this.cbTyleInventoryLog.Location = new System.Drawing.Point(216, 73);
            this.cbTyleInventoryLog.Name = "cbTyleInventoryLog";
            this.cbTyleInventoryLog.Size = new System.Drawing.Size(142, 39);
            this.cbTyleInventoryLog.TabIndex = 2;
            // 
            // cbProductInventoryLog
            // 
            this.cbProductInventoryLog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbProductInventoryLog.FormattingEnabled = true;
            this.cbProductInventoryLog.Location = new System.Drawing.Point(29, 73);
            this.cbProductInventoryLog.Name = "cbProductInventoryLog";
            this.cbProductInventoryLog.Size = new System.Drawing.Size(154, 39);
            this.cbProductInventoryLog.TabIndex = 1;
            // 
            // lbInventoryLogFilters
            // 
            this.lbInventoryLogFilters.AutoSize = true;
            this.lbInventoryLogFilters.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInventoryLogFilters.Location = new System.Drawing.Point(23, 15);
            this.lbInventoryLogFilters.Name = "lbInventoryLogFilters";
            this.lbInventoryLogFilters.Size = new System.Drawing.Size(283, 31);
            this.lbInventoryLogFilters.TabIndex = 0;
            this.lbInventoryLogFilters.Text = "Inventory Log ▸ Filters  ";
            this.lbInventoryLogFilters.Click += new System.EventHandler(this.lbInventoryLogFilters_Click);
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.pictureBox10);
            this.tabReports.Controls.Add(this.btSearchReport);
            this.tabReports.Controls.Add(this.dataGridViewReport);
            this.tabReports.Controls.Add(this.lbChartViewReport);
            this.tabReports.Controls.Add(this.chartReport);
            this.tabReports.Controls.Add(this.dateTimePickerToReport);
            this.tabReports.Controls.Add(this.dateTimePickerFromReport);
            this.tabReports.Controls.Add(this.lbToReport);
            this.tabReports.Controls.Add(this.lbFromReport);
            this.tabReports.Controls.Add(this.cbReport);
            this.tabReports.Controls.Add(this.lbReportsType);
            this.tabReports.Controls.Add(this.lbReportsFilters);
            this.tabReports.Location = new System.Drawing.Point(4, 28);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1268, 755);
            this.tabReports.TabIndex = 10;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox10.Location = new System.Drawing.Point(1159, 13);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 69);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // btSearchReport
            // 
            this.btSearchReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchReport.Location = new System.Drawing.Point(1063, 92);
            this.btSearchReport.Name = "btSearchReport";
            this.btSearchReport.Size = new System.Drawing.Size(153, 39);
            this.btSearchReport.TabIndex = 10;
            this.btSearchReport.Text = "Search";
            this.btSearchReport.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(80, 535);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(1136, 174);
            this.dataGridViewReport.TabIndex = 9;
            // 
            // lbChartViewReport
            // 
            this.lbChartViewReport.AutoSize = true;
            this.lbChartViewReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChartViewReport.Location = new System.Drawing.Point(74, 214);
            this.lbChartViewReport.Name = "lbChartViewReport";
            this.lbChartViewReport.Size = new System.Drawing.Size(137, 31);
            this.lbChartViewReport.TabIndex = 8;
            this.lbChartViewReport.Text = "Chart View";
            // 
            // chartReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(78, 258);
            this.chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(725, 215);
            this.chartReport.TabIndex = 7;
            this.chartReport.Text = "chart1";
            // 
            // dateTimePickerToReport
            // 
            this.dateTimePickerToReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerToReport.Location = new System.Drawing.Point(865, 94);
            this.dateTimePickerToReport.Name = "dateTimePickerToReport";
            this.dateTimePickerToReport.Size = new System.Drawing.Size(159, 39);
            this.dateTimePickerToReport.TabIndex = 6;
            // 
            // dateTimePickerFromReport
            // 
            this.dateTimePickerFromReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerFromReport.Location = new System.Drawing.Point(617, 97);
            this.dateTimePickerFromReport.Name = "dateTimePickerFromReport";
            this.dateTimePickerFromReport.Size = new System.Drawing.Size(159, 39);
            this.dateTimePickerFromReport.TabIndex = 5;
            // 
            // lbToReport
            // 
            this.lbToReport.AutoSize = true;
            this.lbToReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbToReport.Location = new System.Drawing.Point(817, 100);
            this.lbToReport.Name = "lbToReport";
            this.lbToReport.Size = new System.Drawing.Size(42, 31);
            this.lbToReport.TabIndex = 4;
            this.lbToReport.Text = "To";
            // 
            // lbFromReport
            // 
            this.lbFromReport.AutoSize = true;
            this.lbFromReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFromReport.Location = new System.Drawing.Point(539, 100);
            this.lbFromReport.Name = "lbFromReport";
            this.lbFromReport.Size = new System.Drawing.Size(72, 31);
            this.lbFromReport.TabIndex = 3;
            this.lbFromReport.Text = "From";
            // 
            // cbReport
            // 
            this.cbReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(268, 100);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(121, 39);
            this.cbReport.TabIndex = 2;
            // 
            // lbReportsType
            // 
            this.lbReportsType.AutoSize = true;
            this.lbReportsType.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReportsType.Location = new System.Drawing.Point(74, 100);
            this.lbReportsType.Name = "lbReportsType";
            this.lbReportsType.Size = new System.Drawing.Size(159, 31);
            this.lbReportsType.TabIndex = 1;
            this.lbReportsType.Text = "Reports Type";
            // 
            // lbReportsFilters
            // 
            this.lbReportsFilters.AutoSize = true;
            this.lbReportsFilters.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReportsFilters.Location = new System.Drawing.Point(72, 30);
            this.lbReportsFilters.Name = "lbReportsFilters";
            this.lbReportsFilters.Size = new System.Drawing.Size(222, 31);
            this.lbReportsFilters.TabIndex = 0;
            this.lbReportsFilters.Text = "Reports ▸ Filters   ";
            // 
            // tabUserAccounts
            // 
            this.tabUserAccounts.Controls.Add(this.pictureBox11);
            this.tabUserAccounts.Controls.Add(this.dataGridViewUserAccounts);
            this.tabUserAccounts.Controls.Add(this.btLockUnLock);
            this.tabUserAccounts.Controls.Add(this.btExportUser);
            this.tabUserAccounts.Controls.Add(this.lbCountUser);
            this.tabUserAccounts.Controls.Add(this.btEditUser);
            this.tabUserAccounts.Controls.Add(this.btDeleteUser);
            this.tabUserAccounts.Controls.Add(this.btResetPasswordUser);
            this.tabUserAccounts.Controls.Add(this.btAddUser);
            this.tabUserAccounts.Controls.Add(this.lbActionsUser);
            this.tabUserAccounts.Controls.Add(this.btClearUser);
            this.tabUserAccounts.Controls.Add(this.btSearchUser);
            this.tabUserAccounts.Controls.Add(this.cbRoleUser);
            this.tabUserAccounts.Controls.Add(this.txtSearchUser);
            this.tabUserAccounts.Controls.Add(this.lbUserAccounts);
            this.tabUserAccounts.Location = new System.Drawing.Point(4, 28);
            this.tabUserAccounts.Name = "tabUserAccounts";
            this.tabUserAccounts.Size = new System.Drawing.Size(1268, 755);
            this.tabUserAccounts.TabIndex = 7;
            this.tabUserAccounts.Text = "User Accounts";
            this.tabUserAccounts.UseVisualStyleBackColor = true;
            this.tabUserAccounts.Click += new System.EventHandler(this.tabUserAccounts_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox11.Location = new System.Drawing.Point(1174, 31);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(54, 80);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 15;
            this.pictureBox11.TabStop = false;
            // 
            // dataGridViewUserAccounts
            // 
            this.dataGridViewUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserAccounts.Location = new System.Drawing.Point(30, 333);
            this.dataGridViewUserAccounts.Name = "dataGridViewUserAccounts";
            this.dataGridViewUserAccounts.Size = new System.Drawing.Size(1186, 380);
            this.dataGridViewUserAccounts.TabIndex = 14;
            // 
            // btLockUnLock
            // 
            this.btLockUnLock.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLockUnLock.Location = new System.Drawing.Point(668, 240);
            this.btLockUnLock.Name = "btLockUnLock";
            this.btLockUnLock.Size = new System.Drawing.Size(229, 43);
            this.btLockUnLock.TabIndex = 13;
            this.btLockUnLock.Text = "Lock / Unlock";
            this.btLockUnLock.UseVisualStyleBackColor = true;
            // 
            // btExportUser
            // 
            this.btExportUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportUser.Location = new System.Drawing.Point(916, 240);
            this.btExportUser.Name = "btExportUser";
            this.btExportUser.Size = new System.Drawing.Size(135, 43);
            this.btExportUser.TabIndex = 12;
            this.btExportUser.Text = "Export";
            this.btExportUser.UseVisualStyleBackColor = true;
            // 
            // lbCountUser
            // 
            this.lbCountUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountUser.Location = new System.Drawing.Point(1081, 240);
            this.lbCountUser.Name = "lbCountUser";
            this.lbCountUser.Size = new System.Drawing.Size(135, 43);
            this.lbCountUser.TabIndex = 11;
            this.lbCountUser.Text = "Count";
            this.lbCountUser.UseVisualStyleBackColor = true;
            // 
            // btEditUser
            // 
            this.btEditUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEditUser.Location = new System.Drawing.Point(188, 240);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(135, 43);
            this.btEditUser.TabIndex = 10;
            this.btEditUser.Text = "Edit";
            this.btEditUser.UseVisualStyleBackColor = true;
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDeleteUser.Location = new System.Drawing.Point(349, 240);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(135, 43);
            this.btDeleteUser.TabIndex = 9;
            this.btDeleteUser.Text = "Delete";
            this.btDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btResetPasswordUser
            // 
            this.btResetPasswordUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btResetPasswordUser.Location = new System.Drawing.Point(511, 240);
            this.btResetPasswordUser.Name = "btResetPasswordUser";
            this.btResetPasswordUser.Size = new System.Drawing.Size(135, 43);
            this.btResetPasswordUser.TabIndex = 8;
            this.btResetPasswordUser.Text = "Rest Passwrod";
            this.btResetPasswordUser.UseVisualStyleBackColor = true;
            this.btResetPasswordUser.Click += new System.EventHandler(this.btResetPasswordUser_Click);
            // 
            // btAddUser
            // 
            this.btAddUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddUser.Location = new System.Drawing.Point(30, 240);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(135, 43);
            this.btAddUser.TabIndex = 6;
            this.btAddUser.Text = "Add";
            this.btAddUser.UseVisualStyleBackColor = true;
            // 
            // lbActionsUser
            // 
            this.lbActionsUser.AutoSize = true;
            this.lbActionsUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsUser.Location = new System.Drawing.Point(24, 182);
            this.lbActionsUser.Name = "lbActionsUser";
            this.lbActionsUser.Size = new System.Drawing.Size(105, 31);
            this.lbActionsUser.TabIndex = 5;
            this.lbActionsUser.Text = "Actions ";
            // 
            // btClearUser
            // 
            this.btClearUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearUser.Location = new System.Drawing.Point(815, 87);
            this.btClearUser.Name = "btClearUser";
            this.btClearUser.Size = new System.Drawing.Size(152, 39);
            this.btClearUser.TabIndex = 4;
            this.btClearUser.Text = "Clear";
            this.btClearUser.UseVisualStyleBackColor = true;
            // 
            // btSearchUser
            // 
            this.btSearchUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchUser.Location = new System.Drawing.Point(569, 88);
            this.btSearchUser.Name = "btSearchUser";
            this.btSearchUser.Size = new System.Drawing.Size(152, 39);
            this.btSearchUser.TabIndex = 3;
            this.btSearchUser.Text = "Search";
            this.btSearchUser.UseVisualStyleBackColor = true;
            // 
            // cbRoleUser
            // 
            this.cbRoleUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbRoleUser.FormattingEnabled = true;
            this.cbRoleUser.Location = new System.Drawing.Point(349, 88);
            this.cbRoleUser.Name = "cbRoleUser";
            this.cbRoleUser.Size = new System.Drawing.Size(171, 39);
            this.cbRoleUser.TabIndex = 2;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchUser.Location = new System.Drawing.Point(30, 88);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(262, 39);
            this.txtSearchUser.TabIndex = 1;
            // 
            // lbUserAccounts
            // 
            this.lbUserAccounts.AutoSize = true;
            this.lbUserAccounts.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserAccounts.Location = new System.Drawing.Point(24, 26);
            this.lbUserAccounts.Name = "lbUserAccounts";
            this.lbUserAccounts.Size = new System.Drawing.Size(396, 31);
            this.lbUserAccounts.TabIndex = 0;
            this.lbUserAccounts.Text = "User Accounts ▸ Search | Actions  ";
            // 
            // tabRoles
            // 
            this.tabRoles.Controls.Add(this.pictureBox12);
            this.tabRoles.Controls.Add(this.dataGridViewRole);
            this.tabRoles.Controls.Add(this.lbCountRole);
            this.tabRoles.Controls.Add(this.btExportRole);
            this.tabRoles.Controls.Add(this.btDeleteRole);
            this.tabRoles.Controls.Add(this.btEditRole);
            this.tabRoles.Controls.Add(this.btAddRole);
            this.tabRoles.Controls.Add(this.lbActionsRole);
            this.tabRoles.Controls.Add(this.btClearRole);
            this.tabRoles.Controls.Add(this.btSearchRole);
            this.tabRoles.Controls.Add(this.txtKeywordRole);
            this.tabRoles.Controls.Add(this.lbRole);
            this.tabRoles.Location = new System.Drawing.Point(4, 28);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Size = new System.Drawing.Size(1268, 755);
            this.tabRoles.TabIndex = 8;
            this.tabRoles.Text = "Roles";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox12.Location = new System.Drawing.Point(1155, 20);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(75, 93);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRole.Location = new System.Drawing.Point(31, 304);
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.Size = new System.Drawing.Size(1170, 372);
            this.dataGridViewRole.TabIndex = 10;
            // 
            // lbCountRole
            // 
            this.lbCountRole.AutoSize = true;
            this.lbCountRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountRole.Location = new System.Drawing.Point(802, 232);
            this.lbCountRole.Name = "lbCountRole";
            this.lbCountRole.Size = new System.Drawing.Size(82, 31);
            this.lbCountRole.TabIndex = 9;
            this.lbCountRole.Text = "Count";
            // 
            // btExportRole
            // 
            this.btExportRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExportRole.Location = new System.Drawing.Point(564, 227);
            this.btExportRole.Name = "btExportRole";
            this.btExportRole.Size = new System.Drawing.Size(127, 41);
            this.btExportRole.TabIndex = 8;
            this.btExportRole.Text = "Export";
            this.btExportRole.UseVisualStyleBackColor = true;
            // 
            // btDeleteRole
            // 
            this.btDeleteRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDeleteRole.Location = new System.Drawing.Point(374, 227);
            this.btDeleteRole.Name = "btDeleteRole";
            this.btDeleteRole.Size = new System.Drawing.Size(127, 41);
            this.btDeleteRole.TabIndex = 7;
            this.btDeleteRole.Text = "Delete";
            this.btDeleteRole.UseVisualStyleBackColor = true;
            // 
            // btEditRole
            // 
            this.btEditRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEditRole.Location = new System.Drawing.Point(205, 227);
            this.btEditRole.Name = "btEditRole";
            this.btEditRole.Size = new System.Drawing.Size(127, 41);
            this.btEditRole.TabIndex = 6;
            this.btEditRole.Text = "Edit";
            this.btEditRole.UseVisualStyleBackColor = true;
            // 
            // btAddRole
            // 
            this.btAddRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddRole.Location = new System.Drawing.Point(31, 227);
            this.btAddRole.Name = "btAddRole";
            this.btAddRole.Size = new System.Drawing.Size(127, 41);
            this.btAddRole.TabIndex = 5;
            this.btAddRole.Text = "Add";
            this.btAddRole.UseVisualStyleBackColor = true;
            // 
            // lbActionsRole
            // 
            this.lbActionsRole.AutoSize = true;
            this.lbActionsRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActionsRole.Location = new System.Drawing.Point(25, 159);
            this.lbActionsRole.Name = "lbActionsRole";
            this.lbActionsRole.Size = new System.Drawing.Size(98, 31);
            this.lbActionsRole.TabIndex = 4;
            this.lbActionsRole.Text = "Actions";
            // 
            // btClearRole
            // 
            this.btClearRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClearRole.Location = new System.Drawing.Point(673, 75);
            this.btClearRole.Name = "btClearRole";
            this.btClearRole.Size = new System.Drawing.Size(177, 39);
            this.btClearRole.TabIndex = 3;
            this.btClearRole.Text = "Clear";
            this.btClearRole.UseVisualStyleBackColor = true;
            // 
            // btSearchRole
            // 
            this.btSearchRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchRole.Location = new System.Drawing.Point(424, 75);
            this.btSearchRole.Name = "btSearchRole";
            this.btSearchRole.Size = new System.Drawing.Size(177, 39);
            this.btSearchRole.TabIndex = 2;
            this.btSearchRole.Text = "Search";
            this.btSearchRole.UseVisualStyleBackColor = true;
            // 
            // txtKeywordRole
            // 
            this.txtKeywordRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKeywordRole.Location = new System.Drawing.Point(31, 75);
            this.txtKeywordRole.Name = "txtKeywordRole";
            this.txtKeywordRole.Size = new System.Drawing.Size(301, 39);
            this.txtKeywordRole.TabIndex = 1;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRole.Location = new System.Drawing.Point(25, 22);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(321, 31);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Roles ▸ Manage User Roles";
            // 
            // tabBackupRestore
            // 
            this.tabBackupRestore.Controls.Add(this.pictureBox13);
            this.tabBackupRestore.Controls.Add(this.listboxLogWindow);
            this.tabBackupRestore.Controls.Add(this.txtRestore);
            this.tabBackupRestore.Controls.Add(this.lbRestoreDatabase);
            this.tabBackupRestore.Controls.Add(this.btRestoreData);
            this.tabBackupRestore.Controls.Add(this.btBrowseRestore);
            this.tabBackupRestore.Controls.Add(this.btBackupData);
            this.tabBackupRestore.Controls.Add(this.btBrowseBackup);
            this.tabBackupRestore.Controls.Add(this.txtBackupPath);
            this.tabBackupRestore.Controls.Add(this.lbBackupDatabase);
            this.tabBackupRestore.Location = new System.Drawing.Point(4, 28);
            this.tabBackupRestore.Name = "tabBackupRestore";
            this.tabBackupRestore.Size = new System.Drawing.Size(1268, 755);
            this.tabBackupRestore.TabIndex = 11;
            this.tabBackupRestore.Text = "Backup & Restore";
            this.tabBackupRestore.UseVisualStyleBackColor = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::ShopX.Properties.Resources._6aafa168_5125_41dd_9204_5ccbfd2e9f4b;
            this.pictureBox13.Location = new System.Drawing.Point(1079, 23);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(121, 163);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 9;
            this.pictureBox13.TabStop = false;
            // 
            // listboxLogWindow
            // 
            this.listboxLogWindow.FormattingEnabled = true;
            this.listboxLogWindow.ItemHeight = 19;
            this.listboxLogWindow.Location = new System.Drawing.Point(32, 379);
            this.listboxLogWindow.Name = "listboxLogWindow";
            this.listboxLogWindow.Size = new System.Drawing.Size(864, 308);
            this.listboxLogWindow.TabIndex = 8;
            // 
            // txtRestore
            // 
            this.txtRestore.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRestore.Location = new System.Drawing.Point(32, 300);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(326, 39);
            this.txtRestore.TabIndex = 7;
            // 
            // lbRestoreDatabase
            // 
            this.lbRestoreDatabase.AutoSize = true;
            this.lbRestoreDatabase.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRestoreDatabase.Location = new System.Drawing.Point(26, 219);
            this.lbRestoreDatabase.Name = "lbRestoreDatabase";
            this.lbRestoreDatabase.Size = new System.Drawing.Size(203, 31);
            this.lbRestoreDatabase.TabIndex = 6;
            this.lbRestoreDatabase.Text = "Restore Database";
            this.lbRestoreDatabase.Click += new System.EventHandler(this.lbRestoreDatabase_Click);
            // 
            // btRestoreData
            // 
            this.btRestoreData.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRestoreData.Location = new System.Drawing.Point(660, 300);
            this.btRestoreData.Name = "btRestoreData";
            this.btRestoreData.Size = new System.Drawing.Size(183, 39);
            this.btRestoreData.TabIndex = 5;
            this.btRestoreData.Text = "Restore";
            this.btRestoreData.UseVisualStyleBackColor = true;
            // 
            // btBrowseRestore
            // 
            this.btBrowseRestore.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBrowseRestore.Location = new System.Drawing.Point(405, 300);
            this.btBrowseRestore.Name = "btBrowseRestore";
            this.btBrowseRestore.Size = new System.Drawing.Size(183, 39);
            this.btBrowseRestore.TabIndex = 4;
            this.btBrowseRestore.Text = "Browse";
            this.btBrowseRestore.UseVisualStyleBackColor = true;
            // 
            // btBackupData
            // 
            this.btBackupData.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBackupData.Location = new System.Drawing.Point(660, 99);
            this.btBackupData.Name = "btBackupData";
            this.btBackupData.Size = new System.Drawing.Size(183, 39);
            this.btBackupData.TabIndex = 3;
            this.btBackupData.Text = "Backup";
            this.btBackupData.UseVisualStyleBackColor = true;
            // 
            // btBrowseBackup
            // 
            this.btBrowseBackup.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBrowseBackup.Location = new System.Drawing.Point(405, 100);
            this.btBrowseBackup.Name = "btBrowseBackup";
            this.btBrowseBackup.Size = new System.Drawing.Size(183, 39);
            this.btBrowseBackup.TabIndex = 2;
            this.btBrowseBackup.Text = "Browse";
            this.btBrowseBackup.UseVisualStyleBackColor = true;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBackupPath.Location = new System.Drawing.Point(32, 100);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(326, 39);
            this.txtBackupPath.TabIndex = 1;
            // 
            // lbBackupDatabase
            // 
            this.lbBackupDatabase.AutoSize = true;
            this.lbBackupDatabase.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBackupDatabase.Location = new System.Drawing.Point(26, 23);
            this.lbBackupDatabase.Name = "lbBackupDatabase";
            this.lbBackupDatabase.Size = new System.Drawing.Size(203, 31);
            this.lbBackupDatabase.TabIndex = 0;
            this.lbBackupDatabase.Text = "Backup Database";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 787);
            this.Controls.Add(this.tabControl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grBoxHome.ResumeLayout(false);
            this.tabManageEmployees.ResumeLayout(false);
            this.tabManageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabManageCustomers.ResumeLayout(false);
            this.tabManageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.tabManageProducts.ResumeLayout(false);
            this.tabManageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxManageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinManageProduct)).EndInit();
            this.tabManageOrders.ResumeLayout(false);
            this.tabManageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderMaster)).EndInit();
            this.tabManageOrderDetails.ResumeLayout(false);
            this.tabManageOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageOrderDetails)).EndInit();
            this.tabGoodReceipt.ResumeLayout(false);
            this.tabGoodReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitCostGoodsReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodsReceipt)).EndInit();
            this.tabInventoryLog.ResumeLayout(false);
            this.tabInventoryLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovementsInventoryLog)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.tabUserAccounts.ResumeLayout(false);
            this.tabUserAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAccounts)).EndInit();
            this.tabRoles.ResumeLayout(false);
            this.tabRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.tabBackupRestore.ResumeLayout(false);
            this.tabBackupRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);

        }

        private void btResetPasswordUser_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabManageProducts;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabManageCustomers;
        private System.Windows.Forms.TabPage tabManageOrders;
        private System.Windows.Forms.TabPage tabGoodReceipt;
        private System.Windows.Forms.TabPage tabInventoryLog;
        private System.Windows.Forms.TabPage tabManageEmployees;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabUserAccounts;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabBackupRestore;
        private System.Windows.Forms.TabPage tabManageOrderDetails;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbLowStock;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbOrderToDay;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbCustomers;
        private System.Windows.Forms.Label lbQuickActions;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btReports;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btCreateOrder;
        private System.Windows.Forms.GroupBox grBoxHome;
        private System.Windows.Forms.ListBox listBoxHome;
        private System.Windows.Forms.Label lbCountEmployees;
        private System.Windows.Forms.Label lbStatusEmployees;
        private System.Windows.Forms.Label lbActionsEmployees;
        private System.Windows.Forms.Label lbEmployeesSearch;
        private System.Windows.Forms.Button btClearEmployees;
        private System.Windows.Forms.Button btSearchEmployees;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtKeyWordEmployees;
        private System.Windows.Forms.Button btDeleteEmployees;
        private System.Windows.Forms.Button btEditEmployees;
        private System.Windows.Forms.Button btExportEmployees;
        private System.Windows.Forms.Button btAddEmployees;
        private System.Windows.Forms.Label lbTipEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox txtCurrentUserRoleEmployees;
        private System.Windows.Forms.TextBox txtKeyWordCustomer;
        private System.Windows.Forms.Label lbCustomersSearchFilters;
        private System.Windows.Forms.Button btClearCustomer;
        private System.Windows.Forms.Button btSearchCustomer;
        private System.Windows.Forms.Button btExportCustomer;
        private System.Windows.Forms.Button btDeleteCustomer;
        private System.Windows.Forms.Button btEditCustomer;
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.Label lbActionsCustomer;
        private System.Windows.Forms.Label lbCountCustomer;
        private System.Windows.Forms.Label lbTipCustomer;
        private System.Windows.Forms.TextBox txtStatusManageCustomer;
        private System.Windows.Forms.Label lbStatusCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button btExportCategories;
        private System.Windows.Forms.Button btDeleteCategories;
        private System.Windows.Forms.Button btEditCategories;
        private System.Windows.Forms.Button btAddCategories;
        private System.Windows.Forms.Button btClearCategories;
        private System.Windows.Forms.Button btSearchCategories;
        private System.Windows.Forms.TextBox txtKeywordCategories;
        private System.Windows.Forms.Label lbCountCategories;
        private System.Windows.Forms.Label lbTipCategories;
        private System.Windows.Forms.Label lbActionsCategories;
        private System.Windows.Forms.Label lbCategoriesSearch;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxManageProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownMinManageProduct;
        private System.Windows.Forms.ComboBox cbManageProduct;
        private System.Windows.Forms.TextBox txtKeyWordManageProduct;
        private System.Windows.Forms.Label lbProductsSearchFilters;
        private System.Windows.Forms.Label lbMaxPrice;
        private System.Windows.Forms.Label lbMinPrice;
        private System.Windows.Forms.Label lbTipManageProduct;
        private System.Windows.Forms.Label lbActionsProduct;
        private System.Windows.Forms.Button btClearProduct;
        private System.Windows.Forms.Button btSearchProduct;
        private System.Windows.Forms.Button btExportManageProduct;
        private System.Windows.Forms.Button btImageManageProduct;
        private System.Windows.Forms.Button btDeleteManageDelete;
        private System.Windows.Forms.Button btEditManageProduct;
        private System.Windows.Forms.Button btAddManageProduct;
        private System.Windows.Forms.Label lbCountManageProduct;
        private System.Windows.Forms.Button btImportManageProduct;
        private System.Windows.Forms.DataGridView dataGridViewManageProduct;
        private System.Windows.Forms.ComboBox cbStatusManageOrder;
        private System.Windows.Forms.TextBox txtManageOrderId;
        private System.Windows.Forms.Label lbActionsManageOrder;
        private System.Windows.Forms.Label lbOrderSearchFilters;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btSearchManageOrder;
        private System.Windows.Forms.ComboBox cbCustomerManageOrder;
        private System.Windows.Forms.Label lbToManageOrder;
        private System.Windows.Forms.Label lbFromManageOrder;
        private System.Windows.Forms.Button btRefundManageOrder;
        private System.Windows.Forms.Button btExportManageOrder;
        private System.Windows.Forms.Button btCancelManageOrder;
        private System.Windows.Forms.Button btPrintManageOrder;
        private System.Windows.Forms.Button btRefreshManageOrder;
        private System.Windows.Forms.Button btViewEditManageOrder;
        private System.Windows.Forms.Button btNewOrderManageOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderMaster;
        private System.Windows.Forms.Label lbFromManageOrderDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerToManageOrderDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromManageOrderDetails;
        private System.Windows.Forms.TextBox txtProductNameManageOrderDetails;
        private System.Windows.Forms.TextBox txtOrderIDManageOrderDetails;
        private System.Windows.Forms.Label lbOrderDetailsSearchFilters;
        private System.Windows.Forms.Label lbToManageOrderDetails;
        private System.Windows.Forms.Button btSearchManageOrderDetails;
        private System.Windows.Forms.Label lbActionsManageOrderDetails;
        private System.Windows.Forms.Button btExportManageOrderDetails;
        private System.Windows.Forms.Button btRefreshManageOrderDetails;
        private System.Windows.Forms.TextBox txtTotalRowsManageOrderDetails;
        private System.Windows.Forms.Label lbTotalQuantityManageOrderDetails;
        private System.Windows.Forms.DataGridView dataGridViewManageOrderDetails;
        private System.Windows.Forms.Label lbCountManageOrderDetails;
        private System.Windows.Forms.Label lbTotalQuantity;
        private System.Windows.Forms.TextBox txtTotalQuantityManageOrderDetails;
        private System.Windows.Forms.Label lbTotalSalesManageDetails;
        private System.Windows.Forms.TextBox txtTotalSaleManageDetails;
        private System.Windows.Forms.Label lbGoodsReceiptAddNewEntry;
        private System.Windows.Forms.NumericUpDown numericUpDownUnitCostGoodsReceipt;
        private System.Windows.Forms.NumericUpDown numericUpDownGoodsReceipt;
        private System.Windows.Forms.ComboBox cbProductGoodsReceipt;
        private System.Windows.Forms.Label lbProductGoodsReceipt;
        private System.Windows.Forms.Label lbUnitcost;
        private System.Windows.Forms.Label lbNoteGoodsReceipt;
        private System.Windows.Forms.Label lbQuantityGoodsReceipt;
        private System.Windows.Forms.Button btAddReceipt;
        private System.Windows.Forms.TextBox txtNoteGoodsReceipt;
        private System.Windows.Forms.Label lbReceiptsHistory;
        private System.Windows.Forms.DataGridView dataGridViewGoodsReceipt;
        private System.Windows.Forms.Button btClearGoodReceipt;
        private System.Windows.Forms.Button btSearchGoodsReceipt;
        private System.Windows.Forms.Label lbToGoodsReceipt;
        private System.Windows.Forms.Label lbFromGoodsReceipt;
        private System.Windows.Forms.DateTimePicker dateTimePickerToGoodReceipt;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromGoodReceipt;
        private System.Windows.Forms.TextBox lbTotalQuantityGoodReceipt;
        private System.Windows.Forms.TextBox txtTotalReceipt;
        private System.Windows.Forms.Label lbTotalQuantityTotalReceipt;
        private System.Windows.Forms.Label lbSummaryTotalReceipts;
        private System.Windows.Forms.ComboBox cbProductInventoryLog;
        private System.Windows.Forms.Label lbInventoryLogFilters;
        private System.Windows.Forms.ComboBox cbTyleInventoryLog;
        private System.Windows.Forms.DateTimePicker dateTimePickerToInventoryLog;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromInventoryLog;
        private System.Windows.Forms.Label lbToInventoryLog;
        private System.Windows.Forms.Label lbFromInventoryLog;
        private System.Windows.Forms.Button btClearInventory;
        private System.Windows.Forms.Button btSearchInventoryLog;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Button btExprotInventoryLog;
        private System.Windows.Forms.Button btAdjustStockInventoryLog;
        private System.Windows.Forms.Label lbActionsInventoryLog;
        private System.Windows.Forms.DataGridView dataGridViewMovementsInventoryLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerToReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromReport;
        private System.Windows.Forms.Label lbToReport;
        private System.Windows.Forms.Label lbFromReport;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.Label lbReportsType;
        private System.Windows.Forms.Label lbReportsFilters;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label lbChartViewReport;
        private System.Windows.Forms.Button btSearchReport;
        private System.Windows.Forms.Label lbUserAccounts;
        private System.Windows.Forms.Button btEditUser;
        private System.Windows.Forms.Button btDeleteUser;
        private System.Windows.Forms.Button btResetPasswordUser;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Label lbActionsUser;
        private System.Windows.Forms.Button btClearUser;
        private System.Windows.Forms.Button btSearchUser;
        private System.Windows.Forms.ComboBox cbRoleUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btLockUnLock;
        private System.Windows.Forms.Button btExportUser;
        private System.Windows.Forms.Button lbCountUser;
        private System.Windows.Forms.DataGridView dataGridViewUserAccounts;
        private System.Windows.Forms.Button btClearRole;
        private System.Windows.Forms.Button btSearchRole;
        private System.Windows.Forms.TextBox txtKeywordRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbActionsRole;
        private System.Windows.Forms.DataGridView dataGridViewRole;
        private System.Windows.Forms.Label lbCountRole;
        private System.Windows.Forms.Button btExportRole;
        private System.Windows.Forms.Button btDeleteRole;
        private System.Windows.Forms.Button btEditRole;
        private System.Windows.Forms.Button btAddRole;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label lbBackupDatabase;
        private System.Windows.Forms.ListBox listboxLogWindow;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label lbRestoreDatabase;
        private System.Windows.Forms.Button btRestoreData;
        private System.Windows.Forms.Button btBrowseRestore;
        private System.Windows.Forms.Button btBackupData;
        private System.Windows.Forms.Button btBrowseBackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.TextBox txtCustomersHome;
        private System.Windows.Forms.TextBox txtLowStock;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.TextBox txtOrderToday;
    }
}