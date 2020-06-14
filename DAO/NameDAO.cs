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
        public List<Name> Show()
        {
            List<Name> names = new List<Name>();
            using (DemoLinQDataContext db = new DemoLinQDataContext())
            {
                names = db.Names.Select(p => p).ToList();
            }
                return names;
        }
    }
}
