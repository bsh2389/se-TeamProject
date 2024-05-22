using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TP
{
    public partial class salesfigures : Form
    {
        public salesfigures()
        {
            InitializeComponent();
            // 년도 설정
            DateTime today = DateTime.Today;
            int thisYear = today.Year;
            for (int i = thisYear - 5; i < thisYear + 6; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            comboBox2.Text = thisYear.ToString();
            // 월 설정
            for (int i = 1; i < 13; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox1.Text = today.Month.ToString();


        }
        private void setDate() { }
        private void button1_Click(object sender, EventArgs e)
        {
            //일일 판매실적, 월별 판매실적, 대분류별 판매실적
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                dateTimePicker1.Visible = false;
            }
            else if (radioButton1.Checked == true)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                dateTimePicker1.Visible = true;
            }
            if (radioButton3.Checked == true) {
                dataGridView1.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;
            }
            else
            {
                dataGridView1.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
            }
        }
    }
}
