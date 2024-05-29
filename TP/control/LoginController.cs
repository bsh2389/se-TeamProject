using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TP
{
    public class LoginController
    {
        private bool loginsucces = false; //로그인 성공 여부 
        public bool checkUser(string id, string pw)
        {
            UserEntity userEntity = new UserEntity();
            if (userEntity.IsUserExists(id, pw))
            {               
                loginsucces = true;      
            }
            else
            {
                loginsucces = false;
            }
            return loginsucces;
        }
    }
}
