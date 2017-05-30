using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QuanLyThuVien.BusinessLogicLayer;
using QuanLyThuVien.ValueObject;

namespace QuanLyThuVien.GUI
{
    public partial class DauSach_UserC : UserControl
    {
        private DataView dv;
        private int kt = 1;
        private int luu = 0;
        public DauSach_UserC()
        {
            InitializeComponent();
        }
        private void LoadCboMaTT()
        {
            DataTable dt = DauSachBUS.LoadCboMaTT("select_matt");
            cboMaTT.DataSource = dt;
            cboMaTT.DisplayMember = "matt";
            cboMaTT.ValueMember = "matt";
        }
        private void LoadTTHD(string MaHD, string MaSach)
        {
            DataTable dt = DauSachBUS.LoadTTHD("select_tthd", MaSach, MaHD);
            cboMaTT.DataSource = dt;
            cboMaTT.ValueMember = "matt";
            cboMaTT.DisplayMember = "matt";
            dtpNgayNhap.Value = DateTime.Parse(dt.Rows[0]["ngaynhap"].ToString());
            //dgvDauSach.DataSource = dt;
            txtSoLuong.Text = dt.Rows[0]["soluong"].ToString();
        }
        private void LoadDgvDauSach()
        {
            DataTable dt = DauSachBUS.LoadDgvDauSach("select_dgvdausach");
            dv = new DataView(dt);
            dgvDauSach.DataSource = dt;
            dgvDauSach.Columns["masach"].HeaderText = "Mã sách";
            dgvDauSach.Columns["tensach"].HeaderText = "Tên sách";
            dgvDauSach.Columns["tacgia"].HeaderText = "Tác giả";
            dgvDauSach.Columns["theloai"].HeaderText = "Thể loại";
            dgvDauSach.Columns["vitri"].HeaderText = "Vị trí";
            dgvDauSach.Columns["nxb"].HeaderText = "NXB";
            dgvDauSach.AutoResizeColumns();
            dgvDauSach.ReadOnly = true;
        }
        private void DauSach_UserC_Load(object sender, EventArgs e)
        {
            LoadCboMaTT();
            LoadDgvDauSach();
        }

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.ColumnIndex >= 0) && kt == 1)
            {
                txtMaSach.Text = dgvDauSach.CurrentRow.Cells["masach"].Value.ToString();
                txtTenSach.Text = dgvDauSach.CurrentRow.Cells["tensach"].Value.ToString();
                txtTacGia.Text = dgvDauSach.CurrentRow.Cells["tacgia"].Value.ToString();
                txtTheLoai.Text = dgvDauSach.CurrentRow.Cells["theloai"].Value.ToString();
                txtViTri.Text = dgvDauSach.CurrentRow.Cells["vitri"].Value.ToString();
                txtNhaXB.Text = dgvDauSach.CurrentRow.Cells["nxb"].Value.ToString();
                DataTable dt = DauSachBUS.LoadMaHD("select_mahd", txtMaSach.Text);
                cboMaHD.DataSource = dt;
                cboMaHD.DisplayMember = "mahd";
                cboMaHD.ValueMember = "mahd";
                string a = cboMaHD.SelectedValue.ToString();
                int tong = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tong += int.Parse(dt.Rows[i]["soluong"].ToString());
                }
                txtTongSoLuong.Text = tong.ToString();
                txtTongSoLuong.Enabled = true;
                lblSoLuong.Enabled = true;
            }
        }

        private void cboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadTTHD(cboMaHD.SelectedValue.ToString(), txtMaSach.Text);
        }

        private void cboMaHD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadTTHD(cboMaHD.SelectedValue.ToString(), txtMaSach.Text);
        }
        private void LoadForm()
        {
            cboMaHD.DataSource = null;
            LoadCboMaTT();
            dtpNgayNhap.Value = DateTime.Now;
            txtSoLuong.Text = "";
            txtMaSach.Text = "";
            txtNhaXB.Text = "";
            txtTacGia.Text = "";
            txtTenSach.Text = "";
            txtTheLoai.Text = "";
            txtTongSoLuong.Text = "";
            txtViTri.Text = "";
            txtTongSoLuong.Enabled = false;
            lblSoLuong.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 0; luu = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTongSoLuong.Enabled = false;
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
            cboMaHD.Enabled = false;
            LoadCboMaTT();
            //cboMaTT.Enabled = false;
            txtMaSach.Enabled = false;
            txtTongSoLuong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Xóa mã sách {0} tên sách {1}", dgvDauSach.CurrentRow.Cells["masach"].Value.ToString(), dgvDauSach.CurrentRow.Cells["tensach"].Value.ToString()), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DauSachBUS.XoaDauSach(dgvDauSach.CurrentRow.Cells["masach"].Value.ToString()) != 0)
                {
                    MessageBox.Show("Xóa thành công");
                    DauSach_UserC_Load(sender, e);
                }
                else MessageBox.Show("Xóa thất bại");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            kt = 1; LoadForm(); luu = 0;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboMaHD.Enabled = true;
            //cboMaTT.Enabled = true;
            txtMaSach.Enabled = true;
            txtTongSoLuong.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (/*cboMaHD.SelectedText == "" ||*/ dtpNgayNhap.Value == DateTime.Now || txtSoLuong.Text == "" || txtMaSach.Text == "" || txtTenSach.Text == "" || txtTacGia.Text == "" || txtNhaXB.Text == "" || txtTheLoai.Text == "" || txtViTri.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            DauSachDTO ds = new DauSachDTO();
            ds.MaHD = cboMaHD.Text;
            ds.MaTT = cboMaTT.Text;
            ds.NgayNhap = DateTime.Parse(dtpNgayNhap.Value.ToString("dd/MM/yyyy"));
            ds.Soluong = int.Parse(txtSoLuong.Text);
            ds.MaSach = txtMaSach.Text;
            ds.TenSach = txtTenSach.Text;
            ds.TacGia = txtTacGia.Text;
            ds.NXB = txtNhaXB.Text;
            ds.TheLoai = txtTheLoai.Text;
            ds.ViTri = txtViTri.Text;
            if (luu == 1)
            {
                if (MessageBox.Show(string.Format("Thêm đầu sách {0} tên sách {1} hóa đơn {2}", ds.MaSach, ds.TenSach, ds.MaHD), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    switch (DauSachBUS.ThemDauSach(ds))
                    {
                        case 0:
                            MessageBox.Show("Mã hóa đơn đã tồn tại");
                            break;
                        case 1:
                            MessageBox.Show("Đã thêm");
                            DauSach_UserC_Load(sender, e);
                            btnHuy_Click(sender, e);
                            break;
                        case -1:
                            MessageBox.Show("Mã đầu sách đã tồn tại");
                            break;
                        default:break;
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Cập nhật đầu sách {0} tên sách {1} hóa đơn {2}", ds.MaSach, ds.TenSach, ds.MaHD), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    switch (DauSachBUS.SuaDauSach(ds))
                    {
                        case 0:
                            MessageBox.Show("Cập nhật đầu sách lỗi");
                            break;
                        case 1:
                            MessageBox.Show("Cập nhật thành công");
                            DauSach_UserC_Load(sender, e);
                            btnHuy_Click(sender, e);
                            break;
                        case -1:
                            MessageBox.Show("Cập nhật hóa đơn lỗi");
                            break;
                        default: break;
                    }
                }
            }
        }

        private void txtTKMaSach_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[masach] like '%" + txtTKMaSach.Text + "%' and [tensach] like '%" + txtTKTenSach.Text + "%' and [theloai] like '%" + txtTKTheloai.Text + "%' and [tacgia] like '%" + txtTKTacGia.Text + "%'";
            dgvDauSach.DataSource = dv;
        }

        private void chkMaSach_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void chkMaSach_Click(object sender, EventArgs e)
        {
            if (chkMaSach.Checked == true)
            {
                txtTKMaSach.Enabled = true;
            }
            else
            {
                txtTKMaSach.Text = "";
                txtTKMaSach.Enabled = false;
            }
        }

        private void chkTenSach_Click(object sender, EventArgs e)
        {
            if (chkTenSach.Checked == true)
            {
                txtTKTenSach.Enabled = true;
            }
            else
            {
                txtTKTenSach.Text = "";
                txtTKTenSach.Enabled = false;
            }
        }

        private void chkTheLoai_Click(object sender, EventArgs e)
        {
            if (chkTheLoai.Checked == true)
            {
                txtTKTheloai.Enabled = true;
            }
            else
            {
                txtTKTheloai.Text = "";
                txtTKTheloai.Enabled = false;
            }
        }

        private void chkTacGia_Click(object sender, EventArgs e)
        {
            if (chkTacGia.Checked == true)
            {
                txtTKTacGia.Enabled = true;
            }
            else
            {
                txtTKTacGia.Text = "";
                txtTKTacGia.Enabled = false;
            }
        }

        private void txtTKTenSach_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[masach] like '%" + txtTKMaSach.Text + "%' and [tensach] like '%" + txtTKTenSach.Text + "%' and [theloai] like '%" + txtTKTheloai.Text + "%' and [tacgia] like '%" + txtTKTacGia.Text + "%'";
            dgvDauSach.DataSource = dv;
        }

        private void txtTKTheloai_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[masach] like '%" + txtTKMaSach.Text + "%' and [tensach] like '%" + txtTKTenSach.Text + "%' and [theloai] like '%" + txtTKTheloai.Text + "%' and [tacgia] like '%" + txtTKTacGia.Text + "%'";
            dgvDauSach.DataSource = dv;
        }

        private void txtTKTacGia_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[masach] like '%" + txtTKMaSach.Text + "%' and [tensach] like '%" + txtTKTenSach.Text + "%' and [theloai] like '%" + txtTKTheloai.Text + "%' and [tacgia] like '%" + txtTKTacGia.Text + "%'";
            dgvDauSach.DataSource = dv;
        }
    }
}
