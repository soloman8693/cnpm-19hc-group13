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

namespace Demo.EMPLOYEE_UI
{
    public partial class UPDATE_EMPLOYEE : Form
    {
        public Action onUpdateData;
        public UPDATE_EMPLOYEE()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            string fullName = txtName.Text;
            string gender = txtGender.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            int role = Int32.Parse(cbbRole.SelectedValue.ToString());
            BUS.BUSUser.Instance.UpdateEmployee(id, fullName, gender, address, role, password);

            this.Hide();
            onUpdateData?.Invoke();
        }
    }
}
