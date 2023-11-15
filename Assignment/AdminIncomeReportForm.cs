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
    public partial class AdminIncomeReportForm : Form
    {
        public AdminIncomeReportForm()
        {
            InitializeComponent();
            DataGridViewFill();

        }

        private void AdminIncomeReportForm_Load(object sender, EventArgs e)
        {

        }
        public string UserReportLabelText
        {
            get { return UserReportLbl.Text; }
            set { UserReportLbl.Text = value; }
        }
        public int GetUserIDByName(string username)
        {
            int userID = 0;
            DB db = new DB();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM Accounts WHERE UserName = @username", db.GetConnection());
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                userID = (int)dt.Rows[0][0];
            }

            return userID;
        }

        public void DataGridViewFill()
        {
            string new_name = UserReportLbl.Text;
            int userID = GetUserIDByName(new_name);

            string query = @"SELECT a.Username, s.ServicePrice, r.RequestQuantity, (s.ServicePrice * r.RequestQuantity) as Total FROM Accounts a 
                 JOIN Request r ON r.Worker = @userID AND a.UserID = @userID 
                 JOIN ServiceType s ON r.ServiceID = s.ServiceID 
                 WHERE r.RequestStatues = 'Completed'";

            DB db = new DB();
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@userID", userID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataGridSQL.DataSource = table;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string new_name = UserReportLbl.Text;
            int userID = GetUserIDByName(new_name);
            MessageBox.Show(userID.ToString());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
