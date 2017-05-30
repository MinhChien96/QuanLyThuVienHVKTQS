using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class FormMenu : Form
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public FormMenu()
        {
            InitializeComponent();
        }
        public void showControl(System.Windows.Forms.Control obj)
        {
            panelHome.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            panelHome.Controls.Add(obj);
        }

        private void quảnLýĐầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DauSach_UserC us = new DauSach_UserC();
            showControl(us);
        }

        private void quảnLýĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGia_UserC us = new DocGia_UserC();
            showControl(us);
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuon_UserC us = new PhieuMuon_UserC();
            showControl(us);
        }

        private void hướngDẫnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HuongDan_UserC us = new HuongDan_UserC();
            showControl(us);
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMK_UserC us = new DoiMK_UserC();
            us.TaiKhoan = TaiKhoan;
            us.MK = MatKhau;
            showControl(us);
        }
    }
}
