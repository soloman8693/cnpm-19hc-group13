using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOUser
    {
        private static DAOUser instance;

        public static DAOUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOUser();
                }
                return instance;
            }
        }
        public USER SignIn(string UserName, string PassWord)
        {
            USER RegistedUser = null;
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                RegistedUser = (USER)(from u in db.USERs where u.USER_NAME == UserName.Trim() && u.PASSWORD == PassWord.Trim() select u).FirstOrDefault();
            }
            return RegistedUser;
        }
     
        public void RememberSignIn(string UserName,string PassWord,Boolean Remember) {
            USER RegistedUser = null;
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                RegistedUser = (USER)(from u in db.USERs where u.USER_NAME.Trim() == UserName && u.PASSWORD == PassWord.Trim() select u).FirstOrDefault();
                RegistedUser.REMEMBER = Remember == true ? 1 : 0;
                db.SubmitChanges();
            }

        }

        public USER CheckRememberUser(string UserName) {
            USER user = null;
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                user = (USER)(from u in db.USERs where u.USER_NAME == UserName.Trim() && u.REMEMBER == 1 select u).FirstOrDefault();
                return user;

            }
        }
    }
}
