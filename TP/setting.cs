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

        }
    }
}
