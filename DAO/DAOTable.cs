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

        public List<TABLE> GetTableAvailable()
        {
            List<TABLE> list = new List<TABLE>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                list = db.TABLEs.Where(t => t.STATUS == 1).ToList();
            }
            return list;
        }

        public void addBookTable(string customerName, string phone, int idTable, DateTime date, TimeSpan time, int idUser)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                RESERVATION res = new RESERVATION();

                res.CUSTOMER_NAME = customerName;
                res.PHONE = phone;
                res.ID_TABLE = idTable;
                res.STATUS = 0;
                res.DATE = date;
                res.TIME = time;
                res.ID_USER = idUser;

                db.RESERVATIONs.InsertOnSubmit(res);
                db.SubmitChanges();
            }
        }

        public bool updateStatusTableNotAvailable(int idTable)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                TABLE tb = db.TABLEs.Single(p => p.ID == idTable);
                tb.STATUS = 0;
                db.SubmitChanges();
                return true;
            }
        } 
    }
}
