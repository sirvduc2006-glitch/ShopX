using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopX
{
    // Định nghĩa các quyền hạn
    public enum AppRole
    {
        Admin,
        Sales,
        Warehouse
    }

    // Định nghĩa đối tượng người dùng đăng nhập
    public class AppUser
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public AppRole Role { get; set; }
    }
}