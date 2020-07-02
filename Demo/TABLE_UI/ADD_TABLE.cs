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

namespace Demo.TABLE_UI
{
    public partial class ADD_TABLE : Form
    {
        public ADD_TABLE()
        {
            InitializeComponent();
        }

        private void txtTableName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (BUSTable.Instance.GetTableByName(int.Parse(txtTableName.Text)) != null) {
                MessageBox.Show("Tên bàn đã tồn tại. vui lòng chọn tên khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUSTable.Instance.AddNewTable(int.Parse(txtTableName.Text));
            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public event EventHandler ButtonClicked;

        public void NotifyButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);

        }
    }
}
