using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CustNewRequestForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=IOOPAssignment;Integrated Security=True");
        public string Servicetype;
        
        public CustNewRequestForm()
        {
            InitializeComponent();
        }

        private void CustNewRequestForm_Load(object sender, EventArgs e)
        {
            NewReqBtn.Visible = false;
            listBox1.SelectedIndex = 1;
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double totalCost;
            double ServiceCost = 0;
            double Quantity;
            double Subcharged =  1;
            
            if (listBox1.SelectedItem.ToString() == "A4 - BW")
            {
                ServiceCost = 0.8;
            }
            else if(listBox1.SelectedItem.ToString() == "A4 - Color")
            {
                ServiceCost = 2.5;
            }
            else if (listBox1.SelectedItem.ToString() == "Binding - CB")
            {
                ServiceCost = 5.0;
            }
            else if (listBox1.SelectedItem.ToString() == "Binding - TC")
            {
                ServiceCost = 15.0;
            }
            else if (listBox1.SelectedItem.ToString() == "Poster")
            {
                ServiceCost = 3.0;
            }
            else if (listBox1.SelectedItem.ToString() == "Banner")
            {
                ServiceCost = 10.0;
            }

            if (checkBox1.Checked)
            {
                Subcharged = 1.3;
            }
            Quantity = double.Parse(TextBox1.Text);
            totalCost = ServiceCost * Quantity * Subcharged;
            CostLbl.Text = totalCost.ToString();
            NewReqBtn.Visible = true;

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewReqBtn_Click(object sender, EventArgs e)
        {
            int urgent = 0;
            int Quantity = int.Parse(TextBox1.Text);
            int ServiceType = 0;
            if (checkBox1.Checked)
            {
                urgent = 1;
            }

            if (listBox1.SelectedItem.ToString() == "A4 - BW")
            {
                ServiceType = 1;
            }
            else if (listBox1.SelectedItem.ToString() == "A4 - Color")
            {
                ServiceType = 2;
            }
            else if (listBox1.SelectedItem.ToString() == "Binding - CB")
            {
                ServiceType = 3;
            }
            else if (listBox1.SelectedItem.ToString() == "Binding - TC")
            {
                ServiceType = 4;
            }
            else if (listBox1.SelectedItem.ToString() == "Poster")
            {
                ServiceType = 5;
            }
            else if (listBox1.SelectedItem.ToString() == "Banner")
            {
                ServiceType = 6;
            }


            SqlConnection conn = new SqlConnection("Data Source=LIM;Initial Catalog=IOOPAssignment;Integrated Security=True");
            string query = "Insert into [dbo].[Request] values (@ServiceID, @Name, @Statues, @Urgent, @Quantity, @Worker) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ServiceID", ServiceType);
            cmd.Parameters.AddWithValue("@Name",  LoginPage.Username);
            cmd.Parameters.AddWithValue("@Statues", "New");
            cmd.Parameters.AddWithValue("@Urgent", urgent);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Worker", DBNull.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Request added");
            this.Close();
        }
    }
}
