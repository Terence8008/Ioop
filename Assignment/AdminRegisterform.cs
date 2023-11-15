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
    public partial class AdminRegisterform : Form
    {
        public AdminRegisterform()
        {
            InitializeComponent();
        }

        private void AdminRegisterform_Load(object sender, EventArgs e)
        {

        }
        public Boolean IsUserExists()
        {
            DB dB = new DB();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts WHERE 'username' = @username", dB.GetConnection());
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = NameField.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Enter your name..." || NameField.Text == "")
                return;
            DB db = new DB();
            SqlCommand cmd = new SqlCommand("INSERT INTO Accounts (Username, Password, Role) VALUES (@username, @password, @role)", db.GetConnection());
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = NameField.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordField.Text;
            cmd.Parameters.Add("@role", SqlDbType.VarChar).Value = UserTypeBox.SelectedItem.ToString();

            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Account registered");
            else
                MessageBox.Show("Account haven't registered");
            db.CloseConnection();

            if (IsUserExists())
                return;
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Enter your name...")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Enter your name...";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void UserTypeBox_Leave(object sender, EventArgs e)
        {

        }

        private void UserTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserTypeBox_Enter(object sender, EventArgs e)
        {

        }

        private void UserTypeBox_MouseEnter(object sender, EventArgs e)
        {
            UserTypeBox.Height = 100;
        }

        private void UserTypeBox_MouseLeave(object sender, EventArgs e)
        {
            UserTypeBox.Height = 33;
        }
    }

}
