using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThuVien.DataAccessLayer
{
    class DataProvider
    {
        public static SqlConnection conn;

        public static SqlConnection KetNoi()
        {
            string strConn = @"Server=MINHCHIEN\SQLEXPRESS; Database=QuanLyThuVien; Integrated Security=True";
            conn = new SqlConnection(strConn);
            conn.Open();
            return conn;
        }

        public static void DongKetNoi(SqlConnection conn)//đóng kết nối
        {
            conn.Close();
        }

        public static DataTable LayDataTable(string proc)
        {
            try
            {
                DataTable dt = new DataTable();
                conn = KetNoi();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public static DataTable LayDataTable(string proc, SqlParameter[] para)
        {
            try
            {
                DataTable dt = new DataTable();
                conn = KetNoi();
                SqlCommand cmd = new SqlCommand(proc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public static int Execute_NonQuery(string proc, SqlParameter[] para)
        {
            try
            {
                conn = KetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i;

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
