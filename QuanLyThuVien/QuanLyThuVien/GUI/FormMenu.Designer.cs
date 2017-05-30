namespace QuanLyThuVien.GUI
{
    partial class FormMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýĐầuSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHome = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐầuSáchToolStripMenuItem,
            this.quảnLýĐọcToolStripMenuItem,
            this.quảnLýThôngTinMượnTrảToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýĐầuSáchToolStripMenuItem
            // 
            this.quảnLýĐầuSáchToolStripMenuItem.Name = "quảnLýĐầuSáchToolStripMenuItem";
            this.quảnLýĐầuSáchToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.quảnLýĐầuSáchToolStripMenuItem.Text = "Đầu sách";
            this.quảnLýĐầuSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐầuSáchToolStripMenuItem_Click);
            // 
            // quảnLýĐọcToolStripMenuItem
            // 
            this.quảnLýĐọcToolStripMenuItem.Name = "quảnLýĐọcToolStripMenuItem";
            this.quảnLýĐọcToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.quảnLýĐọcToolStripMenuItem.Text = "Đọc giả";
            this.quảnLýĐọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐọcToolStripMenuItem_Click);
            // 
            // quảnLýThôngTinMượnTrảToolStripMenuItem
            // 
            this.quảnLýThôngTinMượnTrảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuMượnToolStripMenuItem});
            this.quảnLýThôngTinMượnTrảToolStripMenuItem.Name = "quảnLýThôngTinMượnTrảToolStripMenuItem";
            this.quảnLýThôngTinMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.quảnLýThôngTinMượnTrảToolStripMenuItem.Text = "Thông tin mượn trả";
            // 
            // phiếuMượnToolStripMenuItem
            // 
            this.phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            this.phiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            this.phiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Đổi mật khẩu";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem1
            // 
            this.hướngDẫnToolStripMenuItem1.Name = "hướngDẫnToolStripMenuItem1";
            this.hướngDẫnToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem1.Text = "Hướng dẫn";
            this.hướngDẫnToolStripMenuItem1.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem1_Click);
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(0, 27);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(889, 538);
            this.panelHome.TabIndex = 1;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 567);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenu";
            this.Text = "Quản lý thư viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐầuSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnToolStripMenuItem;
    }
}