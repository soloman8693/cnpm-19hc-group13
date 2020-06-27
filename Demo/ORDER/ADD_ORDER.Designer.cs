namespace Demo.ORDER
{
    partial class ADD_ORDER
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbFoods = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountFoods = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDrinks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountDrinks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM ORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Món ăn";
            // 
            // cbbFoods
            // 
            this.cbbFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFoods.FormattingEnabled = true;
            this.cbbFoods.Location = new System.Drawing.Point(32, 94);
            this.cbbFoods.Name = "cbbFoods";
            this.cbbFoods.Size = new System.Drawing.Size(275, 21);
            this.cbbFoods.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // txtAmountFoods
            // 
            this.txtAmountFoods.Location = new System.Drawing.Point(33, 167);
            this.txtAmountFoods.Name = "txtAmountFoods";
            this.txtAmountFoods.Size = new System.Drawing.Size(274, 20);
            this.txtAmountFoods.TabIndex = 4;
            this.txtAmountFoods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountFoods_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nước uống";
            // 
            // cbbDrinks
            // 
            this.cbbDrinks.BackColor = System.Drawing.SystemColors.Window;
            this.cbbDrinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDrinks.FormattingEnabled = true;
            this.cbbDrinks.Location = new System.Drawing.Point(33, 244);
            this.cbbDrinks.Name = "cbbDrinks";
            this.cbbDrinks.Size = new System.Drawing.Size(274, 21);
            this.cbbDrinks.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng";
            // 
            // txtAmountDrinks
            // 
            this.txtAmountDrinks.Location = new System.Drawing.Point(33, 319);
            this.txtAmountDrinks.Name = "txtAmountDrinks";
            this.txtAmountDrinks.Size = new System.Drawing.Size(274, 20);
            this.txtAmountDrinks.TabIndex = 8;
            this.txtAmountDrinks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountDrinks_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng tiền";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(33, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(274, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ADD_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmountDrinks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbDrinks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmountFoods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbFoods);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_ORDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm order";
            this.Load += new System.EventHandler(this.ADD_ORDER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbFoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountFoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDrinks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountDrinks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}