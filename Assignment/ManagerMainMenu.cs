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
    public partial class ManagerMainMenu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=" +
        "IOOPAssignment;Integrated Security=True");
        int selectedID = 0;
        public ManagerMainMenu()
        {
            InitializeComponent();
        }

        private void Check_Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOPAssignmentDataSet.Request' table. You can move, or remove it, as needed.
            this.iOOPAssignmentDataSet.EnforceConstraints = false;
            this.requestTableAdapter.Fill(this.iOOPAssignmentDataSet.Request);

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            this.selectedID = int.Parse(row.Cells[0].Value.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignWorkerBtn_Click(object sender, EventArgs e)
        {
            Request request = new Request(selectedID);
            ManagerAssignWorker assign_Job = new ManagerAssignWorker(request);
            assign_Job.ShowDialog();
            this.iOOPAssignmentDataSet.EnforceConstraints = false;
            this.requestTableAdapter.Fill(this.iOOPAssignmentDataSet.Request);
        }
    }
}
