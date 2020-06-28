using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

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
        }
    }
}
