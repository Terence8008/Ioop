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
    public partial class ManagerAssignWorker : Form
    {
        public ManagerAssignWorker(Request request)
        {
            InitializeComponent();
            label2.Text = request.RequestID.ToString();
        }

        private void ManagerAssignWorker_Job_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string worker = comboBox1.SelectedItem.ToString();

                string query = "Update Request Set Worker = @Worker Where RequestID = @requestID";

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-L8IN6KR;Initial Catalog=Assignment;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Worker", worker);
                cmd.Parameters.AddWithValue("@requestID", label1.Text.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
