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

        public List<TABLE> GetListTables() {
            List<TABLE> tables = new List<TABLE>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                tables = (from t in db.TABLEs orderby t.TABLE_NAME select t).ToList();
            }
            return tables;
        }

        public void UpdateTable(TABLE table) {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext()) {
                TABLE tb = (from t in db.TABLEs where t.ID == table.ID select t).FirstOrDefault();
                tb.STATUS = table.STATUS;
                tb.TABLE_NAME = table.TABLE_NAME;
                db.SubmitChanges();
            }
        }

        public void DeleteTable(TABLE table) {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                TABLE tb = (from t in db.TABLEs where t.ID == table.ID select t).FirstOrDefault();
                db.TABLEs.DeleteOnSubmit(tb);
                db.SubmitChanges();
            }
        }

        public TABLE GetTableByName(int tableName) {
            TABLE tb = null;
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                tb = (from t in db.TABLEs where t.TABLE_NAME == tableName select t).FirstOrDefault();
                return tb;
            }
        }

        public void AddNewTable(int tableName){
            TABLE tb = new TABLE();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                tb.TABLE_NAME = tableName;
                tb.STATUS = 0;
                db.TABLEs.InsertOnSubmit(tb);
                db.SubmitChanges();
            }
        }
    }
}
