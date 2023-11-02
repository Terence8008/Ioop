using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=" +
            "IOOPAssignment;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = usernametextbox.Text;
            user_password = passwordtextbox.Text;

            String query = "SELECT * FROM ACCOUNTS WHERE Username = '" + username + "' " +
                "AND PASSWORD = '" + user_password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("Incorrect, Please try again");
            }
        }
    }
}
