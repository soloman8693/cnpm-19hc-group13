using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSDishes
    {
        private static BUSDishes instance;

        public static BUSDishes Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSDishes();
                }
                return instance;
            }
        }

        public void ShowDishes(DataGridView dataGridView)
        {
            dataGridView.DataSource = DAODishes.Instance.Show();
        }

        public Boolean Insert_Food(FOOD food, List<FOOD_RESOURCE> fOODs)
        {
            List<FOOD_RESOURCE> temp = new List<FOOD_RESOURCE>(fOODs);
            temp.RemoveAt(temp.Count - 1);
            return DAODishes.Instance.Insert_Food(food, temp);
        }

        public List<FOOD_RESOURCE> FoodResource()
        {
            return DAODishes.Instance.FoodResource();
        }
    }
}
