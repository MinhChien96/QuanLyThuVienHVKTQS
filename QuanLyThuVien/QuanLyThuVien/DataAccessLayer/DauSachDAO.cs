using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.ValueObject;

namespace QuanLyThuVien.DataAccessLayer
{
    class DauSachDAO
    {
        public static DataTable LoadCboMaTT(string proc)
        {
            return DataProvider.LayDataTable(proc);
        }
        public static DataTable LoadDgvDauSach(string proc)
        {
            return DataProvider.LayDataTable(proc);
        }
        public static DataTable LoadMaHD(string proc, string MaSach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",MaSach)
            };
            return DataProvider.LayDataTable(proc, para);
        }
        public static DataTable LoadTTHD(string proc, string MaSach, string MaHD)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach",MaSach),
                new SqlParameter("@mahd",MaHD)
            };
            return DataProvider.LayDataTable(proc, para);
        }
        public static int XoaDauSach(string MaSach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach",MaSach)
            };
            return DataProvider.Execute_NonQuery("delete_dausach", para);
        }
        public static int XoaHoaDon(string MaHD)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd",MaHD)
            };
            return DataProvider.Execute_NonQuery("delete_hoadon", para);
        }
        public static int ThemDauSach(DauSachDTO ds)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach",ds.MaSach),
                new SqlParameter("@tensach",ds.TenSach),
                new SqlParameter("@tacgia",ds.TacGia),
                new SqlParameter("@nxb",ds.NXB),
                new SqlParameter("@theloai",ds.TheLoai),
                new SqlParameter("@vitri",ds.ViTri)
            };
            SqlParameter[] para1 = new SqlParameter[]
            {
                new SqlParameter("@mahd",ds.MaHD),
                new SqlParameter("@ngaynhap",ds.NgayNhap),
                new SqlParameter("@matt",ds.MaTT)
            };
            SqlParameter[] para2 = new SqlParameter[]
            {
                new SqlParameter("@mahd",ds.MaHD),
                new SqlParameter("@masach",ds.MaSach),
                new SqlParameter("@soluong",ds.Soluong)
            };
            if (DataProvider.Execute_NonQuery("insert_hoadon", para1) == 0) return 0;
            if (DataProvider.Execute_NonQuery("insert_dausach", para) == 0)
            {
                XoaHoaDon(ds.MaHD);
                return -1;
            }
            DataProvider.Execute_NonQuery("insert_chitiethoadon", para2);
            return 1;
        }
        public static int SuaDauSach(DauSachDTO ds)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach",ds.MaSach),
                new SqlParameter("@tensach",ds.TenSach),
                new SqlParameter("@tacgia",ds.TacGia),
                new SqlParameter("@nxb",ds.NXB),
                new SqlParameter("@theloai",ds.TheLoai),
                new SqlParameter("@vitri",ds.ViTri)
            };
            SqlParameter[] para1 = new SqlParameter[]
            {
                new SqlParameter("@mahd",ds.MaHD),
                new SqlParameter("@ngaynhap",ds.NgayNhap),
                new SqlParameter("@matt",ds.MaTT)
            };
            SqlParameter[] para2 = new SqlParameter[]
            {
                new SqlParameter("@mahd",ds.MaHD),
                new SqlParameter("@masach",ds.MaSach),
                new SqlParameter("@soluong",ds.Soluong)
            };
            if (DataProvider.Execute_NonQuery("update_dausach", para) == 0) return 0;
            if (DataProvider.Execute_NonQuery("update_hoadon", para1) == 0) return -1;
            if (DataProvider.Execute_NonQuery("update_chitiethoadon", para2) == 0) return -2;
            return 1;
        }
    }
}
