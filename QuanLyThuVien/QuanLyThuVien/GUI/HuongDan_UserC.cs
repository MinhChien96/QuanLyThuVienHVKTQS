using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class HuongDan_UserC : UserControl
    {
        public HuongDan_UserC()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "Về phần mềm")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/ThietKe.html");
            }
            if (e.Node.Text == "Thêm mới đầu sách")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Themds.html");
            }
            if (e.Node.Text == "Sửa đầu sách")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Suads.html");
            }
            if (e.Node.Text == "Xóa đầu sách")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Xoads.html");
            }
            if (e.Node.Text == "Tìm kiếm đầu sách")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Timkiemds.html");
            }
            if (e.Node.Text == "Thêm đọc giả")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Themdg.html");
            }
            if (e.Node.Text == "Sửa đọc giả")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Suadg.html");
            }
            if (e.Node.Text == "Xóa đọc giả")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Xoadg.html");
            }
            if (e.Node.Text == "Tìm kiếm đọc giả")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Timkiemdg.html");
            }
            if (e.Node.Text == "Mượn sách")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Phieumuon.html");
            }
            if (e.Node.Text == "Trả sách")
            {
                webBrowser1.Navigate(@"C:\Users\Chien\Documents\Visual Studio 2015\Projects\QuanLyThuVien/Tra.html");
            }
        }
    }
}
