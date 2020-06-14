using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class NameBUS
    {
        private static NameBUS instance;

        public static NameBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NameBUS();
                }
                return instance;
            }
        }
        public void Show(DataGridView dataGridView)
        {
            dataGridView.DataSource = NameDAO.Instance.Show();
        }
    }
}
