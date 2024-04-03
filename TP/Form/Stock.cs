using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;


namespace TP
{
    public partial class Stock : Form
    {
        string DB_Server_Info = "Data Source = localhost; User ID = system; Password = 1234;";
        private string categori = null;
        private string label = "제품명";
        private int selectsusses = 0; //검색 성공 
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
                if (!string.IsNullOrEmpty(categori)) // Check if categori is not empty or null
                {
                    dt.DefaultView.RowFilter = $"카테고리 ='{categori}'";
                }
                //dt.DefaultView.RowFilter = $"카테고리 ='{categori}'";
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
            if (radioButton4.Checked == true)
            {
                categori = null;
                dataview();

            }
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
            else if (radioButton3.Checked == true)
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
            selectsusses = 0;
            label = comboBox1.Text;
            find();
        }
        private void find() //검색 부분
        {
            string keyword = textBox1.Text;//Textbox에 입력된 메시지를 keyword 저장
                                           // 인덱스를 찾을 이름, 검색할 입력값

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[$"{label}"].Value.ToString().Trim() == keyword.Trim())
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;  //색칠
                    selectsusses = 1;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            if (selectsusses == 0)
            {
                MessageBox.Show("검색 결과가 없습니다.");
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}
