using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Transport_mgmt
{
    public partial class Delete_Employees_Details : Form
    {
        public Delete_Employees_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Status.Text == "" || Emp_ID.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {
                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM Employees WHERE Status='" + Status.Text + "' and Emp_ID='" + Emp_ID.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();

                Status.Text = "";
                Emp_ID.Text = "";

                Emp_ID.Focus();


                MessageBox.Show("DATA_DELETED_SUCCESSFULLY___!!!");


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

            Status.Text = "";
            Emp_ID.Text = "";

            Emp_ID.Focus();

            MessageBox.Show("ALL_DATA_CLEARED__!!!");
          
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employees",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void Delete_Employees_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet25.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.transport_Mgmt_SystemDataSet25.Employees);

        }

        private void Emp_ID_MouseClick(object sender, MouseEventArgs e)
        {
            if(Status.Text=="")
            {
                MessageBox.Show("PLEASE_FILL_UP_STATUS__!!");
            }
            
        }

       

       
    }
}