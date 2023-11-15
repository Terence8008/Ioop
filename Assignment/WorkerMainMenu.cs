using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{

    public partial class WorkerMainMenu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=" +
         "IOOPAssignment;Integrated Security=True");
        int selectedID = 0;
        public WorkerMainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Request where WorkerName = '" + LoginPage.Username + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            if (selectedID != 0)
            {
                Request request = new Request(selectedID);

                WorkerStatusUpdate workerStatusUpdate = new WorkerStatusUpdate(request);
                workerStatusUpdate.ShowDialog();
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a request first");
            }
        }

        public void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            this.selectedID = int.Parse(row.Cells[0].Value.ToString());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
