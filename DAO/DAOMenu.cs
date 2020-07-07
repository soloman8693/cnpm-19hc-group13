using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOMenu
    {
        private static DAOMenu instance;

        public static DAOMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOMenu();
                }
                return instance;
            }
        }

        public List<MENU> Show()
        {
            using(QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                return db.MENUs.ToList();
            }
        }

        public Boolean Insert_Menu(MENU menu, List<FOOD> foods)
        {
            if (menu != null)
            {
                using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
                {
                    try
                    {
                        db.MENUs.InsertOnSubmit(menu);
                        db.SubmitChanges();
                        Insert_Menu_Food(foods, menu.ID);
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }

                }
            }
            return false;
        }

        public void Insert_Menu_Food(List<FOOD> fOODs, int id)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                List<MENU_FOOD> foodMenu = new List<MENU_FOOD>();
                foreach (FOOD fOOD_ in fOODs)
                {
                    MENU_FOOD menuFood = new MENU_FOOD();
                    menuFood.ID_Menu = id;
                    menuFood.ID_Food = fOOD_.ID;
                    foodMenu.Add(menuFood);
                }
                db.MENU_FOODs.InsertAllOnSubmit(foodMenu);
                db.SubmitChanges();
            }
        }

        public List<FOOD> FoodMenu()
        {
            List<FOOD> lstResource = new List<FOOD>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                lstResource = db.FOODs.ToList();
            }
            return lstResource;
        }

        public List<FOOD> Get_Food(int food_id)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                var result1 = from f in db.FOODs
                              join fm in db.MENU_FOODs on f.ID equals fm.ID_Food
                              where f.ID == food_id
                              select f;
            return result1.ToList();
            }
        }

        //public Boolean Update(int food_id)
        //{

        //}
    }
}
