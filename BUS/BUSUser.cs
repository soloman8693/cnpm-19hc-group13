using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSUser
    {
        private static BUSUser instance;

        public static BUSUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSUser();
                }
                return instance;
            }
        }
        public USER SignIn(string UserName, string PassWord)
        {
            return DAOUser.Instance.SignIn(UserName, PassWord);
        }

        public void RememberSignIn(string UserName, string PassWord, Boolean Remember) {
            DAOUser.Instance.RememberSignIn(UserName, PassWord,Remember);
        }

        public USER CheckRememberUser(string UserName) {
            return DAOUser.Instance.CheckRememberUser(UserName);
        }
    }
}
