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
    }
}
