﻿using DAO;
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
            dataGridView.DataSource = DAOOrder.Instance.OrderList();
        }

        public void OrderListDetail(DataGridView dataGridView, int id)
        {
            dataGridView.DataSource = DAOOrder.Instance.OrderListDetail(id);
        }

        public void ListFoods(ComboBox cbb, string type, int id)
        {
            cbb.DataSource = DAOOrder.Instance.ListFoods();
            cbb.ValueMember = "ID";
            cbb.DisplayMember = "FOOD_NAME";

            if (type == "UPDATE")
            {
                cbb.SelectedValue = id;
            }
        }

        public void ListDrinks(ComboBox cbb, string type, int id)
        {
            cbb.DataSource = DAOOrder.Instance.ListDrinks();
            cbb.ValueMember = "ID";
            cbb.DisplayMember = "DRINK_NAME";

            if (type == "UPDATE")
            {
                cbb.SelectedValue = id;
            }
        }

        public void AddOrderDetail(int idOrder, int idFood, string nameFood, int amountFood, int idDrink, string nameDrink, int amountDrink, double totalMoney)
        {
            DAOOrder.Instance.AddOrderDetail(idOrder, idFood, nameFood, amountFood, idDrink, nameDrink, amountDrink, totalMoney);
        }

        public bool DeleteOrderDetail(int id)
        {
            return DAOOrder.Instance.DeleteOrderDetail(id);
        }

        public bool UpdateOrderDetail(int id, int idFood, string nameFood, int amountFood, int idDrink, string nameDrink, int amountDrink, double total)
        {
            return DAOOrder.Instance.UpdateOrderDetail(id, idFood, nameFood, amountFood, idDrink, nameDrink, amountDrink, total);
        }

        public List<DETAIL_ORDER> getListDetailOrderByTableID(int tableID)
        {
            return DAOOrder.Instance.getListDetailOrderByTableID(tableID);
        }

        public double TotalMoney(int tableID)
        {
            return DAOOrder.Instance.TotalMoney(tableID);
        }

        public void PayMent(int tableID)
        {
            DAOOrder.Instance.PayMent(tableID);
        }
    }
}
