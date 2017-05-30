namespace QuanLyThuVien.GUI
{
    partial class HuongDan_UserC
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Về phần mềm");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thêm mới đầu sách");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sửa đầu sách");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Xóa đầu sách");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tìm kiếm đầu sách");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Đầu sách", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Thêm đọc giả");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sửa đọc giả");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Xóa đọc giả");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tìm kiếm đọc giả");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Đọc giả", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Mượn sách");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Trả sách");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Mượn trả", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Về phần mềm";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Thêm mới đầu sách";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Sửa đầu sách";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Xóa đầu sách";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Tìm kiếm đầu sách";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Đầu sách";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Thêm đọc giả";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Sửa đọc giả";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Xóa đọc giả";
            treeNode10.Name = "Node8";
            treeNode10.Text = "Tìm kiếm đọc giả";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Đọc giả";
            treeNode12.Name = "Node10";
            treeNode12.Text = "Mượn sách";
            treeNode13.Name = "Node11";
            treeNode13.Text = "Trả sách";
            treeNode14.Name = "Node9";
            treeNode14.Text = "Mượn trả";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode11,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(188, 532);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(197, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(689, 532);
            this.webBrowser1.TabIndex = 1;
            // 
            // HuongDan_UserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "HuongDan_UserC";
            this.Size = new System.Drawing.Size(889, 538);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
