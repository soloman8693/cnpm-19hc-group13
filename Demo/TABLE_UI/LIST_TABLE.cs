using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace Demo.TABLE_UI
{
    public partial class frm_ListTable : Form
    {
        public frm_ListTable()
        {
            InitializeComponent();
        }
        public static TABLE currentTalbe;
        private List<TABLE> tables;

        public event EventHandler ButtonClicked;

        public void NotifyButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);

        }

        private void frm_ListTable_Load(object sender, EventArgs e)
        {
            set_list_table();
        }

        private void set_list_table() {
            int width, height;
            width = this.Size.Width;
            height = this.Size.Height;
            width = width / 5 - 5;
            height = height / 5 - 12;
            tables = BUSTable.Instance.GetListTables();
            for (int i = 0; i < tables.Count(); i++)
            {
                Button b = new Button();
                b.Name = "btnTable" + i;
                b.Size = new Size(width, height);
                b.Text = tables[i].TABLE_NAME.ToString();
                if (tables[i].STATUS != 0)
                {
                    b.BackColor = Color.Red;
                }
                b.Click += new EventHandler(table_button_click);
                flowTableGenerate.Controls.Add(b);
            }
            flowTableGenerate.AutoScroll = true;
        }

        private void table_button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            char index = btn.Name[btn.Name.Length - 1];
            currentTalbe = tables[int.Parse(index.ToString())];
            btnMoney ob = new btnMoney();
            ob.FormClosed += new FormClosedEventHandler(ob_FormClosed);
            ob.ShowDialog();         
        }
        void ob_FormClosed(object sender, FormClosedEventArgs e)
        {
            while (flowTableGenerate.Controls.Count > 0) flowTableGenerate.Controls.RemoveAt(0);
            frm_ListTable_Load(this, null);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            ADD_TABLE ob = new ADD_TABLE();
            ob.FormClosed += new FormClosedEventHandler(ob_FormClosed);
            ob.ShowDialog();
        }
    }
}
