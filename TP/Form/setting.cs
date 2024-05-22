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
        readonly UserEntity userEntity;

        public setting(Main main)
        {
            this.main = main;
            InitializeComponent();
            userEntity = new UserEntity();
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
            string id = Properties.Settings.Default.userID.ToString();
            Dictionary<string, string> userInfo = userEntity.GetUserInfo(id);

            if (userInfo != null)
            {
                MessageBox.Show("회원 아이디 : " + userInfo["회원아이디"] +
                 "\n회원 이름 : " + userInfo["회원이름"] +
                 "\n회원 직책 : " + userInfo["직책"] +
                 "\n편의점주소 : " + userInfo["편의점주소"], "회원정보"); // 메시지박스에 출력
            }
            else
            {
                MessageBox.Show("사용자 정보를 찾을 수 없습니다.", "오류");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
