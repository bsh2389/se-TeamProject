using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TP
{
    public class LoginController
    {
        private string DB_Server_Info = "Data Source = localhost;" +
           "User ID = system; Password = 1234;";
        private Boolean loginsucces = false; //로그인 성공 여부 
        private Boolean noneUser = false; //사용자 없는지 유무

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
                    noneUser = false;
                    MessageBox.Show("ID 또는 Password를입력하세요.");
                    break;
                }
                else if (db_id == id)
                {
                    if (db_pw == pw)
                    {
                        Properties.Settings.Default.userID = id; //나중에 db상 주소지 찾을때 사용
                        Properties.Settings.Default.Save();
                        loginsucces = true;
                        noneUser = false;
                        MessageBox.Show("로그인에 성공했습니다.", "로그인 성공");                      
                        break;
                    }
                    else
                    {
                        MessageBox.Show("잘못된 비밀번호 입니다.", "로그인 실패");
                        noneUser = false;
                        break;
                    }
                }
                else
                {
                    noneUser = true;
                }
            }
            if (noneUser)
            {
                MessageBox.Show("없는 사용자 입니다.");
            }
            conn.Close();
        }

        public bool IsLoginSuccess()
        {
            return loginsucces;
        }
    }
}
