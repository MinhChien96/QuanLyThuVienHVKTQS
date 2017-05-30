using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DataAccessLayer
{
    class UserDAO
    {
        public static DataTable LoadUser()
        {
            return DataProvider.LayDataTable("select_user");
        }
        public static int DoiMK(string TaiKhoan,string MK)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@taikhoan",TaiKhoan),
                new SqlParameter("@matkhau",MK)
            };
            return DataProvider.Execute_NonQuery("update_user", para);
        }
    }
}
