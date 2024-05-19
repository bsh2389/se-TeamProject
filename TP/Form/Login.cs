using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Login : Form
    {
        Main main;
        TextBox[] txtList;
        const string IdPlaceholder = "아이디";
        const string PwPlaceholder = "비밀번호";
        LoginController loginController;

        public Login(Main main)
        {
            InitializeComponent();
            this.main = main;
            txtList = new TextBox[] { textBox1, textBox2 };
            foreach (var txt in txtList)
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == textBox1)
                    txt.Text = IdPlaceholder;
                else if (txt == textBox2)
                    txt.Text = PwPlaceholder;
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
            loginController = new LoginController();
        }


        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            {
                txt.ForeColor = Color.Black;
                txt.Text = String.Empty;
                if (txt == textBox2)
                    textBox2.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == textBox1)
                    txt.Text = IdPlaceholder;
                else if (txt == textBox2)
                {
                    txt.Text = PwPlaceholder;
                    textBox2.PasswordChar = default;
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pw = textBox2.Text;
            loginController.checkUser(id, pw);
            if (loginController.IsLoginSuccess())
                this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginController.IsLoginSuccess()) //로그인 성공하면 그냥 메인문도 닫히기 때문에 로그인 성공하지 못한상태에서 닫을시 메인문도 닫힘
                main.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LoginIDSave != IdPlaceholder)
            {
                checkBox1.Checked = true;
                textBox1.Text = Properties.Settings.Default.LoginIDSave;
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
