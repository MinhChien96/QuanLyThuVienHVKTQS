using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BusinessLogicLayer;

namespace QuanLyThuVien.GUI
{
    public partial class DoiMK_UserC : UserControl
    {
        public string TaiKhoan { get; set; }
        public string MK { get; set; }
        public DoiMK_UserC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != MK)
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo");
                LoadLaiForm();
                return;
            }
            else if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo");
                LoadLaiForm();
                return;
            }
            if (UserBUS.DoiMK( TaiKhoan, txtMatKhauMoi.Text) != 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                MK = txtMatKhauMoi.Text;
            }
            else MessageBox.Show("Đổi mật khẩu thất bại");
            LoadLaiForm();
        }
        private void LoadLaiForm()
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXacNhan.Text = "";
        }
        private bool Kiemtra(char e)
        {
            int x = (int)e;
            if ((x >= 48 && x <= 57) || (x >= 65 && x <= 90) || (x >= 97 && x <= 122)) return true;
            else return false;
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Kiemtra(e.KeyChar))
                e.Handled = true;
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Kiemtra(e.KeyChar))
                e.Handled = true;
        }

        private void txtXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Kiemtra(e.KeyChar))
                e.Handled = true;
        }
    }
}
