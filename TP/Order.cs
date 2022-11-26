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
        private string DB_Server_Info = "Data Source=localhost:1521/xe;" +
            "User ID = system; Password = 1;";
        private void Order_Load(object sender, EventArgs e)
        {
            Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection(DB_Server_Info);
            conn.Open();
        }
    }
}
