using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DataAccessLayer;
using System.Data;
using QuanLyThuVien.ValueObject;

namespace QuanLyThuVien.BusinessLogicLayer
{
    class DauSachBUS
    {
        public static DataTable LoadCboMaTT(string proc)
        {
            return DauSachDAO.LoadCboMaTT(proc);
        }
        public static DataTable LoadDgvDauSach(string proc)
        {
            return DauSachDAO.LoadDgvDauSach(proc);
        }

        public static DataTable LoadMaHD(string proc, string MaSach)
        {
            return DauSachDAO.LoadMaHD(proc, MaSach);
        }
        public static DataTable LoadTTHD(string proc, string MaSach,string MaHD)
        {
            return DauSachDAO.LoadTTHD(proc,MaSach,MaHD);
        }
        public static int XoaDauSach(string MaSach)
        {
            return DauSachDAO.XoaDauSach(MaSach);
        }
        public static int ThemDauSach(DauSachDTO ds)
        {
            return DauSachDAO.ThemDauSach(ds);
        }
        public static int SuaDauSach(DauSachDTO ds)
        {
            return DauSachDAO.SuaDauSach(ds);
        }
    }
}
