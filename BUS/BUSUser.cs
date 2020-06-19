using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

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


        public void AddEmployee(string fullName, string gender, string address, int role, string userName, string passWord)
        {
            DAOUser.Instance.AddEmployee(fullName, gender, address, role, userName, passWord);
        }

        public bool UpdateEmployee(int id, string fullName, string gender, string address, int role, string password)
        {
            return DAOUser.Instance.UpdateEmployee(id, fullName, gender, address, role, password);
        }

        public bool DeleteEmployee(int id)
        {
            return DAOUser.Instance.DeleteEmployee(id);
        }


        public void Show(DataGridView dataGridView)
        {
            dataGridView.DataSource = DAOUser.Instance.Show();
        }

        public void ShowPermission(ComboBox cbb, string type, int id)
        {
            cbb.DataSource = DAOUser.Instance.ShowPermission();
            cbb.ValueMember = "ID";
            cbb.DisplayMember = "ROLE_TYPE";

            if(type == "UPDATE")
            {
                cbb.SelectedValue = id;
            }
        }

        public void Search(DataGridView dataGridView, string searchName)
        {
            dataGridView.DataSource = DAOUser.Instance.Search(searchName);
        }
    }
}
