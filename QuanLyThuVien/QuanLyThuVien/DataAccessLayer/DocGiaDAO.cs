using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.ValueObject;

namespace QuanLyThuVien.DataAccessLayer
{
    class DocGiaDAO
    {
        public static DataTable LoadDgvDocGia(string proc)
        {
            return DataProvider.LayDataTable(proc);
        }
        public static int XoaDocGia(string SoThe)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",SoThe)
            };
            return DataProvider.Execute_NonQuery("delete_docgia", para);
        }
        public static int ThemDocGia(DocGiaDTO dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",dg.SoThe),
                new SqlParameter("@tendg",dg.HoTen),
                new SqlParameter("@ngaysinh",dg.NgaySinh),
                new SqlParameter("@diachi",dg.DiaChi),
                new SqlParameter("@cmt",dg.CMT),
                new SqlParameter("@ngaylam",dg.NgayLam),
                new SqlParameter("@ngayhethan",dg.NgayHetHan)
            };
            return DataProvider.Execute_NonQuery("insert_docgia", para);
        }
        public static int SuaDocGia(DocGiaDTO dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sothe",dg.SoThe),
                new SqlParameter("@tendg",dg.HoTen),
                new SqlParameter("@ngaysinh",dg.NgaySinh),
                new SqlParameter("@diachi",dg.DiaChi),
                new SqlParameter("@cmt",dg.CMT),
                new SqlParameter("@ngaylam",dg.NgayLam),
                new SqlParameter("@ngayhethan",dg.NgayHetHan)
            };
            return DataProvider.Execute_NonQuery("update_docgia", para);
        }
    }
}
