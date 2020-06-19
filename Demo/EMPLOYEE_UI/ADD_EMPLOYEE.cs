using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Demo.NG_UI
{
    public partial class ADD_EMPLOYEE : Form
    {
        public ADD_EMPLOYEE()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullName = txtHoTen.Text;
            string gender =  txtGender.Text;
            string address = txtAddress.Text;
            int role = Int32.Parse(txtRole.Text);
            string userName = txtUser.Text;
            string passWord = txtPassword.Text;

            DAO.DAOUser.Instance.AddEmployee(fullName, gender, address, role, userName, passWord);
            this.Hide();
        }
    }
}
