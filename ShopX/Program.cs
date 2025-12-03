using System;
using System.Windows.Forms;

namespace ShopX
{
    static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ---------------------------------------------------------
            // BƯỚC 1: KIỂM TRA KẾT NỐI DATABASE TRƯỚC KHI CHẠY
            // ---------------------------------------------------------
            // Nếu không kết nối được thì báo lỗi và tắt luôn, đỡ mất công hiện Form
            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Không thể kết nối đến Cơ sở dữ liệu!\nVui lòng kiểm tra lại 'Server Name' trong file DatabaseHelper.cs",
                                "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng chương trình
            }

            // ---------------------------------------------------------
            // BƯỚC 2: HIỂN THỊ FORM ĐĂNG NHẬP (Form1)
            // ---------------------------------------------------------
            Form1 loginForm = new Form1();

            // ShowDialog() sẽ tạm dừng code tại đây cho đến khi Form1 đóng lại
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // ---------------------------------------------------------
                // BƯỚC 3: LẤY THÔNG TIN USER ĐÃ ĐĂNG NHẬP
                // ---------------------------------------------------------
                // Trong code Form1 bạn gửi, bạn đã dùng: this.Tag = user;
                // Nên ở đây ta lấy ra từ Tag và ép kiểu về AppUser
                AppUser loggedInUser = loginForm.Tag as AppUser;

                if (loggedInUser != null)
                {
                    // ---------------------------------------------------------
                    // BƯỚC 4: CHẠY FORM CHÍNH (Form2) VỚI USER ĐÓ
                    // ---------------------------------------------------------
                    Application.Run(new Form2(loggedInUser));
                }
                else
                {
                    MessageBox.Show("Lỗi: Không lấy được thông tin tài khoản!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Người dùng tắt Form đăng nhập (ấn dấu X) -> Tắt chương trình
                Application.Exit();
            }
        }
    }
}