namespace Demo.ORDER
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderListDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderListDetail
            // 
            this.dgvOrderListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderListDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvOrderListDetail.Location = new System.Drawing.Point(32, 64);
            this.dgvOrderListDetail.Name = "dgvOrderListDetail";
            this.dgvOrderListDetail.Size = new System.Drawing.Size(727, 253);
            this.dgvOrderListDetail.TabIndex = 0;
            // 
            // ORDER_LIST_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOrderListDetail);
            this.Name = "ORDER_LIST_DETAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDER_LIST_DETAIL";
            this.Load += new System.EventHandler(this.ORDER_LIST_DETAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderListDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderListDetail;
    }
}