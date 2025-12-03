using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopX
{
    public static class DatabaseHelper
    {
        // Chuỗi kết nối
        private static readonly string strKetNoi = @"Data Source=LAPTOP-GAMING\SQLEXPRESS;Initial Catalog=ShopX_BTEC;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(strKetNoi);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // --- THÊM DÒNG NÀY ---
                    MessageBox.Show("Kết nối CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ---------------------

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}