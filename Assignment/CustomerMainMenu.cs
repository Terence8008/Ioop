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
    public partial class CustomerMainMenu : Form
    {
        public CustomerMainMenu()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'iOOPAssignmentDataSet.Request' table. You can move, or remove it, as needed.
            this.iOOPAssignmentDataSet.EnforceConstraints = false;
            this.requestTableAdapter.Fill(this.iOOPAssignmentDataSet.Request);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitReqBtn_Click(object sender, EventArgs e)
        {
            CustNewRequestForm custNewRequestForm = new CustNewRequestForm();
            custNewRequestForm.ShowDialog();
            this.iOOPAssignmentDataSet.EnforceConstraints = false;
            this.requestTableAdapter.Fill(this.iOOPAssignmentDataSet.Request);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPending customerPending = new CustomerPending();
            customerPending.ShowDialog();
        }
    }
}
