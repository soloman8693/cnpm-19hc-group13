using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    public class OrderInfo
    {
        public int ID { get; set; }
        public int ID_TABLE { get; set; }
        public int ID_USER { get; set; }
        public string FULL_NAME_USER { get; set; }
        public int TABLE_NAME { get; set; }
        public double TOTAL_MONEY { get; set; }
    }


    public class DAOOrder
    {
        private static DAOOrder instance;
        private static int _idOrder;
        public static DAOOrder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOOrder();
                    _idOrder = -1;
                }
                return instance;
            }
        }

        public int GetIdOrder()
        {
            return _idOrder;
        }

        public void SetIdOrder(int value)
        {
            _idOrder = value;
        }

        public List<OrderInfo> OrderList()
        {
            List<OrderInfo> list = new List<OrderInfo>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                list = (from order in db.ORDERs
                        join table in db.TABLEs on order.ID_TABLE equals table.ID
                        join user in db.USERs on order.ID_USER equals user.ID
                        select new OrderInfo
                        {
                            ID = order.ID,
                            ID_TABLE = (int)order.ID_TABLE,
                            ID_USER = (int)order.ID_USER,
                            FULL_NAME_USER = user.FULL_NAME,
                            TABLE_NAME = (int)table.TABLE_NAME,
                            TOTAL_MONEY = (double)order.TOTAL_MONEY
                        }).ToList();
            }
            return list;
        }

        public List<DETAIL_ORDER> OrderListDetail(int idOrder)
        {
            List<DETAIL_ORDER> list = new List<DETAIL_ORDER>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                list = db.DETAIL_ORDERs.Where(o => o.ID_ORDER == idOrder).ToList();
            }
            return list;
        }
    }
}
