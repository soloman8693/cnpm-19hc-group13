using BUS;
using DAO;
using Demo.ORDER;
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
            var data = DataSingleton.GetInstance().GetIdUser().ToString();
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
        
        public void reloadData()
        {
            BUSOrder.Instance.OrderList(dgvOrder);
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ORDER_LIST_Load(object sender, EventArgs e)
        {
            this.reloadData();
        }

        private void dgvOrder_DataSourceChanged(object sender, EventArgs e)
        {
            dgvOrder.Columns[1].Visible = false;
            dgvOrder.Columns[2].Visible = false;
            dgvOrder.Columns[3].HeaderText = "Người thực hiện";
            dgvOrder.Columns[4].HeaderText = "Tên bàn";
            dgvOrder.Columns[5].HeaderText = "Tổng tiền";
            dgvOrder.Columns[6].Visible = false;
            dgvOrder.Columns[7].HeaderText = "Trạng thái";
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrder.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                DAOOrder.Instance.SetIdOrder(id);

                ORDER_LIST_DETAIL dt = new ORDER_LIST_DETAIL();
                dt.onReloadData += reloadData;
                dt.Show();
            }
        }
    }
}
