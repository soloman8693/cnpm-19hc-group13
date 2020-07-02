using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Demo.DISHES_UI
{
    public partial class Dishes : Form
    {
        public Dishes()
        {
            InitializeComponent();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {
            BUSDishes.Instance.ShowDishes(dbGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wfAddDishes add_Dishes = new wfAddDishes(this);
            add_Dishes.Show();
        }

        public void reload()
        {
            BUSDishes.Instance.ShowDishes(dbGridView);
            dbGridView.Update();
            dbGridView.Refresh();
        }
    }
}
