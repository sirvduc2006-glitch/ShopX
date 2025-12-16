using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShopX
{
    public partial class Form2 : Form
    {
        // --- FIELDS & CONSTRUCTOR ---
        private readonly AppUser _currentUser;
        private readonly List<TabPage> _allTabs = new List<TabPage>();

        public Form2(AppUser currentUser)
        {
            InitializeComponent();
            InitializeButtonEvents();
            _currentUser = currentUser;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Text = $"ShopX - {_currentUser.UserName} ({_currentUser.Role})";

            SetupDashboardUI();

            if (_allTabs.Count == 0)
            {
                foreach (TabPage tab in tabControl.TabPages) _allTabs.Add(tab);
            }

            ApplyPermissions(_currentUser.Role);

            if (DatabaseHelper.TestConnection())
            {
                this.Text += " [Connected]";

                DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime today = DateTime.Now;

                dateTimePickerFrom.Value = firstDay;
                dateTimePickerTo.Value = today;
                dateTimePickerFromManageOrderDetails.Value = firstDay;
                dateTimePickerToManageOrderDetails.Value = today;
                dateTimePickerFromGoodReceipt.Value = firstDay;
                dateTimePickerToGoodReceipt.Value = today;
                dateTimePickerFromInventoryLog.Value = firstDay;
                dateTimePickerToInventoryLog.Value = today;
                dateTimePickerFromReport.Value = firstDay.AddMonths(-1);
                dateTimePickerToReport.Value = today;

                LoadHomeData();
                LoadAllData();
                LoadAllComboBoxes();
            }
        }
        private Timer _dashboardTimer;

        private void SetupDashboardUI()
        {
            try
            {
                
                if (lbWelcome != null)
                {
                    
                    lbWelcome.Text = $"Welcome: {_currentUser.UserName}";
                }

                
                if (lbTime != null)
                {

                    lbTime.Text = $"Time: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";


                    if (_dashboardTimer == null)
                    {
                        _dashboardTimer = new Timer();
                        _dashboardTimer.Interval = 1000;
                        _dashboardTimer.Tick += (s, e) =>
                        {
                            
                            if (!IsDisposed && lbTime != null)
                            {
                                lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            }
                        };
                        _dashboardTimer.Start();
                    }
                }
            }
            catch (Exception){}
        }
        private void InitializeButtonEvents()
        {
            // 1. Home
            btCreateOrder.Click += (s, e) => SelectTab(tabManageOrders);
            btAddProduct.Click += btAddManageProduct_Click;
            btReports.Click += (s, e) => SelectTab(tabReports);
            btBackup.Click += (s, e) => SelectTab(tabBackupRestore);

            // 2. Employees
            btSearchEmployees.Click += (s, e) => SearchEmployees();
            btDeleteEmployees.Click += (s, e) => DeleteItem("Employees", "EmployeeID", dataGridViewEmployees, LoadEmployees);
            btClearEmployees.Click += (s, e) => { txtKeyWordEmployees.Clear(); cbPosition.SelectedIndex = -1; LoadEmployees(); };
            btAddEmployees.Click += (s, e) => ShowEmployeeForm(null);
            btEditEmployees.Click += btEditEmployees_Click;
            btExportEmployees.Click += (s, e) => ExportToCSV(dataGridViewEmployees, "Employees.csv");

            // 3. Customers
            btSearchCustomer.Click += (s, e) => SearchCustomers();
            btDeleteCustomer.Click += (s, e) => DeleteItem("Customers", "CustomerID", dataGridViewCustomer, LoadCustomers);
            btClearCustomer.Click += (s, e) => { txtKeyWordCustomer.Clear(); LoadCustomers(); };
            btAddCustomer.Click += (s, e) => ShowCustomerForm(null);
            btEditCustomer.Click += btEditCustomer_Click;
            btExportCustomer.Click += (s, e) => ExportToCSV(dataGridViewCustomer, "Customers.csv");

            // 4. Categories
            btSearchCategories.Click += (s, e) => SearchCategories();
            btDeleteCategories.Click += (s, e) => DeleteItem("Categories", "CategoryID", dataGridViewCategories, LoadCategories);
            btClearCategories.Click += (s, e) => { txtKeywordCategories.Clear(); LoadCategories(); };
            btAddCategories.Click += (s, e) => ShowCategoryForm(null);
            btEditCategories.Click += btEditCategories_Click;
            btExportCategories.Click += (s, e) => ExportToCSV(dataGridViewCategories, "Categories.csv");

            // 5. Products
            btSearchProduct.Click += (s, e) => SearchProducts();
            btAddManageProduct.Click += btAddManageProduct_Click;
            btDeleteManageDelete.Click += (s, e) => DeleteItem("Products", "ProductID", dataGridViewManageProduct, LoadProducts);
            btClearProduct.Click += (s, e) => { txtKeyWordManageProduct.Clear(); cbManageProduct.SelectedIndex = -1; LoadProducts(); };
            btEditManageProduct.Click += btEditManageProduct_Click;
            btImageManageProduct.Click += btImageManageProduct_Click;
            btExportManageProduct.Click += btExportManageProduct_Click;
            btImportManageProduct.Click += btImportManageProduct_Click;

            // 6. Orders
            btCancelManageOrder.Click += (s, e) => UpdateOrderStatus("Cancelled");
            btRefundManageOrder.Click += (s, e) => UpdateOrderStatus("Refunded");
            btPrintManageOrder.Click += (s, e) => MessageBox.Show("Print feature is under development!", "Notification");
            btViewEditManageOrder.Click += btViewEditOrder_Click; // Assuming you have this button
            btNewOrderManageOrder.Click += (s, e) => ShowCreateOrderForm();
            btCancelManageOrder.Click += (s, e) => UpdateOrderStatus("Cancelled");
            btRefundManageOrder.Click += (s, e) => UpdateOrderStatus("Refunded");
            btPrintManageOrder.Click += (s, e) => MessageBox.Show("Print feature is under development!", "Notification");
            btViewEditManageOrder.Click += btViewEditOrder_Click;

            // 7. Order Details
            btSearchManageOrderDetails.Click += (s, e) => SearchOrderDetails();
            btRefreshManageOrderDetails.Click += (s, e) => { txtOrderIDManageOrderDetails.Clear(); txtProductNameManageOrderDetails.Clear(); LoadOrderDetails(); };
            btExportManageOrderDetails.Click += (s, e) => ExportToCSV(dataGridViewManageOrderDetails, "OrderDetails.csv");

            // 8. Goods Receipt
            btAddReceipt.Click += (s, e) => AddGoodsReceipt();
            btSearchGoodsReceipt.Click += (s, e) => LoadGoodsReceipts();
            btClearGoodReceipt.Click += (s, e) => {
                dateTimePickerFromGoodReceipt.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimePickerToGoodReceipt.Value = DateTime.Now;
                cbProductGoodsReceipt.SelectedIndex = -1;
                numericUpDownGoodsReceipt.Value = 0;
                numericUpDownUnitCostGoodsReceipt.Value = 0;
                txtNoteGoodsReceipt.Clear();
                LoadGoodsReceipts();
            };

            // 9. Inventory Log
            btSearchInventoryLog.Click += (s, e) => SearchInventoryLog();
            btClearInventory.Click += (s, e) => {
                cbProductInventoryLog.SelectedIndex = -1; cbTyleInventoryLog.SelectedIndex = -1;
                dateTimePickerFromInventoryLog.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimePickerToInventoryLog.Value = DateTime.Now; SearchInventoryLog();
            };
            btAdjustStockInventoryLog.Click += (s, e) => AdjustStock();
            btExprotInventoryLog.Click += (s, e) => ExportToCSV(dataGridViewMovementsInventoryLog, "InventoryLog.csv");

            // 10. Reports
            btSearchReport.Click += (s, e) => GenerateReport();

            // 11. User Accounts
            btSearchUser.Click += (s, e) => SearchUsers();
            btClearUser.Click += (s, e) => { txtSearchUser.Clear(); cbRoleUser.SelectedIndex = -1; LoadUsers(); };
            btAddUser.Click += (s, e) => ShowUserForm(null);
            btEditUser.Click += btEditUser_Click;
            btDeleteUser.Click += (s, e) => DeleteItem("UserAccounts", "EmployeeID", dataGridViewUserAccounts, LoadUsers);
            btExportUser.Click += (s, e) => ExportToCSV(dataGridViewUserAccounts, "Users.csv");
            btResetPasswordUser.Click += (s, e) => ResetUserPassword();
            btLockUnLock.Click += (s, e) => ToggleUserLockStatus();

            // 12. Roles
            btSearchRole.Click += (s, e) => SearchRoles();
            btDeleteRole.Click += (s, e) => DeleteItem("Roles", "RoleID", dataGridViewRole, LoadRoles);
            btClearRole.Click += (s, e) => { txtKeywordRole.Clear(); LoadRoles(); };
            btAddRole.Click += (s, e) => ShowRoleForm(null);
            btEditRole.Click += btEditRole_Click;
            btExportRole.Click += (s, e) => ExportToCSV(dataGridViewRole, "Roles.csv");

            // 13. Backup & Restore
            btBrowseBackup.Click += (s, e) => { SaveFileDialog sfd = new SaveFileDialog { Filter = "SQL Backup|*.bak", FileName = $"ShopX_Backup_{DateTime.Now:yyyyMMdd}" }; if (sfd.ShowDialog() == DialogResult.OK) txtBackupPath.Text = sfd.FileName; };
            btBackupData.Click += (s, e) => PerformBackup();
            btBrowseRestore.Click += (s, e) => { OpenFileDialog ofd = new OpenFileDialog { Filter = "SQL Backup|*.bak" }; if (ofd.ShowDialog() == DialogResult.OK) txtRestore.Text = ofd.FileName; };
            btRestoreData.Click += (s, e) => PerformRestore();
        }

        #region 1. Home
        private void LoadHomeData()
        {
            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    // Orders Today
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE CAST(OrderDate AS DATE)=CAST(GETDATE() AS DATE)", c))
                        txtOrderToday.Text = cmd.ExecuteScalar().ToString();

                    // Revenue (Last 30 days)
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(ol.Quantity * ol.UnitPrice), 0) FROM Orders o JOIN OrderLines ol ON o.OrderID = ol.OrderID WHERE o.Status='Paid' AND o.OrderDate>=DATEADD(DAY,-30,GETDATE())", c))
                        txtRevenue.Text = string.Format("{0:N0} VND", Convert.ToDecimal(cmd.ExecuteScalar()));

                    // Low Stock Alert
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock<10", c))
                        txtLowStock.Text = cmd.ExecuteScalar().ToString();

                    // Total Customers
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", c))
                        txtCustomersHome.Text = cmd.ExecuteScalar().ToString();

                    LoadRecentActivities(c);
                }
            }
            catch { }
        }

        private void LoadRecentActivities(SqlConnection c)
        {
            listBoxHome.Items.Clear();
            string q = "SELECT TOP 5 'Order #' + CAST(OrderID AS NVARCHAR) + ' | ' + Status + ' | ' + FORMAT(OrderDate, 'dd/MM HH:mm') FROM Orders ORDER BY OrderDate DESC";
            using (SqlCommand cmd = new SqlCommand(q, c))
            using (SqlDataReader r = cmd.ExecuteReader())
                while (r.Read()) listBoxHome.Items.Add(r.GetString(0));
        }

        // Empty placeholders for UI events if needed
        private void tabHome_Click(object s, EventArgs e) { }
        #endregion

        #region 2. Manage Employees
        private void LoadEmployees() => LoadDataToGrid("SELECT EmployeeID, FullName, Email, PhoneNumber, Position FROM Employees", dataGridViewEmployees);

        private void SearchEmployees()
        {
            string sql = "SELECT * FROM Employees WHERE FullName LIKE @k OR Email LIKE @k";
            if (cbPosition.Text != "") sql += $" AND Position = N'{cbPosition.Text}'";
            LoadDataWithParams(sql, dataGridViewEmployees, new SqlParameter("@k", "%" + txtKeyWordEmployees.Text + "%"));
        }

        private void ShowEmployeeForm(int? id)
        {
            Form f = new Form { Text = id == null ? "Add Employee" : "Edit Employee", Size = new Size(450, 350), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };
            TextBox tN = new TextBox { Location = new Point(130, 20), Width = 250 };
            TextBox tE = new TextBox { Location = new Point(130, 60), Width = 250 };
            TextBox tP = new TextBox { Location = new Point(130, 100), Width = 250 };
            ComboBox cb = new ComboBox { Location = new Point(130, 140), Width = 250 };
            cb.Items.AddRange(new string[] { "Sales", "Cashier", "Manager", "Warehouse" });

            f.Controls.AddRange(new Control[] {
                new Label { Text = "Name:", Location = new Point(20, 23) }, tN,
                new Label { Text = "Email:", Location = new Point(20, 63) }, tE,
                new Label { Text = "Phone:", Location = new Point(20, 103) }, tP,
                new Label { Text = "Position:", Location = new Point(20, 143) }, cb
            });

            Button bS = new Button { Text = "Save", Location = new Point(130, 200), DialogResult = DialogResult.OK, BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 100, Height = 35 };
            f.Controls.Add(bS); f.AcceptButton = bS;

            if (id != null && dataGridViewEmployees.CurrentRow != null)
            {
                tN.Text = dataGridViewEmployees.CurrentRow.Cells["FullName"].Value?.ToString();
                tE.Text = dataGridViewEmployees.CurrentRow.Cells["Email"].Value?.ToString();
                tP.Text = dataGridViewEmployees.CurrentRow.Cells["PhoneNumber"].Value?.ToString();
                cb.Text = dataGridViewEmployees.CurrentRow.Cells["Position"].Value?.ToString();
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sql = id == null ?
                    "INSERT INTO Employees (FullName, Email, PhoneNumber, Position) VALUES (@n,@e,@p,@pos)" :
                    "UPDATE Employees SET FullName=@n, Email=@e, PhoneNumber=@p, Position=@pos WHERE EmployeeID=@id";

                ExecuteSql(sql, new SqlParameter[] {
                    new SqlParameter("@n", tN.Text),
                    new SqlParameter("@e", tE.Text),
                    new SqlParameter("@p", tP.Text),
                    new SqlParameter("@pos", cb.Text),
                    new SqlParameter("@id", id ?? 0)
                });
                LoadEmployees();
            }
        }

        private void btEditEmployees_Click(object s, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow != null)
                ShowEmployeeForm(Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["EmployeeID"].Value));
        }
        #endregion

        #region 3. Manage Customers
        private void LoadCustomers() => LoadDataToGrid("SELECT CustomerID, FullName, Email, PhoneNumber, Address FROM Customers", dataGridViewCustomer);

        private void SearchCustomers()
        {
            string sql = "SELECT * FROM Customers WHERE FullName LIKE @k OR PhoneNumber LIKE @k";
            LoadDataWithParams(sql, dataGridViewCustomer, new SqlParameter("@k", "%" + txtKeyWordCustomer.Text + "%"));
        }

        private void ShowCustomerForm(int? id)
        {
            Form f = new Form { Text = id == null ? "Add Customer" : "Edit Customer", Size = new Size(450, 380), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };
            TextBox tN = new TextBox { Location = new Point(130, 20), Width = 250 };
            TextBox tE = new TextBox { Location = new Point(130, 65), Width = 250 };
            TextBox tP = new TextBox { Location = new Point(130, 110), Width = 250 };
            TextBox tA = new TextBox { Location = new Point(130, 155), Width = 250, Multiline = true, Height = 50 };

            f.Controls.AddRange(new Control[] {
                new Label { Text = "Name:", Location = new Point(20, 23) }, tN,
                new Label { Text = "Email:", Location = new Point(20, 68) }, tE,
                new Label { Text = "Phone:", Location = new Point(20, 113) }, tP,
                new Label { Text = "Address:", Location = new Point(20, 158) }, tA
            });

            Button bS = new Button { Text = "Save", Location = new Point(130, 230), DialogResult = DialogResult.OK, BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 100, Height = 35 };
            f.Controls.Add(bS); f.AcceptButton = bS;

            if (id != null && dataGridViewCustomer.CurrentRow != null)
            {
                tN.Text = dataGridViewCustomer.CurrentRow.Cells["FullName"].Value?.ToString();
                tE.Text = dataGridViewCustomer.CurrentRow.Cells["Email"].Value?.ToString();
                tP.Text = dataGridViewCustomer.CurrentRow.Cells["PhoneNumber"].Value?.ToString();
                tA.Text = dataGridViewCustomer.CurrentRow.Cells["Address"].Value?.ToString();
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sql = id == null ?
                    "INSERT INTO Customers (FullName, Email, PhoneNumber, Address) VALUES (@n,@e,@p,@a)" :
                    "UPDATE Customers SET FullName=@n, Email=@e, PhoneNumber=@p, Address=@a WHERE CustomerID=@id";

                ExecuteSql(sql, new SqlParameter[] {
                    new SqlParameter("@n", tN.Text),
                    new SqlParameter("@e", tE.Text),
                    new SqlParameter("@p", tP.Text),
                    new SqlParameter("@a", tA.Text),
                    new SqlParameter("@id", id ?? 0)
                });
                LoadCustomers();
            }
        }

        private void btEditCustomer_Click(object s, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow != null)
                ShowCustomerForm(Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells["CustomerID"].Value));
        }
        #endregion

        #region 4. Manage Categories
        private void LoadCategories() => LoadDataToGrid("SELECT CategoryID, CategoryName FROM Categories", dataGridViewCategories);

        private void SearchCategories()
        {
            string sql = "SELECT * FROM Categories WHERE CategoryName LIKE @k";
            LoadDataWithParams(sql, dataGridViewCategories, new SqlParameter("@k", "%" + txtKeywordCategories.Text + "%"));
        }

        private void ShowCategoryForm(int? id)
        {
            Form f = new Form { Text = id == null ? "Add Category" : "Edit Category", Size = new Size(400, 200), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };
            TextBox tName = new TextBox { Location = new Point(120, 30), Width = 230 };
            f.Controls.Add(new Label { Text = "Name:", Location = new Point(20, 33), AutoSize = true });
            f.Controls.Add(tName);

            Button bS = new Button { Text = "Save", Location = new Point(120, 90), DialogResult = DialogResult.OK, BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 100, Height = 35 };
            f.Controls.Add(bS); f.AcceptButton = bS;

            if (id != null && dataGridViewCategories.CurrentRow != null)
                tName.Text = dataGridViewCategories.CurrentRow.Cells["CategoryName"].Value?.ToString();

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sql = id == null ?
                    "INSERT INTO Categories (CategoryName) VALUES (@n)" :
                    "UPDATE Categories SET CategoryName=@n WHERE CategoryID=@id";
                ExecuteSql(sql, new SqlParameter[] { new SqlParameter("@n", tName.Text), new SqlParameter("@id", id ?? 0) });
                LoadCategories();
                LoadAllComboBoxes();
            }
        }

        private void btEditCategories_Click(object s, EventArgs e)
        {
            if (dataGridViewCategories.CurrentRow != null)
                ShowCategoryForm(Convert.ToInt32(dataGridViewCategories.CurrentRow.Cells["CategoryID"].Value));
        }
        #endregion

        #region 5. Manage Products
        private void LoadProducts() => LoadDataToGrid(@"SELECT p.ProductID, p.ProductName, p.UnitPrice, p.Stock, c.CategoryName FROM Products p LEFT JOIN Categories c ON p.CategoryID = c.CategoryID", dataGridViewManageProduct);

        private void SearchProducts()
        {
            string sql = @"SELECT p.ProductID, p.ProductName, p.UnitPrice, p.Stock, c.CategoryName 
                           FROM Products p LEFT JOIN Categories c ON p.CategoryID = c.CategoryID 
                           WHERE p.ProductName LIKE @k";
            if (cbManageProduct.SelectedValue != null) sql += " AND p.CategoryID = " + cbManageProduct.SelectedValue;
            LoadDataWithParams(sql, dataGridViewManageProduct, new SqlParameter("@k", "%" + txtKeyWordManageProduct.Text + "%"));
        }

        private void btAddManageProduct_Click(object sender, EventArgs e)
        {
     
            Form f = new Form { Text = "Thêm Sản Phẩm Mới", Size = new Size(450, 380), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };

            TextBox tN = new TextBox { Location = new Point(140, 30), Width = 260 };
            NumericUpDown nP = new NumericUpDown { Location = new Point(140, 80), Width = 260, Maximum = 1000000000, DecimalPlaces = 0 };
            NumericUpDown nS = new NumericUpDown { Location = new Point(140, 130), Width = 260, Maximum = 10000, Minimum = 0 }; 
            ComboBox cC = new ComboBox { Location = new Point(140, 180), Width = 260, DropDownStyle = ComboBoxStyle.DropDownList };

            FillComboBox(cC, "SELECT CategoryID, CategoryName FROM Categories", "CategoryName", "CategoryID");

            f.Controls.AddRange(new Control[] {
        new Label { Text = "Tên SP:", Location = new Point(30, 33) }, tN,
        new Label { Text = "Giá bán:", Location = new Point(30, 83) }, nP,
        new Label { Text = "Số lượng:", Location = new Point(30, 133) }, nS,
        new Label { Text = "Danh mục:", Location = new Point(30, 183) }, cC
    });

            Button bS = new Button { Text = "Lưu", Location = new Point(140, 240), BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 120, Height = 35 };
            f.Controls.Add(bS);
            f.AcceptButton = bS;

            bS.Click += (s, args) =>
            {
            
                if (nP.Value <= 0 || nS.Value <= 0)
                {
                    MessageBox.Show("Giá tiền và Số lượng phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

         
                if (string.IsNullOrWhiteSpace(tN.Text) || cC.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm và chọn danh mục!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        
                        string checkSql = "SELECT COUNT(*) FROM Products WHERE ProductName = @name";
                        SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                        checkCmd.Parameters.AddWithValue("@name", tN.Text.Trim());

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"Sản phẩm có tên '{tN.Text}' đã tồn tại!\nVui lòng đặt tên khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Dừng lại, không đóng form
                        }

                        
                        string insertSql = "INSERT INTO Products (ProductName, UnitPrice, Stock, CategoryID) VALUES (@n, @p, @s, @c)";
                        SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                        insertCmd.Parameters.AddWithValue("@n", tN.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@p", nP.Value);
                        insertCmd.Parameters.AddWithValue("@s", nS.Value);
                        insertCmd.Parameters.AddWithValue("@c", cC.SelectedValue);

                        insertCmd.ExecuteNonQuery();
                    }

                    
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    f.DialogResult = DialogResult.OK;
                    f.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Database: " + ex.Message);
                }
            };

            // 4. Sau khi Form đóng lại thì load lại dữ liệu bên ngoài
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                LoadHomeData();
                LoadAllComboBoxes();
            }
        }

        private void btEditManageProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewManageProduct.CurrentRow == null) { MessageBox.Show("Please select a product to edit!"); return; }

            int id = Convert.ToInt32(dataGridViewManageProduct.CurrentRow.Cells["ProductID"].Value);
            string oldName = dataGridViewManageProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            decimal oldPrice = Convert.ToDecimal(dataGridViewManageProduct.CurrentRow.Cells["UnitPrice"].Value);
            int oldStock = Convert.ToInt32(dataGridViewManageProduct.CurrentRow.Cells["Stock"].Value);
            string oldCat = dataGridViewManageProduct.CurrentRow.Cells["CategoryName"].Value?.ToString();

            Form f = new Form { Text = "Edit Product #" + id, Size = new Size(450, 380), StartPosition = FormStartPosition.CenterParent };
            TextBox tN = new TextBox { Location = new Point(140, 30), Width = 260, Text = oldName };
            NumericUpDown nP = new NumericUpDown { Location = new Point(140, 80), Width = 260, Maximum = 1000000000, Value = oldPrice };
            NumericUpDown nS = new NumericUpDown { Location = new Point(140, 130), Width = 260, Maximum = 10000, Minimum = 0, Value = oldStock };
            ComboBox cC = new ComboBox { Location = new Point(140, 180), Width = 260, DropDownStyle = ComboBoxStyle.DropDownList };
            FillComboBox(cC, "SELECT CategoryID, CategoryName FROM Categories", "CategoryName", "CategoryID");
            cC.Text = oldCat;

            f.Controls.AddRange(new Control[] {
                new Label { Text = "Name:", Location = new Point(30, 33) }, tN,
                new Label { Text = "Price:", Location = new Point(30, 83) }, nP,
                new Label { Text = "Stock:", Location = new Point(30, 133) }, nS,
                new Label { Text = "Category:", Location = new Point(30, 183) }, cC
            });

            Button bS = new Button { Text = "Update", Location = new Point(140, 240), DialogResult = DialogResult.OK, BackColor = Color.Orange, ForeColor = Color.White, Width = 120, Height = 35 };
            f.Controls.Add(bS); f.AcceptButton = bS;

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (cC.SelectedValue == null) return;
                try
                {
                    string sql = "UPDATE Products SET ProductName=@n, UnitPrice=@p, Stock=@s, CategoryID=@c WHERE ProductID=@id";
                    ExecuteSql(sql, new SqlParameter[] {
                        new SqlParameter("@n", tN.Text),
                        new SqlParameter("@p", nP.Value),
                        new SqlParameter("@s", nS.Value),
                        new SqlParameter("@c", cC.SelectedValue),
                        new SqlParameter("@id", id)
                    });
                    MessageBox.Show("Updated successfully!");
                    LoadProducts();
                    LoadAllComboBoxes();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btImageManageProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewManageProduct.CurrentRow == null) return;
            int prodId = Convert.ToInt32(dataGridViewManageProduct.CurrentRow.Cells["ProductID"].Value);

            OpenFileDialog open = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filePath = open.FileName;
                try
                {
                    ExecuteSql($"DELETE FROM ProductImages WHERE ProductID={prodId} AND IsPrimary=1", null);
                    string sql = "INSERT INTO ProductImages (ProductID, ImagePath, IsPrimary) VALUES (@pid, @path, 1)";
                    ExecuteSql(sql, new SqlParameter[] { new SqlParameter("@pid", prodId), new SqlParameter("@path", filePath) });
                    MessageBox.Show("Product image updated!");
                }
                catch (Exception ex) { MessageBox.Show("Image Save Error: " + ex.Message); }
            }
        }

        private void btExportManageProduct_Click(object sender, EventArgs e) => ExportToCSV(dataGridViewManageProduct, "ProductList.csv");

        private void btImportManageProduct_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != AppRole.Admin) { MessageBox.Show("Only Admin can import data!"); return; }

            OpenFileDialog ofd = new OpenFileDialog { Filter = "CSV Files|*.csv" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    int count = 0;
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        // Skip header (i=1)
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] data = lines[i].Split(',');
                            if (data.Length >= 3)
                            {
                                string name = data[0].Trim();
                                decimal price = decimal.Parse(data[1].Trim());
                                int stock = int.Parse(data[2].Trim());
                                string sql = $"INSERT INTO Products (ProductName, UnitPrice, Stock, CategoryID) VALUES (N'{name}', {price}, {stock}, 1)";
                                new SqlCommand(sql, conn).ExecuteNonQuery();
                                count++;
                            }
                        }
                    }
                    MessageBox.Show($"Imported {count} products successfully!");
                    LoadProducts();
                }
                catch (Exception ex) { MessageBox.Show("Import Error: " + ex.Message + "\nCSV Format: Name,Price,Stock"); }
            }
        }

        // Additional method just in case duplicate event handler
        private void btImageManageProduct_Click_1(object sender, EventArgs e) { }
        #endregion

        #region 6. Manage Orders
        private void LoadOrders() => SearchOrders();

        private void SearchOrders()
        {
            try
            {
                string sql = @"
                    SELECT o.OrderID, o.OrderDate, c.FullName AS [Customer], o.Status, e.FullName AS [Sales Person] 
                    FROM Orders o 
                    LEFT JOIN Customers c ON o.CustomerID = c.CustomerID 
                    LEFT JOIN Employees e ON o.SalesEmpID = e.EmployeeID 
                    WHERE (o.OrderDate BETWEEN @d1 AND @d2)";

                List<SqlParameter> p = new List<SqlParameter> {
                    new SqlParameter("@d1", dateTimePickerFrom.Value.Date),
                    new SqlParameter("@d2", dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1))
                };

                if (!string.IsNullOrEmpty(txtManageOrderId.Text) && int.TryParse(txtManageOrderId.Text.Trim(), out int id))
                {
                    sql += " AND o.OrderID = @id";
                    p.Add(new SqlParameter("@id", id));
                }

                if (cbCustomerManageOrder.SelectedValue != null && (int)cbCustomerManageOrder.SelectedValue > 0)
                {
                    sql += " AND o.CustomerID = @cid";
                    p.Add(new SqlParameter("@cid", cbCustomerManageOrder.SelectedValue));
                }

                if (!string.IsNullOrEmpty(cbStatusManageOrder.Text) && cbStatusManageOrder.Text != "All")
                {
                    sql += " AND o.Status = @st";
                    p.Add(new SqlParameter("@st", cbStatusManageOrder.Text));
                }

                sql += " ORDER BY o.OrderDate DESC";
                LoadDataWithParamsList(sql, dataGridViewOrderMaster, p);
            }
            catch (Exception ex) { MessageBox.Show("Error searching orders: " + ex.Message); }
        }

        // LOGIC: Create Order -> Deduct Stock -> Log Inventory Movement
        private void ShowCreateOrderForm()
        {
            Form f = new Form { Text = "Create New Order", Size = new Size(450, 420), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };
            int x = 130, y = 30, w = 250;

            f.Controls.Add(new Label { Text = "Customer:", Location = new Point(20, y + 3) });
            ComboBox cC = new ComboBox { Location = new Point(x, y), Width = w, DropDownStyle = ComboBoxStyle.DropDownList };
            FillComboBox(cC, "SELECT CustomerID, FullName FROM Customers", "FullName", "CustomerID");
            f.Controls.Add(cC);

            y += 50;
            f.Controls.Add(new Label { Text = "Sales Person:", Location = new Point(20, y + 3) });
            ComboBox cE = new ComboBox { Location = new Point(x, y), Width = w, DropDownStyle = ComboBoxStyle.DropDownList };
            FillComboBox(cE, "SELECT EmployeeID, FullName FROM Employees", "FullName", "EmployeeID");
            cE.SelectedValue = _currentUser.EmployeeID;
            f.Controls.Add(cE);

            y += 50;
            f.Controls.Add(new Label { Text = "Product:", Location = new Point(20, y + 3) });
            ComboBox cP = new ComboBox { Location = new Point(x, y), Width = w, DropDownStyle = ComboBoxStyle.DropDownList };
            FillComboBox(cP, "SELECT ProductID, ProductName FROM Products", "ProductName", "ProductID");
            f.Controls.Add(cP);

            y += 50;
            f.Controls.Add(new Label { Text = "Quantity:", Location = new Point(20, y + 3) });
            NumericUpDown nQ = new NumericUpDown { Location = new Point(x, y), Width = w, Minimum = 1, Maximum = 10000, Value = 1 };
            f.Controls.Add(nQ);

            y += 50;
            Label lbStockCheck = new Label { Text = "Stock: -", Location = new Point(x, y), AutoSize = true, ForeColor = Color.Red };
            f.Controls.Add(lbStockCheck);

            cP.SelectedIndexChanged += (s, e) =>
            {
                if (cP.SelectedValue != null && int.TryParse(cP.SelectedValue.ToString(), out int pid))
                {
                    try
                    {
                        using (SqlConnection c = DatabaseHelper.GetConnection())
                        {
                            c.Open();
                            int stock = (int)new SqlCommand($"SELECT Stock FROM Products WHERE ProductID={pid}", c).ExecuteScalar();
                            lbStockCheck.Text = $"Current Stock: {stock}";
                            lbStockCheck.ForeColor = stock > 0 ? Color.Green : Color.Red;
                            nQ.Maximum = stock > 0 ? stock : 0;
                        }
                    }
                    catch { }
                }
            };

            y += 50;
            Button bS = new Button { Text = "Create", Location = new Point(x, y), BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 120, Height = 40 };
            f.Controls.Add(bS); f.AcceptButton = bS;

            bS.Click += (sender, e) =>
            {
                if (cC.SelectedValue == null || cP.SelectedValue == null || cE.SelectedValue == null) return;
                int custId = (int)cC.SelectedValue;
                int empId = (int)cE.SelectedValue;
                int prodId = (int)cP.SelectedValue;
                int qty = (int)nQ.Value;

                if (qty <= 0) { MessageBox.Show("Quantity must be greater than 0"); return; }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        // 1. Re-check stock
                        SqlCommand cmdCheck = new SqlCommand($"SELECT Stock, UnitPrice, ProductName FROM Products WHERE ProductID = {prodId}", conn, transaction);
                        SqlDataReader r = cmdCheck.ExecuteReader();
                        if (!r.Read()) throw new Exception("Product does not exist!");
                        int currentStock = r.GetInt32(0);
                        decimal price = r.GetDecimal(1);
                        r.Close();

                        if (currentStock < qty) throw new Exception($"Insufficient stock! Warehouse has {currentStock}, you requested {qty}.");

                        // 2. Create Order
                        string sqlOrder = $"INSERT INTO Orders (CustomerID, SalesEmpID, Status, OrderDate) VALUES ({custId}, {empId}, 'Paid', GETDATE()); SELECT SCOPE_IDENTITY();";
                        int newOrderId = Convert.ToInt32(new SqlCommand(sqlOrder, conn, transaction).ExecuteScalar());

                        // 3. Create Order Line
                        new SqlCommand($"INSERT INTO OrderLines (OrderID, ProductID, Quantity, UnitPrice) VALUES ({newOrderId}, {prodId}, {qty}, {price})", conn, transaction).ExecuteNonQuery();

                        // 4. Update Stock
                        new SqlCommand($"UPDATE Products SET Stock = Stock - {qty} WHERE ProductID = {prodId}", conn, transaction).ExecuteNonQuery();

                        // 5. Log Movement
                        string note = $"Stock out for Order #{newOrderId}";
                        string sqlLog = "INSERT INTO InventoryMovements (ProductID, QtyChange, MovementType, MovementDate, PerformedByEmpID, Note) VALUES (@pid, @qty, 'OUT', GETDATE(), @eid, @note)";
                        SqlCommand cmdLog = new SqlCommand(sqlLog, conn, transaction);
                        cmdLog.Parameters.AddWithValue("@pid", prodId);
                        cmdLog.Parameters.AddWithValue("@qty", -qty);
                        cmdLog.Parameters.AddWithValue("@eid", _currentUser.EmployeeID);
                        cmdLog.Parameters.AddWithValue("@note", note);
                        cmdLog.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show($"Order #{newOrderId} created successfully! Inventory deducted.");
                        f.DialogResult = DialogResult.OK;
                        f.Close();

                        LoadOrders();
                        LoadHomeData();
                        LoadOrderDetails();
                        LoadInventory();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Transaction Error: " + ex.Message);
                    }
                }
            };
            f.ShowDialog();
        }

        private void btViewEditOrder_Click(object s, EventArgs e)
        {
            if (dataGridViewOrderMaster.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewOrderMaster.CurrentRow.Cells["OrderID"].Value);
            string st = dataGridViewOrderMaster.CurrentRow.Cells["Status"].Value.ToString();

            Form f = new Form { Text = $"Order #{id}", Size = new Size(600, 450), StartPosition = FormStartPosition.CenterParent };
            DataGridView g = new DataGridView { Location = new Point(20, 60), Size = new Size(540, 250), ReadOnly = true };
            LoadDataToGrid($"SELECT p.ProductName, ol.Quantity, ol.UnitPrice, (ol.Quantity*ol.UnitPrice) as Total FROM OrderLines ol JOIN Products p ON ol.ProductID=p.ProductID WHERE OrderID={id}", g);

            ComboBox cb = new ComboBox { Location = new Point(80, 20), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            cb.Items.AddRange(new string[] { "Pending", "Paid", "Cancelled", "Refunded" });
            cb.Text = st;

            Button b = new Button { Text = "Update", Location = new Point(250, 18), Width = 100 };
            b.Click += (sender, ev) => {
                ExecuteSql("UPDATE Orders SET Status=@s WHERE OrderID=@id", new SqlParameter[] { new SqlParameter("@s", cb.Text), new SqlParameter("@id", id) });
                MessageBox.Show("Updated!");
                SearchOrders();
                f.Close();
            };

            f.Controls.AddRange(new Control[] { new Label { Text = "Status:", Location = new Point(20, 23) }, cb, b, g });
            f.ShowDialog();
        }

        private void UpdateOrderStatus(string st)
        {
            if (dataGridViewOrderMaster.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewOrderMaster.CurrentRow.Cells["OrderID"].Value);
                if (MessageBox.Show("Confirm status change?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExecuteSql("UPDATE Orders SET Status=@s WHERE OrderID=@id", new SqlParameter[] { new SqlParameter("@s", st), new SqlParameter("@id", id) });
                    SearchOrders();
                    LoadHomeData();
                }
            }
        }
        #endregion

        #region 7. Manage Order Details
        private void LoadOrderDetails() => SearchOrderDetails();

        private void SearchOrderDetails()
        {
            string sql = @"SELECT ol.OrderID, p.ProductName, o.OrderDate, ol.Quantity, ol.UnitPrice, (ol.Quantity * ol.UnitPrice) AS [Total Price] 
                           FROM OrderLines ol 
                           JOIN Products p ON ol.ProductID = p.ProductID 
                           JOIN Orders o ON ol.OrderID = o.OrderID 
                           WHERE (o.OrderDate BETWEEN @d1 AND @d2)";

            List<SqlParameter> p = new List<SqlParameter> {
                new SqlParameter("@d1", dateTimePickerFromManageOrderDetails.Value.Date),
                new SqlParameter("@d2", dateTimePickerToManageOrderDetails.Value.Date.AddDays(1).AddSeconds(-1))
            };

            if (!string.IsNullOrEmpty(txtOrderIDManageOrderDetails.Text) && int.TryParse(txtOrderIDManageOrderDetails.Text, out int id))
            {
                sql += " AND ol.OrderID = @id";
                p.Add(new SqlParameter("@id", id));
            }
            if (!string.IsNullOrEmpty(txtProductNameManageOrderDetails.Text))
            {
                sql += " AND p.ProductName LIKE @name";
                p.Add(new SqlParameter("@name", "%" + txtProductNameManageOrderDetails.Text + "%"));
            }

            sql += " ORDER BY o.OrderDate DESC";
            LoadDataWithParamsList(sql, dataGridViewManageOrderDetails, p);

            // Calculate Totals
            int r = 0, q = 0; decimal s = 0;
            foreach (DataGridViewRow row in dataGridViewManageOrderDetails.Rows)
            {
                if (!row.IsNewRow)
                {
                    r++;
                    q += Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);
                    s += Convert.ToDecimal(row.Cells["Total Price"].Value ?? 0);
                }
            }
            txtTotalRowsManageOrderDetails.Text = r.ToString();
            txtTotalQuantityManageOrderDetails.Text = q.ToString("N0");
            txtTotalSaleManageDetails.Text = s.ToString("N0") + " VND";
        }
        #endregion

        #region 8. Goods Receipt
        // LOGIC: Increase Stock -> Log Inventory Movement
        private void AddGoodsReceipt()
        {
            if (cbProductGoodsReceipt.SelectedValue == null) { MessageBox.Show("Please select a product!"); return; }
            int qty = (int)numericUpDownGoodsReceipt.Value;
            if (qty <= 0) { MessageBox.Show("Import quantity must be > 0!"); return; }

            int prodId = (int)cbProductGoodsReceipt.SelectedValue;
            decimal cost = numericUpDownUnitCostGoodsReceipt.Value;
            string note = txtNoteGoodsReceipt.Text;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Step 1: Increase Stock
                    string sqlUpdate = "UPDATE Products SET Stock = Stock + @qty WHERE ProductID = @pid";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn, transaction);
                    cmdUpdate.Parameters.AddWithValue("@qty", qty);
                    cmdUpdate.Parameters.AddWithValue("@pid", prodId);
                    cmdUpdate.ExecuteNonQuery();

                    // Step 2: Log Movement (IN)
                    string sqlLog = @"INSERT INTO InventoryMovements 
                            (ProductID, QtyChange, MovementType, MovementDate, PerformedByEmpID, UnitCost, Note) 
                            VALUES (@pid, @qty, 'IN', GETDATE(), @eid, @cost, @note)";

                    SqlCommand cmdLog = new SqlCommand(sqlLog, conn, transaction);
                    cmdLog.Parameters.AddWithValue("@pid", prodId);
                    cmdLog.Parameters.AddWithValue("@qty", qty);
                    cmdLog.Parameters.AddWithValue("@eid", _currentUser.EmployeeID);
                    cmdLog.Parameters.AddWithValue("@cost", cost);
                    cmdLog.Parameters.AddWithValue("@note", string.IsNullOrEmpty(note) ? "Supplier Import" : note);
                    cmdLog.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"Imported {qty} items successfully!");

                    // Reset & Reload
                    numericUpDownGoodsReceipt.Value = 0;
                    txtNoteGoodsReceipt.Clear();
                    LoadGoodsReceipts();
                    LoadProducts();
                    LoadHomeData();
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Import Error: " + ex.Message);
                }
            }
        }

        private void LoadGoodsReceipts()
        {
            string sql = @"SELECT im.MovementID, p.ProductName, im.QtyChange AS [Quantity], im.UnitCost, im.Note, im.MovementDate, e.FullName AS [Performed By] 
                           FROM InventoryMovements im JOIN Products p ON im.ProductID = p.ProductID LEFT JOIN Employees e ON im.PerformedByEmpID = e.EmployeeID 
                           WHERE im.MovementType = 'IN' AND (im.MovementDate BETWEEN @d1 AND @d2) ORDER BY im.MovementDate DESC";
            LoadDataWithParamsList(sql, dataGridViewGoodsReceipt, new List<SqlParameter> {
                new SqlParameter("@d1", dateTimePickerFromGoodReceipt.Value.Date),
                new SqlParameter("@d2", dateTimePickerToGoodReceipt.Value.Date.AddDays(1).AddSeconds(-1))
            });

            int tr = 0, tq = 0;
            foreach (DataGridViewRow row in dataGridViewGoodsReceipt.Rows) { if (!row.IsNewRow) { tr++; tq += Convert.ToInt32(row.Cells["Quantity"].Value ?? 0); } }
            txtTotalReceipt.Text = tr.ToString(); lbTotalQuantityGoodReceipt.Text = tq.ToString();
        }
        #endregion

        #region 9. Inventory Log
        private void LoadInventory() => SearchInventoryLog();

        private void SearchInventoryLog()
        {
            string q = @"SELECT im.MovementID, p.ProductName, im.QtyChange, im.MovementType, im.MovementDate, e.FullName AS [Performed By], im.Note 
                         FROM InventoryMovements im 
                         JOIN Products p ON im.ProductID = p.ProductID 
                         LEFT JOIN Employees e ON im.PerformedByEmpID = e.EmployeeID 
                         WHERE (im.MovementDate BETWEEN @d1 AND @d2)";

            List<SqlParameter> p = new List<SqlParameter> {
                new SqlParameter("@d1", dateTimePickerFromInventoryLog.Value.Date),
                new SqlParameter("@d2", dateTimePickerToInventoryLog.Value.Date.AddDays(1).AddSeconds(-1))
            };

            if (cbProductInventoryLog.SelectedValue != null)
            {
                q += " AND im.ProductID = @pid";
                p.Add(new SqlParameter("@pid", cbProductInventoryLog.SelectedValue));
            }
            if (!string.IsNullOrEmpty(cbTyleInventoryLog.Text))
            {
                q += " AND im.MovementType = @type";
                p.Add(new SqlParameter("@type", cbTyleInventoryLog.Text));
            }
            q += " ORDER BY im.MovementDate DESC";
            LoadDataWithParamsList(q, dataGridViewMovementsInventoryLog, p);
            lbSummary.Text = $"Records: {dataGridViewMovementsInventoryLog.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).Count()}";
        }

        private void AdjustStock()
        {
            Form f = new Form { Text = "Adjust Stock", Size = new Size(400, 350), StartPosition = FormStartPosition.CenterParent };
            int x = 130, y = 30, w = 220;

            f.Controls.Add(new Label { Text = "Product:", Location = new Point(20, y + 3) });
            ComboBox cb = new ComboBox { Location = new Point(x, y), Width = w, DropDownStyle = ComboBoxStyle.DropDownList };
            FillComboBox(cb, "SELECT ProductID,ProductName FROM Products", "ProductName", "ProductID");
            f.Controls.Add(cb);

            y += 50;
            f.Controls.Add(new Label { Text = "Qty (+/-):", Location = new Point(20, y + 3) });
            NumericUpDown nu = new NumericUpDown { Location = new Point(x, y), Width = w, Minimum = -1000, Maximum = 1000 };
            f.Controls.Add(nu);

            y += 60;
            f.Controls.Add(new Label { Text = "Note:", Location = new Point(20, y + 3) });
            TextBox tb = new TextBox { Location = new Point(x, y), Width = w };
            f.Controls.Add(tb);

            y += 60;
            Button b = new Button { Text = "Save", Location = new Point(x, y), DialogResult = DialogResult.OK };
            f.Controls.Add(b);

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection c = DatabaseHelper.GetConnection())
                    {
                        c.Open();
                        int empId = _currentUser.EmployeeID;
                        int cnt = (int)new SqlCommand($"SELECT COUNT(*) FROM Employees WHERE EmployeeID={empId}", c).ExecuteScalar();
                        if (cnt == 0) empId = (int)new SqlCommand("SELECT TOP 1 EmployeeID FROM Employees", c).ExecuteScalar();

                        new SqlCommand($"INSERT INTO InventoryMovements (ProductID,QtyChange,MovementType,MovementDate,PerformedByEmpID,Note) VALUES ({cb.SelectedValue},{nu.Value},'ADJUST',GETDATE(),{empId},N'{tb.Text}')", c).ExecuteNonQuery();
                        new SqlCommand($"UPDATE Products SET Stock=Stock+{nu.Value} WHERE ProductID={cb.SelectedValue}", c).ExecuteNonQuery();
                    }
                    MessageBox.Show("Stock adjusted successfully!");
                    LoadInventory();
                    LoadProducts();
                    LoadHomeData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void lbInventoryLogFilters_Click(object s, EventArgs e) { }
        #endregion

        #region 10. Reports
        private void GenerateReport()
        {
            string rT = cbReport.Text;
            DateTime d1 = dateTimePickerFromReport.Value.Date;
            DateTime d2 = dateTimePickerToReport.Value.Date.AddDays(1).AddSeconds(-1);

            chartReport.Series.Clear();
            chartReport.Legends.Clear();
            chartReport.Legends.Add("Legend1");
            chartReport.Titles.Clear();
            chartReport.Titles.Add(rT);

            DataTable dt = new DataTable();
            Series s = new Series();

            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand("", c);

                    if (rT == "Top Selling Products")
                    {
                        cmd.CommandText = @"SELECT TOP 5 p.ProductName, SUM(ol.Quantity) AS TotalQty 
                                            FROM OrderLines ol 
                                            JOIN Orders o ON ol.OrderID=o.OrderID 
                                            JOIN Products p ON ol.ProductID=p.ProductID 
                                            WHERE o.Status='Paid' AND o.OrderDate BETWEEN @d1 AND @d2 
                                            GROUP BY p.ProductName ORDER BY TotalQty DESC";
                        s.ChartType = SeriesChartType.Column;
                    }
                    else if (rT == "Revenue by Date")
                    {
                        cmd.CommandText = @"SELECT CAST(o.OrderDate AS DATE) AS ReportDate, SUM(ol.Quantity*ol.UnitPrice) AS Revenue 
                                            FROM Orders o 
                                            JOIN OrderLines ol ON o.OrderID=ol.OrderID 
                                            WHERE o.Status='Paid' AND o.OrderDate BETWEEN @d1 AND @d2 
                                            GROUP BY CAST(o.OrderDate AS DATE) ORDER BY ReportDate";
                        s.ChartType = SeriesChartType.Line;
                        s.BorderWidth = 3;
                        s.MarkerStyle = MarkerStyle.Circle;
                    }
                    else // Low Stock
                    {
                        cmd.CommandText = "SELECT ProductName, Stock FROM Products WHERE Stock < 10 ORDER BY Stock ASC";
                        s.ChartType = SeriesChartType.Bar;
                        s.Color = Color.Red;
                    }

                    if (rT != "Low Stock Alert")
                    {
                        cmd.Parameters.AddWithValue("@d1", d1);
                        cmd.Parameters.AddWithValue("@d2", d2);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                dataGridViewReport.DataSource = dt;
                dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                chartReport.Series.Add(s);
                s.IsValueShownAsLabel = true;

                foreach (DataRow r in dt.Rows)
                {
                    if (rT == "Top Selling Products") s.Points.AddXY(r["ProductName"], r["TotalQty"]);
                    else if (rT == "Revenue by Date") s.Points.AddXY(Convert.ToDateTime(r["ReportDate"]).ToString("dd/MM"), r["Revenue"]);
                    else s.Points.AddXY(r["ProductName"], r["Stock"]);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error generating report: " + ex.Message); }
        }
        #endregion

        #region 11. User Accounts
        private void LoadUsers() => SearchUsers();

        private void SearchUsers()
        {
            string sql = @"SELECT u.EmployeeID, e.FullName, u.Username, r.RoleName, u.IsLocked 
                           FROM UserAccounts u 
                           JOIN Employees e ON u.EmployeeID = e.EmployeeID 
                           JOIN Roles r ON u.RoleID = r.RoleID
                           WHERE u.Username LIKE @k OR e.FullName LIKE @k";

            if (cbRoleUser.SelectedValue != null) sql += " AND u.RoleID = " + cbRoleUser.SelectedValue;
            LoadDataWithParams(sql, dataGridViewUserAccounts, new SqlParameter("@k", "%" + txtSearchUser.Text + "%"));

            foreach (DataGridViewRow row in dataGridViewUserAccounts.Rows)
            {
                if (row.Cells["IsLocked"].Value != null && row.Cells["IsLocked"].Value != DBNull.Value && (bool)row.Cells["IsLocked"].Value == true)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            lbCountUser.Text = "Count: " + dataGridViewUserAccounts.Rows.Count;
        }

        private void ShowUserForm(int? empId)
        {
            Form f = new Form { Text = empId == null ? "Create Account" : "Edit Account", Size = new Size(400, 300), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };
            int x = 120, y = 30, w = 230;

            ComboBox cbEmp = new ComboBox { Location = new Point(x, y), Width = w, DropDownStyle = ComboBoxStyle.DropDownList };
            if (empId == null) FillComboBox(cbEmp, "SELECT EmployeeID, FullName FROM Employees WHERE EmployeeID NOT IN (SELECT EmployeeID FROM UserAccounts)", "FullName", "EmployeeID");
            else
            {
                FillComboBox(cbEmp, "SELECT EmployeeID, FullName FROM Employees", "FullName", "EmployeeID");
                cbEmp.SelectedValue = empId;
                cbEmp.Enabled = false;
            }
            f.Controls.AddRange(new Control[] { new Label { Text = "Employee:", Location = new Point(20, y + 3) }, cbEmp });

            y += 50;
            TextBox tU = new TextBox { Location = new Point(x, y), Width = w };
            f.Controls.AddRange(new Control[] { new Label { Text = "Username:", Location = new Point(20, y + 3) }, tU });

            y += 50;
            ComboBox cbR = new ComboBox { Location = new Point(x, y), Width = w, DropDownStyle = ComboBoxStyle.DropDownList };
            FillComboBox(cbR, "SELECT RoleID, RoleName FROM Roles", "RoleName", "RoleID");
            f.Controls.AddRange(new Control[] { new Label { Text = "Role:", Location = new Point(20, y + 3) }, cbR });

            y += 60;
            Button b = new Button { Text = "Save", Location = new Point(x, y), DialogResult = DialogResult.OK, BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 100, Height = 35 };
            f.Controls.Add(b); f.AcceptButton = b;

            if (empId != null && dataGridViewUserAccounts.CurrentRow != null)
            {
                tU.Text = dataGridViewUserAccounts.CurrentRow.Cells["Username"].Value.ToString();
                cbR.Text = dataGridViewUserAccounts.CurrentRow.Cells["RoleName"].Value.ToString();
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (cbEmp.SelectedValue == null || cbR.SelectedValue == null || string.IsNullOrEmpty(tU.Text)) return;
                string sql = empId == null ?
                    "INSERT INTO UserAccounts (EmployeeID, Username, PasswordHash, RoleID, IsLocked) VALUES (@eid, @user, '123', @rid, 0)" :
                    "UPDATE UserAccounts SET Username=@user, RoleID=@rid WHERE EmployeeID=@eid";

                ExecuteSql(sql, new SqlParameter[] {
                    new SqlParameter("@eid", empId ?? cbEmp.SelectedValue),
                    new SqlParameter("@user", tU.Text),
                    new SqlParameter("@rid", cbR.SelectedValue)
                });
                LoadUsers();
            }
        }

        private void btEditUser_Click(object s, EventArgs e)
        {
            if (dataGridViewUserAccounts.CurrentRow != null)
                ShowUserForm(Convert.ToInt32(dataGridViewUserAccounts.CurrentRow.Cells["EmployeeID"].Value));
        }

        private void ResetUserPassword()
        {
            if (dataGridViewUserAccounts.CurrentRow != null && MessageBox.Show("Reset password to '123'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteSql("UPDATE UserAccounts SET PasswordHash='123' WHERE EmployeeID=@id", new SqlParameter[] { new SqlParameter("@id", Convert.ToInt32(dataGridViewUserAccounts.CurrentRow.Cells["EmployeeID"].Value)) });
        }

        private void ToggleUserLockStatus()
        {
            if (dataGridViewUserAccounts.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridViewUserAccounts.CurrentRow.Cells["EmployeeID"].Value);
            bool cur = dataGridViewUserAccounts.CurrentRow.Cells["IsLocked"].Value != DBNull.Value && (bool)dataGridViewUserAccounts.CurrentRow.Cells["IsLocked"].Value;

            if (MessageBox.Show(cur ? "Unlock user?" : "Lock user?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExecuteSql("UPDATE UserAccounts SET IsLocked=@l WHERE EmployeeID=@id", new SqlParameter[] { new SqlParameter("@l", !cur), new SqlParameter("@id", id) });
                LoadUsers();
            }
        }
        private void tabUserAccounts_Click(object s, EventArgs e) { }
        #endregion

        #region 12. Roles 
        private void LoadRoles() => LoadDataToGrid("SELECT * FROM Roles", dataGridViewRole);

        private void SearchRoles()
        {
            string sql = "SELECT * FROM Roles WHERE RoleName LIKE @k";
            LoadDataWithParams(sql, dataGridViewRole, new SqlParameter("@k", "%" + txtKeywordRole.Text + "%"));
        }

        private void ShowRoleForm(int? id)
        {
            Form f = new Form { Text = id == null ? "Add Role" : "Edit Role", Size = new Size(350, 250), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10F) };
            TextBox tN = new TextBox { Location = new Point(100, 30), Width = 200 };
            TextBox tD = new TextBox { Location = new Point(100, 70), Width = 200, Multiline = true, Height = 60 };

            f.Controls.AddRange(new Control[] {
                new Label { Text = "Name:", Location = new Point(20, 33) }, tN,
                new Label { Text = "Desc:", Location = new Point(20, 73) }, tD
            });

            Button b = new Button { Text = "Save", Location = new Point(100, 150), DialogResult = DialogResult.OK, BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 100, Height = 35 };
            f.Controls.Add(b); f.AcceptButton = b;

            if (id != null && dataGridViewRole.CurrentRow != null)
            {
                tN.Text = dataGridViewRole.CurrentRow.Cells["RoleName"].Value.ToString();
                tD.Text = dataGridViewRole.CurrentRow.Cells["Description"].Value?.ToString();
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sql = id == null ?
                    "INSERT INTO Roles (RoleName, Description) VALUES (@n, @d)" :
                    "UPDATE Roles SET RoleName=@n, Description=@d WHERE RoleID=@id";
                ExecuteSql(sql, new SqlParameter[] { new SqlParameter("@n", tN.Text), new SqlParameter("@d", tD.Text), new SqlParameter("@id", id ?? 0) });
                LoadRoles();
                LoadAllComboBoxes();
            }
        }

        private void btEditRole_Click(object s, EventArgs e)
        {
            if (dataGridViewRole.CurrentRow != null)
                ShowRoleForm(Convert.ToInt32(dataGridViewRole.CurrentRow.Cells["RoleID"].Value));
        }
        #endregion

        #region 13. Backup & Restore
        private void PerformBackup()
        {
            if (string.IsNullOrEmpty(txtBackupPath.Text)) { MessageBox.Show("Please select save location!"); return; }
            try
            {
                string cmd = $"BACKUP DATABASE [ShopX_BTEC] TO DISK='{txtBackupPath.Text}'";
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    new SqlCommand(cmd, conn).ExecuteNonQuery();
                }
                MessageBox.Show("Backup successful!");
                listboxLogWindow.Items.Add($"[{DateTime.Now}] Backup successful to {txtBackupPath.Text}");
            }
            catch (Exception ex) { MessageBox.Show("Backup Failed: " + ex.Message); }
        }

        private void PerformRestore()
        {
            if (string.IsNullOrEmpty(txtRestore.Text)) { MessageBox.Show("Please select backup file!"); return; }
            if (MessageBox.Show("WARNING: Restore will overwrite current data. Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string connStr = DatabaseHelper.GetConnection().ConnectionString.Replace("Initial Catalog=ShopX_BTEC", "Initial Catalog=master");
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        new SqlCommand("ALTER DATABASE [ShopX_BTEC] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", conn).ExecuteNonQuery();
                        new SqlCommand($"RESTORE DATABASE [ShopX_BTEC] FROM DISK='{txtRestore.Text}' WITH REPLACE", conn).ExecuteNonQuery();
                        new SqlCommand("ALTER DATABASE [ShopX_BTEC] SET MULTI_USER", conn).ExecuteNonQuery();
                    }
                    MessageBox.Show("Restore successful! Application will restart.");
                    Application.Restart();
                }
                catch (Exception ex) { MessageBox.Show("Restore Failed: " + ex.Message); }
            }
        }
        private void lbRestoreDatabase_Click(object s, EventArgs e) { }
        #endregion

        #region 14. Helpers & Core (Common Utilities)
        private void LoadAllData()
        {
            LoadEmployees(); LoadCustomers(); LoadCategories(); LoadProducts();
            LoadOrders(); LoadOrderDetails(); LoadRoles(); LoadUsers(); LoadGoodsReceipts(); LoadInventory();
        }

        private void LoadAllComboBoxes()
        {
            FillComboBox(cbCustomerManageOrder, "SELECT CustomerID, FullName FROM Customers", "FullName", "CustomerID");

            cbStatusManageOrder.Items.Clear();
            cbStatusManageOrder.Items.AddRange(new object[] { "All", "Pending", "Paid", "Cancelled", "Refunded" });
            cbStatusManageOrder.SelectedIndex = 0;

            FillComboBox(cbPosition, "SELECT DISTINCT Position FROM Employees", "Position", "Position");
            FillComboBox(cbManageProduct, "SELECT CategoryID, CategoryName FROM Categories", "CategoryName", "CategoryID");
            FillComboBox(cbProductGoodsReceipt, "SELECT ProductID, ProductName FROM Products", "ProductName", "ProductID");
            FillComboBox(cbProductInventoryLog, "SELECT ProductID, ProductName FROM Products", "ProductName", "ProductID");
            FillComboBox(cbRoleUser, "SELECT RoleID, RoleName FROM Roles", "RoleName", "RoleID");

            cbReport.Items.Clear();
            cbReport.Items.AddRange(new object[] { "Top Selling Products", "Revenue by Date", "Low Stock Alert" });
            cbReport.SelectedIndex = 0;
        }

        private void SelectTab(TabPage tab)
        {
            if (tabControl.TabPages.Contains(tab)) tabControl.SelectedTab = tab;
        }

        private void ExportToCSV(DataGridView dgv, string f)
        {
            try
            {
                if (dgv.Rows.Count == 0) return;
                string c = "";
                foreach (DataGridViewColumn h in dgv.Columns) c += h.HeaderText + ",";
                c += "\r\n";
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        foreach (DataGridViewCell cel in r.Cells) c += cel.Value?.ToString().Replace(",", " ") + ",";
                        c += "\r\n";
                    }
                }
                File.WriteAllText(f, c);
                System.Diagnostics.Process.Start("explorer.exe", "/select, " + Path.GetFullPath(f));
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void ExecuteSql(string s, SqlParameter[] p)
        {
            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    SqlCommand m = new SqlCommand(s, c);
                    if (p != null) m.Parameters.AddRange(p);
                    m.ExecuteNonQuery();
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void LoadDataToGrid(string q, DataGridView g)
        {
            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    SqlDataAdapter d = new SqlDataAdapter(q, c);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    g.DataSource = t;
                    g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch { }
        }

        private void LoadDataWithParams(string q, DataGridView g, SqlParameter p)
        {
            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    SqlDataAdapter d = new SqlDataAdapter(q, c);
                    if (p != null) d.SelectCommand.Parameters.Add(p);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    g.DataSource = t;
                }
            }
            catch { }
        }

        private void LoadDataWithParamsList(string q, DataGridView g, List<SqlParameter> p)
        {
            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    SqlDataAdapter d = new SqlDataAdapter(q, c);
                    if (p != null) d.SelectCommand.Parameters.AddRange(p.ToArray());
                    DataTable t = new DataTable();
                    d.Fill(t);
                    g.DataSource = t;
                    g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FillComboBox(ComboBox b, string q, string d, string v)
        {
            try
            {
                using (SqlConnection c = DatabaseHelper.GetConnection())
                {
                    c.Open();
                    SqlDataAdapter a = new SqlDataAdapter(q, c);
                    DataTable t = new DataTable();
                    a.Fill(t);
                    b.DataSource = t;
                    b.DisplayMember = d;
                    b.ValueMember = v;
                    b.SelectedIndex = -1;
                }
            }
            catch { }
        }

        private void DeleteItem(string t, string k, DataGridView g, Action r)
        {
            if (g.CurrentRow == null) return;
            if (_currentUser.Role != AppRole.Admin) { MessageBox.Show("Admin only!"); return; }
            if (MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExecuteSql($"DELETE FROM {t} WHERE {k}=@id", new SqlParameter[] { new SqlParameter("@id", Convert.ToInt32(g.CurrentRow.Cells[k].Value)) });
                r();
                LoadHomeData();
            }
        }

        private void ApplyPermissions(AppRole role)
        {
            tabControl.TabPages.Clear(); SetManageProductsReadOnly(false);
            switch (role)
            {
                case AppRole.Admin: foreach (var t in _allTabs) tabControl.TabPages.Add(t); break;
                case AppRole.Sales: AddTabs(tabHome, tabManageCustomers, tabManageProducts, tabManageOrders, tabManageOrderDetails, tabReports); break;
                case AppRole.Warehouse: AddTabs(tabHome, tabGoodReceipt, tabInventoryLog, tabManageProducts); SetManageProductsReadOnly(true); break;
            }
            if (tabControl.TabPages.Contains(tabHome)) tabControl.SelectedTab = tabHome;
        }

        private void AddTabs(params TabPage[] tabs) { foreach (var t in tabs) if (!_IsAdded(t)) tabControl.TabPages.Add(t); }
        private bool _IsAdded(TabPage t) => tabControl.TabPages.Contains(t);
        private void SetManageProductsReadOnly(bool r) { /* Implement logic to disable buttons if needed */ }

        // Unused handlers
        private void chart1_Click(object s, EventArgs e) { }
        private void lbWelcome_Click(object s, EventArgs e) { }
        private void label2_Click(object s, EventArgs e) { }
        private void button2_Click(object s, EventArgs e) { }
        private void button5_Click(object s, EventArgs e) { }
        private void textBox3_TextChanged(object s, EventArgs e) { }
        private void pictureBox2_Click(object s, EventArgs e) { }
        private void btnDeleteEmployee_Click(object s, EventArgs e) { }
        private void tabManageEmployees_Click(object s, EventArgs e) { }
        #endregion
    }
}
