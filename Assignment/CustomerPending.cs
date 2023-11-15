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
    public partial class CustomerPending : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=" +
            "IOOPAssignment;Integrated Security=True");
        public CustomerPending()
        {
            InitializeComponent();
        }

        private void CustomerPending_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Request where Requester = '" + LoginPage.Username + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
