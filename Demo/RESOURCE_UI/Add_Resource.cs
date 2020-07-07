using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.RESOURCE_UI
{
    public partial class Add_Resource : Form
    {
        Resource resource;
        public Add_Resource(Resource resource)
        {
            this.resource = resource;
            InitializeComponent();
        }

        public void InsertResource(FOOD_RESOURCE fOOD_RESOURCE)
        {
            DAOResource.Instance.InsertResource(fOOD_RESOURCE);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FOOD_RESOURCE fOOD_RESOURCE = new FOOD_RESOURCE();
            fOOD_RESOURCE.RESOURCE_NAME = txtTen.Text;
            fOOD_RESOURCE.AMOUNT = Int32.Parse(txtSoluong.Text);
            fOOD_RESOURCE.MONEY = Int32.Parse(txtTien.Text);
            fOOD_RESOURCE.TOTAL_MONEY = Int32.Parse(txtSum.Text);
            BUSResource.Instance.InsertResource(fOOD_RESOURCE);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoluong.Text) && !String.IsNullOrEmpty(txtTien.Text))
            {
                int sum = Int32.Parse(txtTien.Text) * Int32.Parse(txtSoluong.Text);
                txtSum.Text = sum.ToString();
            }
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoluong.Text) && !String.IsNullOrEmpty(txtTien.Text))
            {
                int sum = Int32.Parse(txtTien.Text) * Int32.Parse(txtSoluong.Text);
                txtSum.Text = sum.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            resource.reload();
        }
    }
}
