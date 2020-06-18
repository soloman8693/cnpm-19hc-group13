using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtHoTen.Text = "Nhập họ tên";
            
        }
    }
}
