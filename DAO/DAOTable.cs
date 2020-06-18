using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOTable
    {
        private static DAOTable instance;

        public static DAOTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOTable();
                }
                return instance;
            }
        }

        public List<TABLE> GetListTables(){
            List<TABLE> tables = new List<TABLE>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                tables = (from t in db.TABLEs select t).ToList();
            }
            return tables;
        }
    }
}
