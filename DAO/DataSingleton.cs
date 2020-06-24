using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataSingleton
    {
        private static DataSingleton _instance;
        private static int _idUser;
        public static DataSingleton GetInstance()
        {
            if(_instance==null)
            {
                _instance = new DataSingleton();
                _idUser = -1;
            }
            return _instance;
        }

        public int GetIdUser()
        {
            return _idUser;
        }

        public void SetIdUser(int value)
        {
            _idUser = value;
        }
    }
}
