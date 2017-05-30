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
    public partial class PhieuMuon_UserC : UserControl
    {
        public DataTable dts = new DataTable();
        private DataView dv;
        private int kt = 1;
        private int luu = 0;
        public PhieuMuon_UserC()
        {
            InitializeComponent();
            dts.Columns.Add(new DataColumn("macs", typeof(string)));
            dts.Columns.Add(new DataColumn("tensach", typeof(string)));
            dts.Columns.Add(new DataColumn("tacgia", typeof(string)));
            dts.Columns.Add(new DataColumn("nxb", typeof(string)));
            dgvSach.DataSource = dts;
            dgvSach.Columns["macs"].HeaderText = "Mã sách";
            dgvSach.Columns["tensach"].HeaderText = "Tên sách";
            dgvSach.Columns["tacgia"].HeaderText = "Tác giả";
            dgvSach.Columns["nxb"].HeaderText = "Nhà XB";
        }
        void LoadDgvMuon()
        {
            DataTable dt = PhieuMuonBUS.LoadDgvPhieuMuon();
            dgvMuon.DataSource = dt;
            dv = new DataView(dt);
            dgvMuon.Columns["maphieu"].HeaderText = "Mã phiếu";
            dgvMuon.Columns["sothe"].HeaderText = "Số thẻ";
            dgvMuon.Columns["tendg"].HeaderText = "Họ tên";
            dgvMuon.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvMuon.Columns["cmt"].HeaderText = "CMT";
            dgvMuon.Columns["ngaymuon"].HeaderText = "Ngày mượn";
            dgvMuon.Columns["ngaytra"].HeaderText = "Ngày trả";
            dgvMuon.Columns["matt"].HeaderText = "Mã TT";
            dgvMuon.ReadOnly = true;
        }
        private void PhieuMuon_UserC_Load(object sender, EventArgs e)
        {
            LoadDgvMuon();
        }

        private void txtSoThe_Leave(object sender, EventArgs e)
        {
            //if (txtSoThe.Text == "")
            //    MessageBox.Show("Nhập số thẻ người mượn");
            //else
            //{
            //    DataTable dt = PhieuMuonBUS.LayTTDG(txtSoThe.Text);
            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Nhập sai số thẻ");
            //        txtSoThe.Text = "";
            //    }
            //    else
            //    {
            //        txtHoTen.ReadOnly = true;
            //        txtHoTen.Text = dt.Rows[0]["tendg"].ToString();
            //        txtNgaySinh.Text = dt.Rows[0]["ngaysinh"].ToString();
            //        txtCMT.Text = dt.Rows[0]["cmt"].ToString();
            //    }
            //}
        }

        private void txtSoThe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSoThe.Text != "")
            {
                if (txtSoThe.Text == "")
                    MessageBox.Show("Nhập số thẻ người mượn");
                else
                {
                    DataTable dt = PhieuMuonBUS.LayTTDG(txtSoThe.Text);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nhập sai số thẻ");
                        txtSoThe.Text = "";
                    }
                    else
                    {
                        txtHoTen.ReadOnly = true;
                        txtHoTen.Text = dt.Rows[0]["tendg"].ToString();
                        txtNgaySinh.Text = dt.Rows[0]["ngaysinh"].ToString();
                        txtCMT.Text = dt.Rows[0]["cmt"].ToString();
                        dt = PhieuMuonBUS.KiemTraNgayTra(txtSoThe.Text);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (DateTime.Parse(dt.Rows[i]["ngaytra"].ToString()) < DateTime.Now)
                            {
                                MessageBox.Show("Đọc giả quá hạn chưa trả sách,không được mượn");
                                LoadForm();
                            }
                        }
                    }
                }
            }
        }
        public void Nhan(DataTable dt1)
        {
            dts = dt1.Copy(); dgvSach.DataSource = dts;
            dgvSach.Columns["tensach"].HeaderText = "Tên sách";
            dgvSach.Columns["tacgia"].HeaderText = "Tác giả";
            dgvSach.Columns["nxb"].HeaderText = "Nhà XB";
            dgvSach.AutoResizeColumns();
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            FormSach fr = new FormSach();
            fr.dt = dts;
            fr.T = new FormSach.Truyen(Nhan);
            fr.ShowDialog();
            if (dts.Rows.Count != 0)
            {
                txtMaTT.Enabled = true;
                dtpNgayMuon.Enabled = true;
                dtpNgayTra.Enabled = true;
            }
        }
        private void LoadForm()
        {
            txtSoThe.Text = "";
            txtMaTT.Text = "";
            txtHoTen.Text = "";
            txtCMT.Text = "";
            txtNgaySinh.Text = "";
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            txtMaTT.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayTra.Enabled = false;
            dgvSach.DataSource = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadForm();
            kt = 0; luu = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSach.Enabled = true;
            txtSoThe.ReadOnly = false;
            txtMaTT.ReadOnly = false;
            dts.Clear();
        }

        private void dgvMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.ColumnIndex >= 0) && kt == 1)
            {
                txtSoThe.Text = dgvMuon.CurrentRow.Cells["sothe"].Value.ToString();
                txtHoTen.Text = dgvMuon.CurrentRow.Cells["tendg"].Value.ToString();
                txtNgaySinh.Text = dgvMuon.CurrentRow.Cells["ngaysinh"].Value.ToString();
                txtCMT.Text = dgvMuon.CurrentRow.Cells["cmt"].Value.ToString();
                dtpNgayMuon.Value = DateTime.Parse(dgvMuon.CurrentRow.Cells["ngaymuon"].Value.ToString());
                dtpNgayTra.Value = DateTime.Parse(dgvMuon.CurrentRow.Cells["ngaytra"].Value.ToString());
                txtMaTT.Text = dgvMuon.CurrentRow.Cells["matt"].Value.ToString();
                dts = PhieuMuonBUS.LoadDgvSach(txtSoThe.Text, dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString());
                dgvSach.DataSource = dts;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 0; luu = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSach.Enabled = true;
            txtMaTT.ReadOnly = false;
            dtpNgayMuon.Enabled = true;
            dtpNgayTra.Enabled = true;
            txtMaTT.Enabled = true;
            txtSoThe.ReadOnly = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            kt = 1; LoadForm(); luu = 0;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSach.Enabled = false;
            txtSoThe.ReadOnly = true;
            txtMaTT.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoThe.Text == "" || txtMaTT.Text == "" || dts.Rows.Count == 0 || dtpNgayMuon.Value == dtpNgayTra.Value)
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (luu == 1)
            {
                if (MessageBox.Show(string.Format("Thêm phiếu mượn đọc giả {0}", txtHoTen.Text), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    PhieuMuonBUS.ThemPhieuMuon(txtSoThe.Text, dtpNgayMuon.Value, dtpNgayTra.Value, txtMaTT.Text);
                    DataTable dt = PhieuMuonBUS.LayData("select_maphieu", txtSoThe.Text); int j = dt.Rows.Count - 1;
                    for (int i = 0; i < dgvSach.Rows.Count; i++)
                    {
                        PhieuMuonBUS.ThemChiTiet(int.Parse(dgvSach.Rows[i].Cells["macs"].Value.ToString()), int.Parse(dt.Rows[j]["maphieu"].ToString()));
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Cập nhật phiếu mượn {0} đọc giả {1}", dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString(), txtHoTen.Text), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    PhieuMuonBUS.SuaPhieuMuon(int.Parse(dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString()), txtSoThe.Text, dtpNgayMuon.Value, dtpNgayTra.Value, txtMaTT.Text);
                    PhieuMuonBUS.XoaChiTiet(int.Parse(dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString()));
                    for (int i = 0; i < dgvSach.Rows.Count; i++)
                    {
                        PhieuMuonBUS.ThemChiTiet(int.Parse(dgvSach.Rows[i].Cells["macs"].Value.ToString()), int.Parse(dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString()));
                    }
                }
            }
            kt = 1;
            LoadForm();
            txtSoThe.ReadOnly = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSach.Enabled = false;
            PhieuMuon_UserC_Load(sender, e);
        }

        private void chkMaPhieu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaPhieu.Checked == true)
            {
                txtMaPhieu.ReadOnly = false;
            }
            else
            {
                txtMaPhieu.Text = "";
                txtMaPhieu.ReadOnly = true;
            }
        }

        private void chkDocGia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDocGia.Checked == true)
            {
                txtDocGia.ReadOnly = false;
            }
            else
            {
                txtDocGia.Text = "";
                txtDocGia.ReadOnly = true;
            }
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (txtMaPhieu.Text == "")
            {
                dv.RowFilter = "[tendg] like '%" + txtDocGia.Text + "%'";
                dgvMuon.DataSource = dv;
            }
            else
            {
                x = int.Parse(txtMaPhieu.Text);
                dv.RowFilter = "[maphieu] =" + x + " and [tendg] like '%" + txtDocGia.Text + "%'";
                dgvMuon.DataSource = dv;
            }
        }

        private void txtDocGia_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (txtMaPhieu.Text == "")
            {
                dv.RowFilter = "[tendg] like '%" + txtDocGia.Text + "%'";
                dgvMuon.DataSource = dv;
            }
            else
            {
                x = int.Parse(txtMaPhieu.Text);
                dv.RowFilter = "[maphieu] =" + x + " and [tendg] like '%" + txtDocGia.Text + "%'";
                dgvMuon.DataSource = dv;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Xóa phiếu mươn {0} tên đọc giả {1}", dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString(), dgvMuon.CurrentRow.Cells["tendg"].Value.ToString()), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (PhieuMuonBUS.XoaPhieuMuon(int.Parse(dgvMuon.CurrentRow.Cells["maphieu"].Value.ToString()))!=0)
                {
                    MessageBox.Show("Xóa thành công"); LoadForm();
                    PhieuMuon_UserC_Load(sender, e);
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
