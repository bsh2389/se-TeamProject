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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form form = new Login(this); 
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Order();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Return();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Stock();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new setting(this);
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new sale();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new receipt();
            form.ShowDialog();
        }
    }
}
