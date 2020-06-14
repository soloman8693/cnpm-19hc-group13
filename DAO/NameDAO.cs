using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NameDAO
    {
        private static NameDAO instance;

        public static NameDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new NameDAO();
                }
                return instance;
            }
        }
        public List<USER> Show()
        {
            List<USER> names = new List<USER>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                names = db.USERs.Select(p => p).ToList();
            }
                return names;
        }
    }
}
