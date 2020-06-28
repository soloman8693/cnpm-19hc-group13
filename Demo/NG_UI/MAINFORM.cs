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
using Demo.EMPLOYEE_UI;
using Demo.ORTHER;

namespace Demo.NG_UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnUserName.Text = SignIn_Static_User.StaticUser.SignIn_User.FULL_NAME;
            lbTitle.Text = "Welcome to GOLD restaurent - " + DateTime.Now.ToString("dd/MM/yyyy");
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //load table
            List<TABLE> tables = BUSTable.Instance.GetListTables();
            for (int i = 0; i < tables.Count(); i++) {
                Button b = new Button();
                b.Name = "btnTable" + i;
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
            MessageBox.Show(btn.Name + "clicked"); 
        }

        private void btnUserName_MouseHover(object sender, EventArgs e)
        {
            btnUserName.ForeColor = Color.Red;
            btnUserName.Font = new Font(btnUserName.Font.Name, btnUserName.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnUserName_MouseLeave(object sender, EventArgs e)
        {
            btnUserName.ForeColor = Color.Blue;
            btnUserName.Font = new Font(btnUserName.Font.Name, btnUserName.Font.SizeInPoints, FontStyle.Regular);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employ = new Employee();
            employ.Show();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ORDER_LIST order = new ORDER_LIST();
            order.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABLE_UI.BOOK_TABLE bookTable = new TABLE_UI.BOOK_TABLE();
            bookTable.Show();
        }

        private void btnUserName_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABLE_UI.frm_ListTable frm_ListTable = new TABLE_UI.frm_ListTable();
            this.Hide();
            frm_ListTable.Show();
        }
    }
}
