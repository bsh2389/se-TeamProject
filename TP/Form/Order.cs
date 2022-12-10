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
        private string DB_Server_Info = "Data Source = localhost;" +
           "User ID = system; Password = 1;";
        private string categori = "음료";
        private string label = "제품명";
        public Order()
        {
            InitializeComponent();
            dataview();
        }
        private void dataview()
        {
            try
            {
                string sqltxt = "select * from 제품";
                OracleConnection conn = new OracleConnection(DB_Server_Info);
                conn.Open();
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = new OracleCommand(sqltxt, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                adapt.Fill(ds);
                dt.Reset();
                dt = ds.Tables[0];
                dataGridView1.Columns.Clear();

                dt.DefaultView.RowFilter = $"카테고리 ='{categori}'";
                dataGridView1.AllowUserToAddRows = false; //빈레코드 표시x
                var chkCol = new DataGridViewCheckBoxColumn
                {
                    Name = "chk",
                    HeaderText = "선택"
                };
                dataGridView1.Columns.Add(chkCol);
                dataGridView1.DataSource = dt;   //데이터 추가 부분
                dataGridView1.Columns.Add("발주량", "발주량");
                dataGridView1.Columns.Add("비고", "비고");

                //크기 조절부분 
                dataGridView1.Columns[0].Width = 40;

                // dataGridView1.ReadOnly = true; //전부 읽기 전용
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[7].ReadOnly = true;
                dataGridView1.Columns[8].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e) //검색 부분
        {
            label = comboBox1.Text;
            find();
        }

        private void button1_Click(object sender, EventArgs e) //save 부분
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value)) //체크된 데이터 선택 부분
                {
                    try
                    {
                        string sqlctxt = "select * from 회원";
                        OracleConnection conn = new OracleConnection(DB_Server_Info);
                        conn.Open();
                        OracleCommand cmd = new OracleCommand(sqlctxt, conn);
                        OracleDataReader reader = cmd.ExecuteReader();
                        string user_address = "";
                        while (reader.Read())
                        {
                            string db_id = reader["회원아이디"].ToString().Trim();
                            if (db_id == Properties.Settings.Default.userID.ToString())
                            {
                                user_address = reader["편의점주소"].ToString().Trim();
                                break;
                            }
                        }


                        //DateTime.Now.ToString("yyyy-MM-dd"); 현재 시각
                        OracleCommand oc = new OracleCommand();
                        oc.Connection = conn;
                        oc.CommandText = "insert into 주문 (발주번호,주문고객,발주제품,수량,배송지,주문일자) values(:발주번호, :주문고객, :발주제품,:수량,:배송지,:주문일자)";
                        oc.BindByName = true;
                        oc.Parameters.Add(new OracleParameter("발주번호", Properties.Settings.Default.Orderindex.ToString()));
                        oc.Parameters.Add(new OracleParameter("주문고객", Properties.Settings.Default.userID.ToString()));
                        oc.Parameters.Add(new OracleParameter("발주제품", dataGridView1.Rows[i].Cells[4].Value.ToString()));
                        oc.Parameters.Add(new OracleParameter("수량", Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value)));
                        oc.Parameters.Add(new OracleParameter("배송지", user_address));
                        oc.Parameters.Add(new OracleParameter("주문일자", DateTime.Now.ToString("yyyy-MM-dd").ToString()));
                        //발주 번호 //주문고객// 제품번호 // 수량 // 배송지 // 주문일자// 

                        if (conn.State == ConnectionState.Open) conn.Close();
                        conn.Open();
                        oc.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Properties.Settings.Default.Orderindex += 1; //발주번호 값증가시키기
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;  //선택된 데이터 노란색으로 보임
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }

        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            //닫혔을때 save 하는지 물어보는 부분 
            MessageBox.Show("저장하시겠습니까?"); //예,아니요,취소 부분 되게 
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
