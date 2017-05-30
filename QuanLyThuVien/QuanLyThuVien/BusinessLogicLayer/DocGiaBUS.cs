using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DataAccessLayer;
using QuanLyThuVien.ValueObject;

namespace QuanLyThuVien.BusinessLogicLayer
{
    class DocGiaBUS
    {
        public static DataTable LoadDgvDocGia(string proc)
        {
            return DocGiaDAO.LoadDgvDocGia(proc);
        }
        public static int XoaDocGia(string SoThe)
        {
            return DocGiaDAO.XoaDocGia(SoThe);
        }
        public static int ThemDocGia(DocGiaDTO dg)
        {
            return DocGiaDAO.ThemDocGia(dg);
        }
        public static int SuaDocGia(DocGiaDTO dg)
        {
            return DocGiaDAO.SuaDocGia(dg);
        }
    }
}
