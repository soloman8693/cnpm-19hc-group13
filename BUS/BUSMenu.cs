using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSMenu
    {
        private static BUSMenu instance;

        public static BUSMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSMenu();
                }
                return instance;
            }
        }

        public void Show(DataGridView gridView)
        {
            gridView.DataSource = DAOMenu.Instance.Show();
        }
        public Boolean Insert_Menu(MENU menu, List<FOOD> foods)
        {
            List<FOOD> temp = new List<FOOD>(foods);
            temp.RemoveAt(temp.Count - 1);
            return DAOMenu.Instance.Insert_Menu(menu, temp);
        }
        public List<FOOD> FoodMenu()
        {
            return DAOMenu.Instance.FoodMenu();
        }

        public List<FOOD> Get_Food(int food_id)
        {
            return DAOMenu.Instance.Get_Food(food_id);
        }
    }
}
