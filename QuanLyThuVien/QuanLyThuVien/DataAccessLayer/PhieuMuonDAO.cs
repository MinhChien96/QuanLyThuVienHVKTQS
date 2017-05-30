using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuVien.DataAccessLayer
{
    class PhieuMuonDAO
    {
        public static DataTable LoadDgvPhieuMuon()
        {
            return DataProvider.LayDataTable("select_phieumuon");
        }
        public static DataTable LayTTDG(string SoThe)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",SoThe)
            };
            return DataProvider.LayDataTable("select_1docgia", para);
        }
        public static DataTable LayTTSach(string MaSach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach",MaSach)
            };
            return DataProvider.LayDataTable("select_sach", para);
        }
        public static DataTable KiemTraNgayTra(string SoThe)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",SoThe)
            };
            return DataProvider.LayDataTable("select_ngaytra", para);
        }
        public static DataTable LoadDgvSach(string SoThe,string MaPhieu)
        {
            int maphieu = int.Parse(MaPhieu);
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",SoThe),
                new SqlParameter("@maphieu",maphieu)
            };
            return DataProvider.LayDataTable("select_sachmuon", para);
        }
        public static int ThemPhieuMuon(string SoThe,DateTime NgayMuon,DateTime NgayTra,string MaTT)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",SoThe),
                new SqlParameter("@ngaymuon",NgayMuon),
                new SqlParameter("@ngaytra",NgayTra),
                new SqlParameter("@matt",MaTT)
            };
            return DataProvider.Execute_NonQuery("insert_phieumuon", para);
        }
        public static int ThemChiTiet(int Macs,int MaPhieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macs", Macs),
                new SqlParameter("@maphieu", MaPhieu)
            };
            return DataProvider.Execute_NonQuery("insert_chitietphieumuon", para);
        }
        public static DataTable LayData(string proc,string SoThe)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",SoThe)
            };
            return DataProvider.LayDataTable(proc, para);
        }
        public static int SuaPhieuMuon(int MaPhieu,string SoThe, DateTime NgayMuon, DateTime NgayTra, string MaTT)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",MaPhieu),
                new SqlParameter("@sothe",SoThe),
                new SqlParameter("@ngaymuon",NgayMuon),
                new SqlParameter("@ngaytra",NgayTra),
                new SqlParameter("@matt",MaTT)
            };
            return DataProvider.Execute_NonQuery("update_phieumuon", para);
        }
        public static int XoaChiTiet(int MaPhieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",MaPhieu)
            };
            return DataProvider.Execute_NonQuery("delete_chitiet", para);
        }
        public static int XoaPhieuMuon(int MaPhieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",MaPhieu)
            };
            return DataProvider.Execute_NonQuery("delete_phieumuon", para);
        }
    }
}
