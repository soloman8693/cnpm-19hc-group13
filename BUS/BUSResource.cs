using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSResource
    {
        private static BUSResource instance;

        public static BUSResource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSResource();
                }
                return instance;
            }
        }

        public void ShowFoodResource(DataGridView dataGridView)
        {
            dataGridView.DataSource = DAOResource.Instance.ShowFoodResource();
        }

        public void InsertResource(FOOD_RESOURCE fOOD_RESOURCE)
        {
            DAOResource.Instance.InsertResource(fOOD_RESOURCE);
        }

        public Boolean UpdateResource(FOOD_RESOURCE fOOD_RESOURCE)
        {
            return DAOResource.Instance.UpdateResource(fOOD_RESOURCE);
        }
    }
}
