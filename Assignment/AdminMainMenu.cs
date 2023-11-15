using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void Register_form_btn_Click(object sender, EventArgs e)
        {
            AdminRegisterform regForm = new AdminRegisterform();
            this.Hide();
            regForm.ShowDialog();
            this.Close();
        }

        private void Request_form_btn_Click(object sender, EventArgs e)
        {
            AdminMonthlyIncome incomeForm = new AdminMonthlyIncome();
            this.Hide();
            incomeForm.ShowDialog();
            this.Close();
        }

        private void Income_form_btn_Click(object sender, EventArgs e)
        {
            AdminRequestReport requestForm = new AdminRequestReport();
            this.Hide();
            requestForm.ShowDialog();
            this.Close();
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
