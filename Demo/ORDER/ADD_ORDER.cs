using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.ORDER
{
    public partial class ADD_ORDER : Form
    {
        public Action onAddData;
        public ADD_ORDER()
        {
            InitializeComponent();
        }

        private void ADD_ORDER_Load(object sender, EventArgs e)
        {
            BUS.BUSOrder.Instance.ListFoods(cbbFoods, "ADD", 0);
            BUS.BUSOrder.Instance.ListDrinks(cbbDrinks, "ADD", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idOrder = DAO.DAOOrder.Instance.GetIdOrder();
            int idFood = Int32.Parse(cbbFoods.SelectedValue.ToString());
            string txtFood = cbbFoods.Text;

            int amountFood = 0;
            if(txtAmountFoods.Text != "" && Int32.Parse(txtAmountFoods.Text) > 0)
            {
                amountFood = Int32.Parse(txtAmountFoods.Text);
            }

            int idDrink = Int32.Parse(cbbDrinks.SelectedValue.ToString());
            string txtDrink = cbbDrinks.Text;

            int amountDrink = 0;

            if (txtAmountDrinks.Text != "" && Int32.Parse(txtAmountDrinks.Text) > 0)
            {
                amountDrink = Int32.Parse(txtAmountDrinks.Text);
            }

            double totalMoney = 0;
            if (txtTotal.Text != "" && Int32.Parse(txtTotal.Text) >= 0)
            {
                totalMoney = Int32.Parse(txtTotal.Text);
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ");
            }

            BUSOrder.Instance.AddOrder(idOrder, idFood, txtFood, (int)amountFood, idDrink, txtDrink, amountDrink, totalMoney);
            this.Close();
            onAddData?.Invoke();
        }

        private void txtAmountFoods_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmountDrinks_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
