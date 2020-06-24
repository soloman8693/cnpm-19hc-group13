using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSOrder
    {
        private static BUSOrder instance;

        public static BUSOrder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSOrder();
                }
                return instance;
            }
        }

        public void OrderList(DataGridView dataGridView)
        {
            dataGridView.DataSource =  DAOOrder.Instance.OrderList();
        }

        public void OrderListDetail(DataGridView dataGridView, int id)
        {
            dataGridView.DataSource = DAOOrder.Instance.OrderListDetail(id);
        }
    }
}
