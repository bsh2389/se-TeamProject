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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string DB_Server_Info = "Data Source = localhost;" +
            "User ID = system; Password = 1;";
        private void Order_Load(object sender, EventArgs e)
        {
            string categori ="";
            if (radioButton1.Checked == true)
            {
                categori = radioButton1.Text;
            }else if (radioButton2.Checked == true)
            {
                categori = radioButton2.Text;
            }
            else
            {
                categori = radioButton3.Text;
            }
            try
            {
                
                string sqltxt = "select * from 제품";
                OracleConnection conn = new OracleConnection(DB_Server_Info);
                conn.Open();
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = new OracleCommand(sqltxt, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
               
                dataGridView1.AllowUserToAddRows = false; //빈레코드 표시x
                var chkCol = new DataGridViewCheckBoxColumn
                {
                    Name = "chk",
                    HeaderText = "선택"
                };
                dataGridView1.Columns.Add(chkCol);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;   //데이터 추가 부분


                //크기 조절부분 
                dataGridView1.Columns[0].Width = 35; 


                //dataGridView1.ReadOnly = true; //전부 읽기 전용           
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[7].ReadOnly = true;


                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //검색부분
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save 부분
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            //닫혔을때 save 하는지 물어보는 부분 
            MessageBox.Show("저장하시겠습니까?"); //예,아니요,취소 부분 되게 
        }
    }
}
