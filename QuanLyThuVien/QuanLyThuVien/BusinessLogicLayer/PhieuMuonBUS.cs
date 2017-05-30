using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DataAccessLayer;
using System.Data;

namespace QuanLyThuVien.BusinessLogicLayer
{
    class PhieuMuonBUS
    {
        public static DataTable LoadDgvPhieuMuon()
        {
            return PhieuMuonDAO.LoadDgvPhieuMuon();
        }
        public static DataTable LayTTDG(string SoThe)
        {
            return PhieuMuonDAO.LayTTDG(SoThe);
        }
        public static DataTable LayTTSach(string MaSach)
        {
            return PhieuMuonDAO.LayTTSach(MaSach);
        }
        public static DataTable KiemTraNgayTra(string SoThe)
        {
            return PhieuMuonDAO.KiemTraNgayTra(SoThe);
        }
        public static DataTable LoadDgvSach(string SoThe,string MaPhieu)
        {
            return PhieuMuonDAO.LoadDgvSach(SoThe,MaPhieu);
        }
        public static int ThemPhieuMuon(string SoThe, DateTime NgayMuon, DateTime NgayTra, string MaTT)
        {
            return PhieuMuonDAO.ThemPhieuMuon(SoThe, NgayMuon, NgayTra, MaTT);
        }
        public static int ThemChiTiet(int Macs, int MaPhieu)
        {
            return PhieuMuonDAO.ThemChiTiet(Macs, MaPhieu);
        }
        public static DataTable LayData(string proc, string SoThe)
        {
            return PhieuMuonDAO.LayData(proc, SoThe);
        }
        public static int SuaPhieuMuon(int MaPhieu, string SoThe, DateTime NgayMuon, DateTime NgayTra, string MaTT)
        {
            return PhieuMuonDAO.SuaPhieuMuon(MaPhieu,SoThe, NgayMuon, NgayTra, MaTT);
        }
        public static int XoaChiTiet(int MaPhieu)
        {
            return PhieuMuonDAO.XoaChiTiet(MaPhieu);
        }
        public static int XoaPhieuMuon(int MaPhieu)
        {
            return PhieuMuonDAO.XoaPhieuMuon(MaPhieu);
        }
    }
}
