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
    public partial class Request_Add : Form
    {
        FOOD_RESOURCE _RESOURCE = new FOOD_RESOURCE();
        public Request_Add(FOOD_RESOURCE fOOD_RESOURCE)
        {
            _RESOURCE = fOOD_RESOURCE;
            InitializeComponent();
        }

        private void Request_Add_Load(object sender, EventArgs e)
        {
            txtTen.Text = _RESOURCE.RESOURCE_NAME;
            txtGia.Text = _RESOURCE.MONEY.ToString();
            txtSoluong.Text = _RESOURCE.AMOUNT.ToString();
            txtTong.Text = _RESOURCE.TOTAL_MONEY.ToString();
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            String infor = "Failed !!";
            if (UpdateRequest())
            {
                infor = "Successfully Requested";
            }
            MessageBox.Show(infor, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean UpdateRequest()
        {
            _RESOURCE.ADD_RESOURCE = Int32.Parse(txtNhap.Text);
            return BUSResource.Instance.UpdateResource(_RESOURCE);
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoluong.Text) && !String.IsNullOrEmpty(txtGia.Text) && !String.IsNullOrEmpty(txtNhap.Text))
            {
                int sum = Int32.Parse(txtGia.Text) * (Int32.Parse(txtSoluong.Text) + Int32.Parse(txtNhap.Text));
                txtTong.Text = sum.ToString();
            }
        }
    }
}
