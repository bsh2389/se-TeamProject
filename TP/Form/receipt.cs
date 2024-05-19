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
using System.IO;

namespace TP
{

    public partial class receipt : Form
    {
        public receipt()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("환불 처리를 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("영수증을 출력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
