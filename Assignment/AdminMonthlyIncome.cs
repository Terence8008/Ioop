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
    public partial class AdminMonthlyIncome : Form
    {
        public AdminMonthlyIncome()
        {
            InitializeComponent();
            FillUserList();
        }

        private void AdminMonthlyIncome_Load(object sender, EventArgs e)
        {

        }

        public void FillUserList()
        {

            DB db = new DB();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts WHERE Role IN ('Customer', 'Manager', 'Worker')", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                AdminUserlistBox.Items.Add(dr[1].ToString());
            }
        }

        private void GenerateIncomeBtn_Click(object sender, EventArgs e)
        {
            if (AdminUserlistBox.SelectedItem != null)
            {
                AdminIncomeReportForm incomeForm = new AdminIncomeReportForm();
                incomeForm.UserReportLabelText = AdminUserlistBox.SelectedItem.ToString();
                this.Hide();
                incomeForm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Please choose a user");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdminUserlistBox.SelectedItem.ToString());
        }
    }
}
