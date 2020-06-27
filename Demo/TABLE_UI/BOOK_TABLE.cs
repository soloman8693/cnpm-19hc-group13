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

namespace Demo.TABLE_UI
{
    public partial class BOOK_TABLE : Form
    {
        public BOOK_TABLE()
        {
            InitializeComponent();
        }

        private void BOOK_TABLE_Load(object sender, EventArgs e)
        {
            BUS.BUSTable.Instance.GetTableAvailable(cbbTable, "ADD", 0);
            txtDateFrom.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtTimeFrom.Text = DateTime.Now.ToString("HH:mm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameBook = txtNameBook.Text;
            if(nameBook == "")
            {
                MessageBox.Show("Người đặt không được để trống");
            }
            else
            {
                string phone = txtPhone.Text;
                if (phone.Length > 11 || phone.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                }
                else
                {
                    int idTable = Int32.Parse(cbbTable.SelectedValue.ToString());

                    DateTime.TryParse(txtDateFrom.Text, out DateTime date);
                    DateTime.TryParse(txtTimeFrom.Text, out DateTime time);
                    int idUser = DAO.DataSingleton.GetInstance().GetIdUser();

                    BUSTable.Instance.addBookTable(nameBook, phone, idTable, date, time.TimeOfDay, idUser);
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
