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
    public partial class ACTION_OF_TABLE : Form
    {
        public ACTION_OF_TABLE()
        {
            InitializeComponent();
        }
        private TABLE currentTalbe;

        private void ACTION_OF_TABLE_Load(object sender, EventArgs e)
        {
            currentTalbe = frm_ListTable.currentTalbe;
            this.Text = "Bàn " + currentTalbe.TABLE_NAME.ToString();
            lbInfor.Visible = false;
            setDataForStatusCB();
            txtTableName.Text = currentTalbe.TABLE_NAME.ToString();
            cbStatus.Text = currentTalbe.STATUS.ToString();
            dtgListOrder.DataSource = BUSOrder.Instance.getListDetailOrderByTableID(currentTalbe.ID);
            for (int i = 0; i < dtgListOrder.Rows.Count; i++) {
                dtgListOrder.Rows[i].Cells[0].Value = i + 1;
            }
            this.dtgListOrder.Columns["FOOD_ID"].Visible = false;
            this.dtgListOrder.Columns["DRINK_ID"].Visible = false;
            this.dtgListOrder.Columns["ID_ORDER"].Visible = false;
            this.dtgListOrder.Columns["ID"].Visible = false;
        }

        private void setDataForStatusCB() {
            var tableStatus = new BindingList<KeyValuePair<string, string>>();
            tableStatus.Add(new KeyValuePair<string, string>("0", "0"));
            tableStatus.Add(new KeyValuePair<string, string>("1", "1"));
            cbStatus.DataSource = tableStatus;
            cbStatus.ValueMember = "Key";
            cbStatus.DisplayMember = "Value";
            cbStatus.SelectedIndex = (int)currentTalbe.STATUS;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int tableName = int.Parse(txtTableName.Text);
            if (tableName != currentTalbe.TABLE_NAME) {
                if (BUSTable.Instance.GetTableByName(tableName) != null) {
                    lbInfor.Visible = true;
                    lbInfor.Text = "Tên bàn đã tồn tại";
                    txtTableName.Focus();
                    return;
                }
            }
            if (BUSOrder.Instance.getListDetailOrderByTableID(currentTalbe.ID).Count > 0 && int.Parse(cbStatus.Text) != currentTalbe.STATUS) {
                lbInfor.Visible = true;
                lbInfor.Text = "Thanh toán order. để thay đổi status!";
                return;
            }
            lbInfor.Visible = false;
            currentTalbe.TABLE_NAME = tableName;
            currentTalbe.STATUS = int.Parse(cbStatus.Text);
            BUSTable.Instance.UpdateTable(currentTalbe);
            MessageBox.Show("Sửa thông tin bàn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }

        public event EventHandler ButtonClicked;

        public void NotifyButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);

        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (BUSOrder.Instance.getListDetailOrderByTableID(currentTalbe.ID).Count > 0) {
                MessageBox.Show("bạn chỉ có thể xóa bàn khi status là 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                BUSTable.Instance.DeleteTable(currentTalbe);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }      
        }
    }
}
