namespace Demo.DISHES_UI
{
    partial class wfAddDishes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAddDishes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNotAvaiable = new System.Windows.Forms.RadioButton();
            this.radioButtonAvaiable = new System.Windows.Forms.RadioButton();
            this.rctMieuTa = new System.Windows.Forms.RichTextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clCommand = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListDelete = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNotAvaiable);
            this.groupBox1.Controls.Add(this.radioButtonAvaiable);
            this.groupBox1.Controls.Add(this.rctMieuTa);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonNotAvaiable
            // 
            this.radioButtonNotAvaiable.AutoSize = true;
            this.radioButtonNotAvaiable.Location = new System.Drawing.Point(265, 136);
            this.radioButtonNotAvaiable.Name = "radioButtonNotAvaiable";
            this.radioButtonNotAvaiable.Size = new System.Drawing.Size(116, 17);
            this.radioButtonNotAvaiable.TabIndex = 3;
            this.radioButtonNotAvaiable.TabStop = true;
            this.radioButtonNotAvaiable.Text = "Không thể phục vụ";
            this.radioButtonNotAvaiable.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvaiable
            // 
            this.radioButtonAvaiable.AutoSize = true;
            this.radioButtonAvaiable.Location = new System.Drawing.Point(116, 138);
            this.radioButtonAvaiable.Name = "radioButtonAvaiable";
            this.radioButtonAvaiable.Size = new System.Drawing.Size(98, 17);
            this.radioButtonAvaiable.TabIndex = 3;
            this.radioButtonAvaiable.TabStop = true;
            this.radioButtonAvaiable.Text = "Có thể phục vụ";
            this.radioButtonAvaiable.UseVisualStyleBackColor = true;
            // 
            // rctMieuTa
            // 
            this.rctMieuTa.Location = new System.Drawing.Point(95, 55);
            this.rctMieuTa.Name = "rctMieuTa";
            this.rctMieuTa.Size = new System.Drawing.Size(305, 70);
            this.rctMieuTa.TabIndex = 2;
            this.rctMieuTa.Text = "";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(95, 170);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(305, 20);
            this.txtGia.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(11, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(67, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Tên món ăn:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(95, 26);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(305, 20);
            this.txtTenMon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miêu tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.objectListView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nguyên liệu";
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.clName);
            this.objectListView1.AllColumns.Add(this.clCommand);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.clName,
            this.clCommand});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(3, 16);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(404, 196);
            this.objectListView1.SmallImageList = this.imageListDelete;
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.IsVisible = false;
            this.olvColumn1.ShowTextInHeader = false;
            this.olvColumn1.Sortable = false;
            this.olvColumn1.Text = "STT";
            this.olvColumn1.Width = 2;
            // 
            // clName
            // 
            this.clName.AspectName = "RESOURCE_NAME";
            this.clName.Sortable = false;
            this.clName.Text = "Tên";
            this.clName.Width = 300;
            // 
            // clCommand
            // 
            this.clCommand.AspectName = "command";
            this.clCommand.ShowTextInHeader = false;
            this.clCommand.Sortable = false;
            this.clCommand.Text = "Lệnh";
            this.clCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCommand.Width = 50;
            // 
            // imageListDelete
            // 
            this.imageListDelete.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDelete.ImageStream")));
            this.imageListDelete.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDelete.Images.SetKeyName(0, "delete-sign.png");
            this.imageListDelete.Images.SetKeyName(1, "icons8-add-16.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm món khác";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(178, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hủy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // wfAddDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 535);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "wfAddDishes";
            this.Text = "Add_Dishes";
            this.Load += new System.EventHandler(this.Add_Dishes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rctMieuTa;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn clCommand;
        private BrightIdeasSoftware.OLVColumn clName;
        private System.Windows.Forms.ImageList imageListDelete;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.RadioButton radioButtonNotAvaiable;
        private System.Windows.Forms.RadioButton radioButtonAvaiable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}