using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BusinessLogicLayer;
using QuanLyThuVien.ValueObject;
using QuanLyThuVien.GUI;

namespace QuanLyThuVien
{
    public partial class FormDangNhap : Form
    {
        private DataTable dt;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "") MessageBox.Show("Nhập tài khoản mật khẩu", "Thông báo");
            else
            {
                UserDTO u = new UserDTO();
                u.TaiKhoan = txtTaiKhoan.Text;
                u.MatKhau = txtMatKhau.Text;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["TaiKhoan"].ToString() == u.TaiKhoan && dt.Rows[i]["MatKhau"].ToString() == u.MatKhau)
                    {
                        FormMenu frm = new FormMenu();
                        frm.TaiKhoan = u.TaiKhoan;
                        frm.MatKhau = u.MatKhau;
                        frm.FormClosed += new FormClosedEventHandler(frm_FormClose);
                        frm.Show();
                        this.Hide();
                        return;
                        //closeForm();
                    }

                }
                MessageBox.Show("Sai tài khoản mật khẩu", "Thông báo");
                txtMatKhau.Text = "";
                txtTaiKhoan.Text = "";
            }
        }
        private void frm_FormClose(object sender, FormClosedEventArgs e)
        {
            dt = UserBUS.LoadUser();
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
            this.Show();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            dt = UserBUS.LoadUser();
        }
    }
}
