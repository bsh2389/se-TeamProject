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

        private void Order_Click(object sender, EventArgs e)
        {
            Form form = new Order();
            form.ShowDialog();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form form = new Return();
            form.ShowDialog();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Form form = new Stock();
            form.ShowDialog();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            Form form = new setting(this);
            form.ShowDialog();
        }

        private void sale_Click(object sender, EventArgs e)
        {
            Form form = new sale();
            form.ShowDialog();
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            Form form = new receipt();
            form.ShowDialog();
        }

        private void productinformation_Click(object sender, EventArgs e)
        {
            Form form = new productinformation();
            form.ShowDialog();
        }

        private void salesfigures_Click(object sender, EventArgs e)
        {
            Form form = new salesfigures();
            form.ShowDialog(); 
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rateofreturn_Click(object sender, EventArgs e)
        {
            Form form = new rateofreturn();
            form.ShowDialog();
        }
    }
}
