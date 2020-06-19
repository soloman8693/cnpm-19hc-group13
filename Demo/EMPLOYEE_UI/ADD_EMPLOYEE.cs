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

namespace Demo.NG_UI
{
    public partial class ADD_EMPLOYEE : Form
    {
        public Action onAddData; 
        public ADD_EMPLOYEE()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            BUS.BUSUser.Instance.ShowPermission(cbbRole, "ADD", 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullName = txtHoTen.Text;
            string gender = txtGender.Text;
            string address = txtAddress.Text;
            int role = 0;

            string userName = txtUser.Text;
            string passWord = txtPassword.Text;


            if (cbbRole.SelectedValue.ToString() != "") 
            {
                role = Int32.Parse(cbbRole.SelectedValue.ToString());
            }

            if (fullName == "" || gender == "" || address == "" || role == 0 || userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
            else
            {
                BUS.BUSUser.Instance.AddEmployee(fullName, gender, address, role, userName, passWord);
                this.Hide();
                onAddData?.Invoke();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
