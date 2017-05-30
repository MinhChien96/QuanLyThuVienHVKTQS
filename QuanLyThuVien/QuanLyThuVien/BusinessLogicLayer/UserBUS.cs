using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DataAccessLayer;

namespace QuanLyThuVien.BusinessLogicLayer
{
    class UserBUS
    {
        public static DataTable LoadUser()
        {
            return UserDAO.LoadUser();
        }
        public static int DoiMK(string TaiKhoan, string MK)
        {
            return UserDAO.DoiMK(TaiKhoan, MK);
        }
    }
}
