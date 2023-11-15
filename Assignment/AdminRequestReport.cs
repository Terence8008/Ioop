using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AdminRequestReport : Form
    {
        public AdminRequestReport()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            string query = "SELECT * FROM Accounts a JOIN Request r ON a.UserID = r.Worker WHERE r.RequestStatues = 'Completed'";

            DB db = new DB();
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            db.OpenConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataGridSQL.DataSource = table;
        }

        private void AdminRequestReport_Load(object sender, EventArgs e)
        {

        }
    }
}
