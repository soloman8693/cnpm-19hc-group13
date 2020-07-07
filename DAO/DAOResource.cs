using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOResource
    {
        private static DAOResource instance;

        public static DAOResource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOResource();
                }
                return instance;
            }
        }

        public List<FOOD_RESOURCE> ShowFoodResource()
        {
            List<FOOD_RESOURCE> lstFoodResource = new List<FOOD_RESOURCE>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                lstFoodResource = db.FOOD_RESOURCEs.ToList();
            }
            return lstFoodResource;
        }

        public void InsertResource(FOOD_RESOURCE fOOD_RESOURCE)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                db.FOOD_RESOURCEs.InsertOnSubmit(fOOD_RESOURCE);
                db.SubmitChanges();
            }
        }

        public Boolean UpdateResource(FOOD_RESOURCE fOOD_RESOURCE)
        {
            try
            {
                using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
                {
                    FOOD_RESOURCE fOOD_RESOURCE1 = db.FOOD_RESOURCEs.Single(resource => resource.ID == fOOD_RESOURCE.ID);
                    fOOD_RESOURCE1.ADD_RESOURCE = fOOD_RESOURCE.ADD_RESOURCE;
                    fOOD_RESOURCE1.REQUEST_STATUS = false;
                    db.SubmitChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
