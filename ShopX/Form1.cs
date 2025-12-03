using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopX
{
    public partial class Form1 : Form
    {
        // Biến lưu thông tin người dùng để truyền sang Form chính
        public AppUser LoggedInUser { get; private set; }

        public Form1()
        {
            InitializeComponent();

            // --- CƠ CHẾ TỰ ĐỘNG KẾT NỐI SỰ KIỆN (AUTO-BINDING) ---
            // Code này giúp nút bấm luôn hoạt động dù bạn quên chỉnh trong Designer
            // 1. Nút Đăng nhập
            if (btLogin != null)
            {
                btLogin.Click -= btLogin_Click; // Gỡ bỏ cũ (tránh lỗi lặp 2 lần)
                btLogin.Click += btLogin_Click; // Gán mới (đảm bảo chạy)
            }

            // 2. Nút Thoát
            if (btExit != null)
            {
                btExit.Click -= btExit_Click;
                btExit.Click += btExit_Click;
            }

            // 3. Sự kiện khi mở Form (để kiểm tra kết nối)
            this.Load -= Form1_Load;
            this.Load += Form1_Load;
        }

        // --- SỰ KIỆN 1: KHI FORM VỪA HIỆN LÊN ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kiểm tra kết nối CSDL ngay lập tức
            if (DatabaseHelper.TestConnection())
            {
                // Nếu kết nối OK -> Không làm gì cả (hoặc hiện thông báo nếu muốn)
                // MessageBox.Show("Kết nối Database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể kết nối Database!\nVui lòng kiểm tra lại file DatabaseHelper.cs", "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SỰ KIỆN 2: BẤM NÚT LOGIN ---
        private void btLogin_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text.Trim();
            string p = txtPassword.Text.Trim();

            // 1. Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            try
            {
                // 2. Gọi hàm kiểm tra trong Database
                AppUser user = AuthenticateUser(u, p);

                if (user != null)
                {
                    // --- ĐĂNG NHẬP THÀNH CÔNG ---
                    MessageBox.Show($"Đăng nhập thành công!\nXin chào: {user.UserName} ({user.Role})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lưu thông tin user lại
                    this.LoggedInUser = user;
                    this.Tag = user; // Quan trọng: Truyền sang Program.cs

                    // Đóng Form Login để mở Form chính
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nHoặc tài khoản của bạn đã bị khóa.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xử lý đăng nhập:\n" + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SỰ KIỆN 3: BẤM NÚT THOÁT ---
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // --- HÀM LOGIC: CHECK USER TỪ DATABASE ---
        private AppUser AuthenticateUser(string username, string password)
        {
            AppUser userResult = null;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT u.EmployeeID, u.Username, r.RoleName 
                    FROM UserAccounts u
                    JOIN Roles r ON u.RoleID = r.RoleID
                    WHERE u.Username = @user AND u.PasswordHash = @pass AND u.IsLocked = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userResult = new AppUser();
                            userResult.EmployeeID = reader.GetInt32(0);
                            userResult.UserName = reader.GetString(1);

                            string roleString = reader.GetString(2);


                            if (Enum.TryParse(roleString, true, out AppRole parsedRole))
                            {
                                userResult.Role = parsedRole;
                            }
                            else
                            {
                                userResult.Role = AppRole.Sales; 
                            }
                        }
                    }
                }
            }
            return userResult;
        }

        // Các hàm rác (giữ lại để tránh lỗi Designer nếu lỡ kết nối)
        private void lbLogin_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}