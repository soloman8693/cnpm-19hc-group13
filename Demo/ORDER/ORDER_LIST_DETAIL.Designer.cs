﻿namespace Demo.ORDER
{
    partial class ORDER_LIST_DETAIL
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
            this.dgvOrderListDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderListDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderListDetail
            // 
            this.dgvOrderListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderListDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvOrderListDetail.Location = new System.Drawing.Point(1, 146);
            this.dgvOrderListDetail.Name = "dgvOrderListDetail";
            this.dgvOrderListDetail.ReadOnly = true;
            this.dgvOrderListDetail.Size = new System.Drawing.Size(662, 305);
            this.dgvOrderListDetail.TabIndex = 0;
            this.dgvOrderListDetail.DataSourceChanged += new System.EventHandler(this.dgvOrderListDetail_DataSourceChanged);
            this.dgvOrderListDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderListDetail_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH CHI TIẾT ORDER";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 133);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(681, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 133);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xoá Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ORDER_LIST_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderListDetail);
            this.Name = "ORDER_LIST_DETAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ORDER_LIST_DETAIL_FormClosing);
            this.Load += new System.EventHandler(this.ORDER_LIST_DETAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderListDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderListDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}