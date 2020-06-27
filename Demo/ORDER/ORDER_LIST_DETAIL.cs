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
            this.loadData();
        }

        private void loadData()
        {
            int id = DAOOrder.Instance.GetIdOrder();
            BUSOrder.Instance.OrderListDetail(dgvOrderListDetail, id);
            dgvOrderListDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_ORDER add = new ADD_ORDER();
            add.onAddData += loadData;
            add.Show();
        }

        private void dgvOrderListDetail_DataSourceChanged(object sender, EventArgs e)
        {
            dgvOrderListDetail.Columns[1].Visible = false;
            dgvOrderListDetail.Columns[2].Visible = false;
            dgvOrderListDetail.Columns[3].HeaderText = "Món ăn";
            dgvOrderListDetail.Columns[4].HeaderText = "Số lượng";
            dgvOrderListDetail.Columns[5].Visible = false;
            dgvOrderListDetail.Columns[6].HeaderText = "Nước uống";
            dgvOrderListDetail.Columns[7].HeaderText = "Số lượng";
            dgvOrderListDetail.Columns[8].HeaderText = "Tổng tiền";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrderListDetail.SelectedRows)
            {
                string idStr = row.Cells[0].Value.ToString();

                var confirmResult = MessageBox.Show("Bạn có muốn xoá order không?", "", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BUS.BUSOrder.Instance.DeleteOrderDetail(Int32.Parse(idStr));
                    this.loadData();
                }
            }
        }

        private void dgvOrderListDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EDIT_ORDER editOrder = new EDIT_ORDER();
            editOrder.txtId.Text = this.dgvOrderListDetail.CurrentRow.Cells[0].Value.ToString();
            BUS.BUSOrder.Instance.ListFoods(editOrder.cbbFoods, "UPDATE", Int32.Parse(this.dgvOrderListDetail.CurrentRow.Cells[2].Value.ToString()));
            editOrder.txtAmountFoods.Text = this.dgvOrderListDetail.CurrentRow.Cells[4].Value.ToString();
            BUS.BUSOrder.Instance.ListDrinks(editOrder.cbbDrinks, "UPDATE", Int32.Parse(this.dgvOrderListDetail.CurrentRow.Cells[5].Value.ToString()));
            editOrder.txtAmountDrinks.Text = this.dgvOrderListDetail.CurrentRow.Cells[7].Value.ToString();
            editOrder.txtTotal.Text = this.dgvOrderListDetail.CurrentRow.Cells[8].Value.ToString();
            editOrder.onUpdateData += loadData;
            editOrder.ShowDialog();
        }
    }
}
