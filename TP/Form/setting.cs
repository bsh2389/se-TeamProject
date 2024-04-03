using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace TP
{
    public partial class setting : Form
    {
        Main main;
        public setting(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //로그아웃 버튼
            this.Visible = false;
            Form form = new Login(main);      
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //회원정보 버튼

            string _strConn = "Data Source=localhost;User Id=system;Password=1234;"; // 데이터 읽기

            using (OracleConnection conn = new OracleConnection(_strConn))
            {         // 연결

                conn.Open();

                // 명령 객체 생성
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM 회원";

                // 결과 리더 객체를 리턴
                OracleDataReader rdr = cmd.ExecuteReader();

                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    string db_id = rdr["회원아이디"].ToString().Trim();
                    if (db_id == Properties.Settings.Default.userID.ToString())
                    {
                        // 필드 데이터 읽기
                        string id = rdr["회원아이디"] as string;
                        string name = rdr["회원이름"] as string;
                        string duty = rdr["직책"] as string;
                        string adress = rdr["편의점주소"] as string;
                        MessageBox.Show("회원 아이디 : " + id +
                         "\n회원 이름 : " + name +
                         "\n회원 직책 : " + duty +
                         "\n편의점주소 : " + adress , "회원정보"); // 메시지박스에 출력
                    }
                }

                rdr.Close(); // 사용후 닫음
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
