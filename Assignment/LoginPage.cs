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
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    public partial class LoginPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=" +
            "IOOPAssignment;Integrated Security=True");
        public static string Username;
        public static string Password;
        public LoginPage()
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
                string roles = (dt.Rows[0][3]).ToString();
                MessageBox.Show(roles);
                MessageBox.Show("Login successful");
                Username = username;
                Password = user_password;
                if (roles == "Customer")
                {
                    CustomerMainMenu customerMainMenu = new CustomerMainMenu();
                    customerMainMenu.ShowDialog();
                }
                else if (roles == "Manager")
                {
                    ManagerMainMenu managerMainMenu = new ManagerMainMenu();
                    managerMainMenu.ShowDialog();

                }
                else if (roles == "Admin")
                {
                    AdminMainMenu adminMainMenu = new AdminMainMenu();
                    adminMainMenu.ShowDialog();

                }
                else if (roles == "Worker")
                {
                    WorkerMainMenu workerMainManu = new WorkerMainMenu();
                    workerMainManu.ShowDialog();
                }
                Username = username;
                Password = user_password;
            }
            else
            {
                MessageBox.Show("Incorrect, Please try again");
            }

           
        }
    }
}
