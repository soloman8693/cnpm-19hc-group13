﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOUser
    {
        private static DAOUser instance;

        public class UserRole
        {
            public int ID { get; set; }
            public string FULL_NAME { get; set; }
            public string GENDER { get; set; }
            public string ADDRESS { get; set; }
            public string ROLE { get; set; }
            public int ID_ROLE { get; set; }
            public string PASSWORD { get; set; }
        }

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
            USER RegistedUser;
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                RegistedUser = (USER)(from u in db.USERs where u.USER_NAME.Trim() == UserName && u.PASSWORD == PassWord.Trim() select u).FirstOrDefault();
               // var RegistedUser = (from u in db.USERs select u).FirstOrDefault();
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

        public void AddEmployee(string fullName, string gender, string address, int role, string userName, string passWord)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                USER user = new USER();
                user.FULL_NAME = fullName;
                user.GENDER = gender;
                user.ADDRESS = address;
                user.ROLE = role;
                user.USER_NAME = userName;
                user.PASSWORD = passWord;
                user.REMEMBER = 0;

                db.USERs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }


        public bool UpdateEmployee(int id, string fullName, string gender, string address, int role, string password)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                USER us = db.USERs.Single(u => u.ID == id);
                us.FULL_NAME = fullName;
                us.GENDER = gender;
                us.ADDRESS = address;
                us.ROLE = role;
                us.PASSWORD = password;

                db.SubmitChanges();

                return true;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                USER us = db.USERs.Single(u => u.ID == id);
                db.USERs.DeleteOnSubmit(us);
                db.SubmitChanges();
                return true;
            }
        }

        public List<UserRole> Show()
        {
            List<UserRole> names = new List<UserRole>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                names = (from us in db.USERs join ps in db.PERMISSIONs on us.ROLE equals ps.ID select new UserRole {
                    ID = us.ID, 
                    FULL_NAME = us.FULL_NAME,
                    GENDER = us.GENDER,
                    ADDRESS = us.ADDRESS,
                    ID_ROLE = us.ROLE,
                    ROLE = ps.ROLE_TYPE,
                    PASSWORD = us.PASSWORD
                    }).ToList();
            }
            return names;
        }

        public List<PERMISSION> ShowPermission()
        {
            List<PERMISSION> pers = new List<PERMISSION>();

            using(QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                pers = db.PERMISSIONs.ToList();
            }
            return pers;
        }

        public List<UserRole> Search(string searchName)
        {
            List<UserRole> names = new List<UserRole>();
            using (QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext())
            {
                names = (from us in db.USERs
                         join ps in db.PERMISSIONs on us.ROLE equals ps.ID
                         select new UserRole
                         {
                             ID = us.ID,
                             FULL_NAME = us.FULL_NAME,
                             GENDER = us.GENDER,
                             ADDRESS = us.ADDRESS,
                             ID_ROLE = us.ROLE,
                             ROLE = ps.ROLE_TYPE,
                             PASSWORD = us.PASSWORD
                         }).Where(x => x.FULL_NAME.Contains(searchName)).ToList();
            }
            return names;
        }
    }
}
