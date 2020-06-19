using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Demo.NG_UI;

namespace Demo.EMPLOYEE_UI
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            NameBUS.Instance.Show(dgvDSNhanVien);
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void dgvDSNhanVien_DataSourceChanged(object sender, EventArgs e)
        {
            dgvDSNhanVien.Columns[1].HeaderText = "Họ tên";
            dgvDSNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvDSNhanVien.Columns[4].HeaderText = "Loại tài khoản";
            dgvDSNhanVien.Columns[5].Visible = false;
            dgvDSNhanVien.Columns[6].Visible = false;
            dgvDSNhanVien.Columns[7].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ADD_EMPLOYEE addForm = new ADD_EMPLOYEE();
            addForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UPDATE_EMPLOYEE updateForm = new UPDATE_EMPLOYEE();
            updateForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn xoá nhân viên?", "", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
    }
}
