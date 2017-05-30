namespace QuanLyThuVien.GUI
{
    partial class DauSach_UserC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaTT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTacGia = new System.Windows.Forms.CheckBox();
            this.txtTKTacGia = new System.Windows.Forms.TextBox();
            this.chkTheLoai = new System.Windows.Forms.CheckBox();
            this.txtTKTheloai = new System.Windows.Forms.TextBox();
            this.chkTenSach = new System.Windows.Forms.CheckBox();
            this.txtTKTenSach = new System.Windows.Forms.TextBox();
            this.chkMaSach = new System.Windows.Forms.CheckBox();
            this.txtTKMaSach = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaHD);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMaTT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(98, 30);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(121, 21);
            this.cboMaHD.TabIndex = 9;
            this.cboMaHD.SelectedIndexChanged += new System.EventHandler(this.cboMaHD_SelectedIndexChanged);
            this.cboMaHD.SelectionChangeCommitted += new System.EventHandler(this.cboMaHD_SelectionChangeCommitted);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 159);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(98, 117);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã TT:";
            // 
            // cboMaTT
            // 
            this.cboMaTT.FormattingEnabled = true;
            this.cboMaTT.Location = new System.Drawing.Point(98, 75);
            this.cboMaTT.Name = "cboMaTT";
            this.cboMaTT.Size = new System.Drawing.Size(121, 21);
            this.cboMaTT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongSoLuong);
            this.groupBox2.Controls.Add(this.lblSoLuong);
            this.groupBox2.Controls.Add(this.txtViTri);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTheLoai);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNhaXB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTacGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(231, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đầu sách";
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Enabled = false;
            this.txtTongSoLuong.Location = new System.Drawing.Point(402, 159);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(198, 20);
            this.txtTongSoLuong.TabIndex = 13;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Enabled = false;
            this.lblSoLuong.Location = new System.Drawing.Point(330, 162);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuong.TabIndex = 12;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(402, 114);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(198, 20);
            this.txtViTri.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Vị trí:";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(402, 75);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(198, 20);
            this.txtTheLoai.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Thể loại:";
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(402, 30);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(198, 20);
            this.txtNhaXB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nhà XB:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(76, 159);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(205, 20);
            this.txtTacGia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tác giả:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(76, 75);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(205, 55);
            this.txtTenSach.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(76, 30);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(205, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sách:";
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToAddRows = false;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Location = new System.Drawing.Point(6, 277);
            this.dgvDauSach.MultiSelect = false;
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.Size = new System.Drawing.Size(734, 258);
            this.dgvDauSach.TabIndex = 2;
            this.dgvDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(765, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(765, 334);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(765, 385);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(765, 436);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 32);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(765, 485);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 32);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTacGia);
            this.groupBox3.Controls.Add(this.txtTKTacGia);
            this.groupBox3.Controls.Add(this.chkTheLoai);
            this.groupBox3.Controls.Add(this.txtTKTheloai);
            this.groupBox3.Controls.Add(this.chkTenSach);
            this.groupBox3.Controls.Add(this.txtTKTenSach);
            this.groupBox3.Controls.Add(this.chkMaSach);
            this.groupBox3.Controls.Add(this.txtTKMaSach);
            this.groupBox3.Location = new System.Drawing.Point(0, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(886, 60);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // chkTacGia
            // 
            this.chkTacGia.AutoSize = true;
            this.chkTacGia.Location = new System.Drawing.Point(684, 25);
            this.chkTacGia.Name = "chkTacGia";
            this.chkTacGia.Size = new System.Drawing.Size(65, 17);
            this.chkTacGia.TabIndex = 24;
            this.chkTacGia.Text = "Tác giả:";
            this.chkTacGia.UseVisualStyleBackColor = true;
            this.chkTacGia.Click += new System.EventHandler(this.chkTacGia_Click);
            // 
            // txtTKTacGia
            // 
            this.txtTKTacGia.Enabled = false;
            this.txtTKTacGia.Location = new System.Drawing.Point(755, 23);
            this.txtTKTacGia.Name = "txtTKTacGia";
            this.txtTKTacGia.Size = new System.Drawing.Size(116, 20);
            this.txtTKTacGia.TabIndex = 23;
            this.txtTKTacGia.TextChanged += new System.EventHandler(this.txtTKTacGia_TextChanged);
            // 
            // chkTheLoai
            // 
            this.chkTheLoai.AutoSize = true;
            this.chkTheLoai.Location = new System.Drawing.Point(460, 26);
            this.chkTheLoai.Name = "chkTheLoai";
            this.chkTheLoai.Size = new System.Drawing.Size(67, 17);
            this.chkTheLoai.TabIndex = 22;
            this.chkTheLoai.Text = "Thể loại:";
            this.chkTheLoai.UseVisualStyleBackColor = true;
            this.chkTheLoai.Click += new System.EventHandler(this.chkTheLoai_Click);
            // 
            // txtTKTheloai
            // 
            this.txtTKTheloai.Enabled = false;
            this.txtTKTheloai.Location = new System.Drawing.Point(533, 24);
            this.txtTKTheloai.Name = "txtTKTheloai";
            this.txtTKTheloai.Size = new System.Drawing.Size(125, 20);
            this.txtTKTheloai.TabIndex = 21;
            this.txtTKTheloai.TextChanged += new System.EventHandler(this.txtTKTheloai_TextChanged);
            // 
            // chkTenSach
            // 
            this.chkTenSach.AutoSize = true;
            this.chkTenSach.Location = new System.Drawing.Point(231, 26);
            this.chkTenSach.Name = "chkTenSach";
            this.chkTenSach.Size = new System.Drawing.Size(74, 17);
            this.chkTenSach.TabIndex = 20;
            this.chkTenSach.Text = "Tên sách:";
            this.chkTenSach.UseVisualStyleBackColor = true;
            this.chkTenSach.Click += new System.EventHandler(this.chkTenSach_Click);
            // 
            // txtTKTenSach
            // 
            this.txtTKTenSach.Enabled = false;
            this.txtTKTenSach.Location = new System.Drawing.Point(311, 23);
            this.txtTKTenSach.Name = "txtTKTenSach";
            this.txtTKTenSach.Size = new System.Drawing.Size(125, 20);
            this.txtTKTenSach.TabIndex = 19;
            this.txtTKTenSach.TextChanged += new System.EventHandler(this.txtTKTenSach_TextChanged);
            // 
            // chkMaSach
            // 
            this.chkMaSach.AutoSize = true;
            this.chkMaSach.Location = new System.Drawing.Point(6, 26);
            this.chkMaSach.Name = "chkMaSach";
            this.chkMaSach.Size = new System.Drawing.Size(70, 17);
            this.chkMaSach.TabIndex = 18;
            this.chkMaSach.Text = "Mã sách:";
            this.chkMaSach.UseVisualStyleBackColor = true;
            this.chkMaSach.CausesValidationChanged += new System.EventHandler(this.chkMaSach_CausesValidationChanged);
            this.chkMaSach.Click += new System.EventHandler(this.chkMaSach_Click);
            // 
            // txtTKMaSach
            // 
            this.txtTKMaSach.Enabled = false;
            this.txtTKMaSach.Location = new System.Drawing.Point(82, 24);
            this.txtTKMaSach.Name = "txtTKMaSach";
            this.txtTKMaSach.Size = new System.Drawing.Size(125, 20);
            this.txtTKMaSach.TabIndex = 13;
            this.txtTKMaSach.TextChanged += new System.EventHandler(this.txtTKMaSach_TextChanged);
            // 
            // DauSach_UserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDauSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DauSach_UserC";
            this.Size = new System.Drawing.Size(889, 538);
            this.Load += new System.EventHandler(this.DauSach_UserC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTacGia;
        private System.Windows.Forms.TextBox txtTKTacGia;
        private System.Windows.Forms.CheckBox chkTheLoai;
        private System.Windows.Forms.TextBox txtTKTheloai;
        private System.Windows.Forms.CheckBox chkTenSach;
        private System.Windows.Forms.TextBox txtTKTenSach;
        private System.Windows.Forms.CheckBox chkMaSach;
        private System.Windows.Forms.TextBox txtTKMaSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
    }
}
