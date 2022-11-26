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
            try
            {
                string sqltxt = "select * from 제품";
                OracleConnection conn = new OracleConnection(DB_Server_Info);
                conn.Open();
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = new OracleCommand(sqltxt, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
