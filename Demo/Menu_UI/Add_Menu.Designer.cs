namespace Demo.Menu_UI
{
    partial class frmAddMenu
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
        private void InitializeComponent(System.Boolean addFlag)
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdtKhongSanSang = new System.Windows.Forms.RadioButton();
            this.rbtSanSang = new System.Windows.Forms.RadioButton();
            this.rctMieuTa = new System.Windows.Forms.RichTextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.objectListViewMonAn = new BrightIdeasSoftware.ObjectListView();
            this.STT = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvCommand = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            string title = "Thêm Menu";
            if (!addFlag)
            {
                title = "Sửa Menu";
            }
            this.label1.Text = title;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdtKhongSanSang);
            this.groupBox1.Controls.Add(this.rbtSanSang);
            this.groupBox1.Controls.Add(this.rctMieuTa);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // rdtKhongSanSang
            // 
            this.rdtKhongSanSang.AutoSize = true;
            this.rdtKhongSanSang.Location = new System.Drawing.Point(204, 245);
            this.rdtKhongSanSang.Name = "rdtKhongSanSang";
            this.rdtKhongSanSang.Size = new System.Drawing.Size(144, 17);
            this.rdtKhongSanSang.TabIndex = 3;
            this.rdtKhongSanSang.TabStop = true;
            this.rdtKhongSanSang.Text = "Không sẵn sàng phục vụ";
            this.rdtKhongSanSang.UseVisualStyleBackColor = true;
            // 
            // rbtSanSang
            // 
            this.rbtSanSang.AutoSize = true;
            this.rbtSanSang.Location = new System.Drawing.Point(67, 245);
            this.rbtSanSang.Name = "rbtSanSang";
            this.rbtSanSang.Size = new System.Drawing.Size(112, 17);
            this.rbtSanSang.TabIndex = 3;
            this.rbtSanSang.TabStop = true;
            this.rbtSanSang.Text = "Sẵn sàng phục vụ";
            this.rbtSanSang.UseVisualStyleBackColor = true;
            // 
            // rctMieuTa
            // 
            this.rctMieuTa.Location = new System.Drawing.Point(67, 67);
            this.rctMieuTa.Name = "rctMieuTa";
            this.rctMieuTa.Size = new System.Drawing.Size(296, 92);
            this.rctMieuTa.TabIndex = 2;
            this.rctMieuTa.Text = "";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(67, 203);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(296, 20);
            this.txtGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(67, 171);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(296, 20);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(67, 29);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(296, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miêu tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.objectListViewMonAn);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Món ăn";
            // 
            // objectListViewMonAn
            // 
            this.objectListViewMonAn.AllColumns.Add(this.STT);
            this.objectListViewMonAn.AllColumns.Add(this.olvName);
            this.objectListViewMonAn.AllColumns.Add(this.olvCommand);
            this.objectListViewMonAn.CellEditUseWholeCell = false;
            this.objectListViewMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.olvName,
            this.olvCommand});
            this.objectListViewMonAn.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewMonAn.GridLines = true;
            this.objectListViewMonAn.HideSelection = false;
            this.objectListViewMonAn.Location = new System.Drawing.Point(3, 16);
            this.objectListViewMonAn.Name = "objectListViewMonAn";
            this.objectListViewMonAn.ShowGroups = false;
            this.objectListViewMonAn.Size = new System.Drawing.Size(363, 218);
            this.objectListViewMonAn.SmallImageList = this.imageListMenu;
            this.objectListViewMonAn.TabIndex = 0;
            this.objectListViewMonAn.UseCompatibleStateImageBehavior = false;
            this.objectListViewMonAn.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 2;
            // 
            // olvName
            // 
            this.olvName.AspectName = "FOOD_NAME";
            this.olvName.Text = "Tên";
            this.olvName.Width = 300;
            // 
            // olvCommand
            // 
            this.olvCommand.ShowTextInHeader = false;
            this.olvCommand.Sortable = false;
            this.olvCommand.Text = "Lệnh";
            this.olvCommand.Width = 40;
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "delete-sign.png");
            this.imageListMenu.Images.SetKeyName(1, "icons8-add-16.png");
            // 
            // btnThem
            // 
            if (!addFlag)
            {
                this.btnThem.Enabled = false;
            }
            this.btnThem.Location = new System.Drawing.Point(12, 567);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 67);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(173, 567);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 30);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(173, 603);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 640);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddMenu";
            this.Text = "Add_Menu";
            this.Load += new System.EventHandler(this.frmAddMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rctMieuTa;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private BrightIdeasSoftware.ObjectListView objectListViewMonAn;
        private System.Windows.Forms.RadioButton rdtKhongSanSang;
        private System.Windows.Forms.RadioButton rbtSanSang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ImageList imageListMenu;
        private BrightIdeasSoftware.OLVColumn STT;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvCommand;
    }
}