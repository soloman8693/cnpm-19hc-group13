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

namespace Demo.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            BUSMenu.Instance.Show(dataGridViewMenu);
        }

        private void btbThem_Click(object sender, EventArgs e)
        {
            Boolean AddFlag = true;
            Menu_UI.frmAddMenu addMENU = new Menu_UI.frmAddMenu(AddFlag, null, this);
            addMENU.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Boolean AddFlag = false;
            Menu_UI.frmAddMenu addMENU = new Menu_UI.frmAddMenu(AddFlag, (MENU)dataGridViewMenu.CurrentRow.DataBoundItem, this);
            addMENU.Show();
        }

        public void reload()
        {
            BUSMenu.Instance.Show(dataGridViewMenu);
            dataGridViewMenu.Update();
            dataGridViewMenu.Refresh();
        }
    }
}
