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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class WorkerStatusUpdate : Form
    {
        public WorkerStatusUpdate(Request request)
        {
            InitializeComponent();
            label1.Text = request.RequestID.ToString();
        }

        private void WorkerStatusUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string status = listBox1.SelectedItem.ToString();
                string query = "UPDATE Request SET RequestStatues = @status WHERE RequestID = @requestId";

                SqlConnection con = new SqlConnection("Data Source=LIM;Initial Catalog=IOOPAssignment;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@requestId", label1.Text.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an item from the list box");
            }
        }
    }
}
