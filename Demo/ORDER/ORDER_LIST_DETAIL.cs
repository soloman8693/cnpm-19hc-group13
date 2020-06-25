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

namespace Demo.ORDER
{
    public partial class ORDER_LIST_DETAIL : Form
    {
        public ORDER_LIST_DETAIL()
        {
            InitializeComponent();
        }

        private void ORDER_LIST_DETAIL_Load(object sender, EventArgs e)
        {
            int id = DAOOrder.Instance.GetIdOrder();
            BUSOrder.Instance.OrderListDetail(dgvOrderListDetail, id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_ORDER add = new ADD_ORDER();
            add.Show();
        }
    }
}
