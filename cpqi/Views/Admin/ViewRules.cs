using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace cpqi.Views.Admin
{
    public partial class ViewRules : Form
    {
        public ViewRules()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connect = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CpqiDB;Integrated Security=True;Trust Server Certificate=True";
            string query = "SELECT * FROM Role";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_Rules.DataSource = table;
            }
        }
    }
}
