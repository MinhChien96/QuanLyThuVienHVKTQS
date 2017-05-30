using QuanLyThuVien.BusinessLogicLayer;
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
    public partial class FormSach : Form
    {
        private DataTable dt1;
        public DataTable dt = new DataTable();
        private int i=-1;
        public delegate void Truyen(DataTable dt);
        public Truyen T;
        public FormSach()
        {
            InitializeComponent();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            //dt.Columns.Add(new DataColumn("tensach", typeof(string)));
            //dt.Columns.Add(new DataColumn("tacgia", typeof(string)));
            //dt.Columns.Add(new DataColumn("nxb", typeof(string)));
            dgvSach.DataSource = dt;
            dgvSach.Columns["macs"].HeaderText = "Mã sách";
            dgvSach.Columns["tacgia"].HeaderText = "Tác giả";
            dgvSach.Columns["tensach"].HeaderText = "Tên sách";
            dgvSach.Columns["nxb"].HeaderText = "Nhà XB";
            dgvSach.AutoResizeColumns();
        }

        private void txtMasach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtMasach.Text != "")
            {
                if (txtMasach.Text == "")
                    MessageBox.Show("Nhập mã sách");
                else
                {
                    dt1 = PhieuMuonBUS.LayTTSach(txtMasach.Text);
                    if (dt1 == null || dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("Nhập sai mã sách");
                        txtMasach.Text = "";
                    }
                    else
                    {
                        txtTenSach.Text = dt1.Rows[0]["tensach"].ToString();
                        txtTacGia.Text = dt1.Rows[0]["tacgia"].ToString();
                    }
                }
            }
        }
        void LoadForm()
        {
            txtTacGia.Text = "";
            txtTenSach.Text = "";
            txtMasach.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMasach.Text != "")
            {
                DataRow dr = dt1.Rows[0];
                dt.ImportRow(dr);
                dgvSach.AutoResizeColumns();
                LoadForm();
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                i = e.RowIndex;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Xóa sách"), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(i!=-1)
                {
                    dt.Rows.RemoveAt(i);
                    i = -1;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            T(dt);
            this.Close();
        }
        private void FormSach_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
