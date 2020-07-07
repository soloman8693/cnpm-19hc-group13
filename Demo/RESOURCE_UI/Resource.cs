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

namespace Demo.RESOURCE_UI
{
    public partial class Resource : Form
    {
        public Resource()
        {
            InitializeComponent();
        }

        private void Resource_Load(object sender, EventArgs e)
        {
            BUSResource.Instance.ShowFoodResource(dataGridViewNguyenLieu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Resource add_Resource = new Add_Resource(this);
            add_Resource.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESOURCE_UI.Request_Add request_Add = new Request_Add((FOOD_RESOURCE)dataGridViewNguyenLieu.CurrentRow.DataBoundItem);
            request_Add.Show();
        }

        public void reload()
        {
            BUSResource.Instance.ShowFoodResource(dataGridViewNguyenLieu);
            dataGridViewNguyenLieu.Update();
            dataGridViewNguyenLieu.Refresh();
        }
    }
}
