using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Demo.ORTHER
{
    public partial class ORDER_LIST : Form
    {
        public ORDER_LIST()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UPDATE_STATUS_ORDER updateStatusOrder = new UPDATE_STATUS_ORDER();
            updateStatusOrder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESOURCES rs = new RESOURCES();
            rs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TABLE_UI.BOOK_TABLE book_table = new TABLE_UI.BOOK_TABLE();
            book_table.Show();
        }
    }
}
