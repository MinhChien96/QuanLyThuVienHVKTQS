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
using QuanLyThuVien.ValueObject;

namespace QuanLyThuVien.GUI
{
    public partial class DocGia_UserC : UserControl
    {
        private DataView dv;
        private int kt = 1;
        private int luu = 0;
        public DocGia_UserC()
        {
            InitializeComponent();
        }
        void LoadDgvDocGia()
        {
            DataTable dt = DocGiaBUS.LoadDgvDocGia("select_docgia");
            dv = new DataView(dt);
            dgvDocGia.DataSource = dt;
            dgvDocGia.Columns["sothe"].HeaderText = "Số thẻ";
            dgvDocGia.Columns["tendg"].HeaderText = "Họ tên";
            dgvDocGia.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvDocGia.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvDocGia.Columns["cmt"].HeaderText = "CMT";
            dgvDocGia.Columns["ngaylam"].HeaderText = "Ngày làm";
            dgvDocGia.Columns["ngayhethan"].HeaderText = "Ngày hết hạn";
            //dgvDocGia.AutoResizeColumns();
            dgvDocGia.AutoResizeColumn(1); dgvDocGia.AutoResizeColumn(0);
            dgvDocGia.ReadOnly = true;
        }
        private void DocGia_UserC_Load(object sender, EventArgs e)
        {
            LoadDgvDocGia();
            
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.ColumnIndex >= 0) && kt == 1)
            {
                txtSoThe.Text = dgvDocGia.CurrentRow.Cells["sothe"].Value.ToString();
                txtHoTen.Text = dgvDocGia.CurrentRow.Cells["tendg"].Value.ToString();
                txtDiaChi.Text = dgvDocGia.CurrentRow.Cells["diachi"].Value.ToString();
                txtCMT.Text = dgvDocGia.CurrentRow.Cells["cmt"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvDocGia.CurrentRow.Cells["ngaysinh"].Value.ToString());
                dtpNgayLam.Value = DateTime.Parse(dgvDocGia.CurrentRow.Cells["ngaylam"].Value.ToString());
                dtpNgayHetHan.Value = DateTime.Parse(dgvDocGia.CurrentRow.Cells["ngayhethan"].Value.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 0; luu = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 0; luu = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtSoThe.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Xóa số thẻ {0} tên đọc giả {1}", dgvDocGia.CurrentRow.Cells["sothe"].Value.ToString(), dgvDocGia.CurrentRow.Cells["tendg"].Value.ToString()), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DocGiaBUS.XoaDocGia(dgvDocGia.CurrentRow.Cells["sothe"].Value.ToString()) != 0)
                {
                    MessageBox.Show("Xóa thành công");LoadForm();
                    DocGia_UserC_Load(sender, e);
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtCMT.Text==""||txtDiaChi.Text==""||txtHoTen.Text==""||txtSoThe.Text==""||dtpNgaySinh.Value==DateTime.Now)
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            DocGiaDTO dg = new DocGiaDTO();
            dg.CMT = txtCMT.Text;
            dg.DiaChi = txtDiaChi.Text;
            dg.HoTen = txtHoTen.Text;
            dg.SoThe = txtSoThe.Text;
            dg.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
            dg.NgayLam = DateTime.Parse(dtpNgayLam.Value.ToString("dd/MM/yyyy"));
            dg.NgayHetHan = DateTime.Parse(dtpNgayHetHan.Value.ToString("dd/MM/yyyy"));
            if (luu == 1)
            {
                if (MessageBox.Show(string.Format("Thêm số thẻ {0} đọc giả {1}", dg.SoThe,dg.HoTen), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (DocGiaBUS.ThemDocGia(dg) != 0)
                    {
                        MessageBox.Show("Đã thêm");
                        DocGia_UserC_Load(sender, e);
                    }
                    else MessageBox.Show("Đọc giả đã tồn tại");
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Cập nhật số thẻ {0} đọc giả {1}", dg.SoThe, dg.HoTen), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (DocGiaBUS.SuaDocGia(dg) != 0)
                    {
                        MessageBox.Show("Đã sửa");
                        DocGia_UserC_Load(sender, e);
                    }
                    else MessageBox.Show("Cập nhật thất bại");
                }
            }
            kt = 1;
            LoadForm();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            kt = 1; LoadForm(); luu = 0;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtSoThe.Enabled = true;
        }
        void LoadForm()
        {
            txtCMT.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtSoThe.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayLam.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;
        }

        private void chkSoThe_Click(object sender, EventArgs e)
        {
            if (chkSoThe.Checked == true)
            {
                txtTKSoThe.Enabled = true;
            }
            else
            {
                txtTKSoThe.Text = "";
                txtTKSoThe.Enabled = false;
            }
        }

        private void chkHoTen_Click(object sender, EventArgs e)
        {
            if (chkHoTen.Checked == true)
            {
                txtTKHoTen.Enabled = true;
            }
            else
            {
                txtTKHoTen.Text = "";
                txtTKHoTen.Enabled = false;
            }

        }

        private void chkCMT_Click(object sender, EventArgs e)
        {
            if (chkCMT.Checked == true)
            {
                txtTKCMT.Enabled = true;
            }
            else
            {
                txtTKCMT.Text = "";
                txtTKCMT.Enabled = false;
            }
        }

        private void txtTKSoThe_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[sothe] like '%" + txtTKSoThe.Text + "%' and [tendg] like '%" + txtTKHoTen.Text + "%' and [cmt] like '%" + txtTKCMT.Text + "%'";
            dgvDocGia.DataSource = dv;
        }

        private void txtTKHoTen_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[sothe] like '%" + txtTKSoThe.Text + "%' and [tendg] like '%" + txtTKHoTen.Text + "%' and [cmt] like '%" + txtTKCMT.Text + "%'";
            dgvDocGia.DataSource = dv;
        }

        private void txtTKCMT_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[sothe] like '%" + txtTKSoThe.Text + "%' and [tendg] like '%" + txtTKHoTen.Text + "%' and [cmt] like '%" + txtTKCMT.Text + "%'";
            dgvDocGia.DataSource = dv;
        }
    }
}
