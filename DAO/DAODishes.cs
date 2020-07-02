using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAODishes
    {
        private static DAODishes instance;

        public static DAODishes Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAODishes();
                }
                return instance;
            }
        }
        public List<FOOD> Show()
        {
            List<FOOD> dishes = new List<FOOD>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                dishes = db.FOODs.Select(p => p).ToList();
            }
            return dishes;
        }

        public Boolean Insert_Food(FOOD food, List<FOOD_RESOURCE> fOODs)
        {
            if(food != null)
            {
                using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
                {
                    try
                    {
                        db.FOODs.InsertOnSubmit(food);
                        db.SubmitChanges();
                        Insert_Resource_Food(fOODs, food.ID);
                        return true;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }

                }
            }
            return false;
        }

        public List<FOOD_RESOURCE> FoodResource()
        {
            List<FOOD_RESOURCE> lstResource = new List<FOOD_RESOURCE>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                lstResource = db.FOOD_RESOURCEs.ToList();
            }
            return lstResource;
        }

        public void Insert_Resource_Food(List<FOOD_RESOURCE> fOODs, int id)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                List<FOOD_RESOURCE_MATERIAL> foodMaterial = new List<FOOD_RESOURCE_MATERIAL>();
                foreach(FOOD_RESOURCE fOOD_ in fOODs)
                {
                    FOOD_RESOURCE_MATERIAL fOOD_RESOURCE_MATERIAL = new FOOD_RESOURCE_MATERIAL();
                    fOOD_RESOURCE_MATERIAL.ID_FOOD = id;
                    fOOD_RESOURCE_MATERIAL.ID_RESOURCE = fOOD_.ID;
                    foodMaterial.Add(fOOD_RESOURCE_MATERIAL);
                }
                db.FOOD_RESOURCE_MATERIALs.InsertAllOnSubmit(foodMaterial);
                db.SubmitChanges();
            }
        }
    }
}
