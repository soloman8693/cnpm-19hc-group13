namespace Demo.TABLE_UI
{
    partial class ACTION_OF_TABLE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInfor = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgListOrder = new System.Windows.Forms.DataGridView();
            this.btnCash = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOOD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT_OF_FOOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRINK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT_OF_DRINK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInfor);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(633, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.ForeColor = System.Drawing.Color.Red;
            this.lbInfor.Location = new System.Drawing.Point(21, 122);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(36, 17);
            this.lbInfor.TabIndex = 4;
            this.lbInfor.Text = "infor";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(220, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(149, 75);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(301, 28);
            this.cbStatus.TabIndex = 3;
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(149, 29);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(301, 26);
            this.txtTableName.TabIndex = 2;
            this.txtTableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng bàn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtgListOrder);
            this.groupBox2.Controls.Add(this.btnCash);
            this.groupBox2.Location = new System.Drawing.Point(25, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách order";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thay đổi order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgListOrder
            // 
            this.dtgListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FOOD_NAME,
            this.AMOUNT_OF_FOOD,
            this.DRINK_NAME,
            this.AMOUNT_OF_DRINK,
            this.MONEY});
            this.dtgListOrder.Location = new System.Drawing.Point(6, 45);
            this.dtgListOrder.Name = "dtgListOrder";
            this.dtgListOrder.RowTemplate.Height = 24;
            this.dtgListOrder.Size = new System.Drawing.Size(568, 252);
            this.dtgListOrder.TabIndex = 1;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(146, 303);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(153, 36);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Thanh Toán";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteTable,
            this.resetStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(76, 24);
            this.btnDeleteTable.Text = "Xóa bàn";
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // resetStatusToolStripMenuItem
            // 
            this.resetStatusToolStripMenuItem.Name = "resetStatusToolStripMenuItem";
            this.resetStatusToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.resetStatusToolStripMenuItem.Text = "Reset Status";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // FOOD_NAME
            // 
            this.FOOD_NAME.HeaderText = "THỨC ĂN";
            this.FOOD_NAME.Name = "FOOD_NAME";
            this.FOOD_NAME.ReadOnly = true;
            this.FOOD_NAME.Width = 200;
            // 
            // AMOUNT_OF_FOOD
            // 
            this.AMOUNT_OF_FOOD.HeaderText = "SL";
            this.AMOUNT_OF_FOOD.Name = "AMOUNT_OF_FOOD";
            this.AMOUNT_OF_FOOD.ReadOnly = true;
            this.AMOUNT_OF_FOOD.Width = 30;
            // 
            // DRINK_NAME
            // 
            this.DRINK_NAME.HeaderText = "NƯỚC";
            this.DRINK_NAME.Name = "DRINK_NAME";
            this.DRINK_NAME.ReadOnly = true;
            this.DRINK_NAME.Width = 130;
            // 
            // AMOUNT_OF_DRINK
            // 
            this.AMOUNT_OF_DRINK.HeaderText = "SL";
            this.AMOUNT_OF_DRINK.Name = "AMOUNT_OF_DRINK";
            this.AMOUNT_OF_DRINK.Width = 30;
            // 
            // MONEY
            // 
            this.MONEY.HeaderText = "TỔNG TIỀN";
            this.MONEY.Name = "MONEY";
            this.MONEY.ReadOnly = true;
            // 
            // ACTION_OF_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ACTION_OF_TABLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTION_OF_TABLE";
            this.Load += new System.EventHandler(this.ACTION_OF_TABLE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgListOrder;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteTable;
        private System.Windows.Forms.ToolStripMenuItem resetStatusToolStripMenuItem;
        private System.Windows.Forms.Label lbInfor;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOOD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT_OF_FOOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRINK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT_OF_DRINK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEY;
    }
}