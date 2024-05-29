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
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new Order())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new Return())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new Stock())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new setting(this))
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void sale_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new sale())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new receipt())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void productinformation_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new productinformation())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void salesfigures_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new salesfigures())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rateofreturn_Click(object sender, EventArgs e)
        {
            // 메인 폼을 숨깁니다.
            this.Hide();

            // 판매 폼을 생성하고 표시합니다
            using (Form form = new rateofreturn())
            {
                // ShowDialog()를 사용해 판매 폼을 모달로 표시합니다.
                form.ShowDialog();

                // 판매 폼이 닫히면 메인 폼을 다시 표시합니다.
                this.Show();
            }
        }
    }
}
