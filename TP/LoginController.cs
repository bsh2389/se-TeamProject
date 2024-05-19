using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TP
{
    public class LoginController
    {
        private Login login;

        public LoginController(Login login)
        {
            this.login = login;
        }

        private string DB_Server_Info = "Data Source = localhost;" +
           "User ID = system; Password = 1234;";
        private int ls = 0; //로그인 성공 여부 
        private int ll = 0; //사용자 없는지 유무

        public void checkUser(string id, string pw)
        {
            DataSet ds = new DataSet();

            string sqltxt = "select * from 회원";
            OracleConnection conn = new OracleConnection(DB_Server_Info); //db 연결
            conn.Open();
            OracleCommand cmd = new OracleCommand(sqltxt, conn);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string db_id = reader["회원아이디"].ToString().Trim(); //db상 아이디 비번뒤 공백 삭제
                string db_pw = reader["회원비번"].ToString().Trim();

                if (id == "아이디" || pw == "비밀번호")
                {
                    ll = 0;
                    MessageBox.Show("ID 또는 Password를입력하세요.");
                    break;
                }
                else if (db_id == id)
                {
                    if (db_pw == pw)
                    {
                        Properties.Settings.Default.userID = id; //나중에 db상 주소지 찾을때 사용
                        Properties.Settings.Default.Save();
                        ls = 1;
                        ll = 0;
                        MessageBox.Show("로그인에 성공했습니다.", "로그인 성공");
                        login.CloseForm();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("잘못된 비밀번호 입니다.", "로그인 실패");
                        ll = 0;
                        break;
                    }
                }
                else
                {
                    ll = 1;
                }
            }
            if (ll == 1)
            {
                MessageBox.Show("없는 사용자 입니다.");
            }
            conn.Close();
        }

        public bool IsLoginSuccess()
        {
            return ls == 1;
        }
    }
}
