using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Windows.Forms;

namespace BUS
{
    public class BUSTable
    {
        private static BUSTable instance;

        public static BUSTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSTable();
                }
                return instance;
            }
        }

        public List<TABLE> GetListTables()
        {
            return DAOTable.Instance.GetListTables();
        }

        public void UpdateTable(TABLE table)
        {
            DAOTable.Instance.UpdateTable(table);
        }

        public void DeleteTable(TABLE table)
        {
            DAOTable.Instance.DeleteTable(table);
        }

        public TABLE GetTableByName(int tableName)
        {
            return DAOTable.Instance.GetTableByName(tableName);
        }

        public void AddNewTable(int tableName)
        {
            DAOTable.Instance.AddNewTable(tableName);
        public void GetTableAvailable(ComboBox cbb, string type, int id)
        {
            cbb.DataSource = DAOTable.Instance.GetTableAvailable();
            cbb.ValueMember = "ID";
            cbb.DisplayMember = "TABLE_NAME";

            if (type == "UPDATE")
            {
                cbb.SelectedValue = id;
            }
        }

        public void addBookTable(string customerName, string phone, int idTable, DateTime date, TimeSpan time, int idUser)
        {
            DAOTable.Instance.addBookTable(customerName, phone, idTable, date, time, idUser);
            DAOOrder.Instance.AddOrder(idUser, idTable);
            DAOTable.Instance.updateStatusTableNotAvailable(idTable);
        }
    }
}
