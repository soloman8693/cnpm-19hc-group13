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
            BUSUser.Instance.Show(dgvDSNhanVien);
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
            //dgvDSNhanVien.Columns[4].Visible = false;
            dgvDSNhanVien.Columns[5].Visible = false;
            dgvDSNhanVien.Columns[6].Visible = false;
            dgvDSNhanVien.Columns[7].Visible = false;
        }

        private void LoadData()
        {
            BUSUser.Instance.Show(dgvDSNhanVien);
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ADD_EMPLOYEE addForm = new ADD_EMPLOYEE();
            addForm.onAddData += LoadData;
            addForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UPDATE_EMPLOYEE updateForm = new UPDATE_EMPLOYEE();
            updateForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvDSNhanVien.SelectedRows)
            {
                string idStr = row.Cells[0].Value.ToString();

                var confirmResult = MessageBox.Show("Bạn có muốn xoá nhân viên?", "", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BUS.BUSUser.Instance.DeleteEmployee(Int32.Parse(idStr));
                    this.LoadData();
                }
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDSNhanVien.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
           
            }
        }

        private void dgvDSNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UPDATE_EMPLOYEE updateForm = new UPDATE_EMPLOYEE();
            updateForm.txtID.Text = this.dgvDSNhanVien.CurrentRow.Cells[0].Value.ToString();
            updateForm.txtName.Text = this.dgvDSNhanVien.CurrentRow.Cells[1].Value.ToString();
            updateForm.txtGender.Text = this.dgvDSNhanVien.CurrentRow.Cells[2].Value.ToString();
            updateForm.txtAddress.Text = this.dgvDSNhanVien.CurrentRow.Cells[3].Value.ToString();
            updateForm.txtPassword.Text = this.dgvDSNhanVien.CurrentRow.Cells[6].Value.ToString();
            BUS.BUSUser.Instance.ShowPermission(updateForm.cbbRole, "UPDATE", Int32.Parse(this.dgvDSNhanVien.CurrentRow.Cells[4].Value.ToString()));
            updateForm.onUpdateData += LoadData;
            updateForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                BUS.BUSUser.Instance.Search(dgvDSNhanVien, txtSearch.Text);
            }
            else
            {
                this.LoadData();
            }
        }
    }
}
