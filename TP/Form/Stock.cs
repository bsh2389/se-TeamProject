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
    public partial class Stock : Form
    {
        string DB_Server_Info = "Data Source = localhost; User ID = system; Password = 1;";
        private string categori = "음료";
        private string label = "제품명";
        public Stock()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //콤보 박스 읽기 전용
            comboBox1.Text = label;
            dataview();
        }

        private void dataview()
        {
            

            try
            {
                string sqltxt = "select * from 재고";
                OracleConnection conn = new OracleConnection(DB_Server_Info);
                conn.Open();
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = new OracleCommand(sqltxt, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                adapt.Fill(ds);
                dt.Reset();
                dt = ds.Tables[0];
                dt.DefaultView.RowFilter = $"카테고리 ='{categori}'";
                dataGridView1.AllowUserToAddRows = false; //빈레코드 표시x

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //카테고리 선택
        {
            if (radioButton1.Checked == true)
            {
                categori = radioButton1.Text;
                dataview();

            }
            else if (radioButton2.Checked == true)
            {
                categori = radioButton2.Text;
                dataview();
            }
            else
            {
                categori = radioButton3.Text;
                dataview();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exit 버튼 - 클릭 시 창 닫음
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label = comboBox1.Text;
            find();
        }
        private void find() //검색 부분
        {
            String keyword = textBox1.Text;//Textbox에 입력된 메시지를 keyword 저장
                                           // 인덱스를 찾을 이름, 검색할 입력값

            DataTable dt = (DataTable)dataGridView1.DataSource;
            // MessageBox.Show(dt.Columns[3].ToString());       제품명 나옴
            //DataColumn dc = new DataColumn();

            try
            {
                DataRow[] dr = dt.Select($"{label} = '{keyword}'"); //제품명에서 비교
                int i = dt.Rows.IndexOf(dr[0]);     //찾은 배열의 특정컬럼으로뽑기

                foreach (DataRow _dr in dr)
                {
                    //int test = (int)_dr[0];
                    dataGridView1.Rows[i % 3].DefaultCellStyle.BackColor = Color.Yellow;  //색칠
                }
            }
            catch (Exception)
            {
                MessageBox.Show("검색 결과가 없습니다.");
            }

        }
    }
}
