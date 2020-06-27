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
    public partial class EDIT_ORDER : Form
    {
        public Action onUpdateData;
        public EDIT_ORDER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int idFood = Int32.Parse(cbbFoods.SelectedValue.ToString());
            string nameFood = cbbFoods.Text;
            int amountFood = Int32.Parse(txtAmountFoods.Text);
            int idDrink = Int32.Parse(cbbDrinks.SelectedValue.ToString());
            string nameDrink = cbbDrinks.Text;
            int amountDrink = Int32.Parse(txtAmountDrinks.Text);
            double total = Int32.Parse(txtTotal.Text);
            BUS.BUSOrder.Instance.UpdateOrderDetail(id, idFood, nameFood, amountFood, idDrink, nameDrink, amountDrink, total);
            this.Close();
            onUpdateData?.Invoke();
        }
    }
}
