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
    public partial class Delete_Salary_Details : Form
    {
        public Delete_Salary_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Salary_ID.Text == "" || Emp_ID.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {

                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM SALARY WHERE Salary_ID='" + Salary_ID.Text + "' and Emp_ID='" + Emp_ID.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();

                Salary_ID.Text = "";
                Emp_ID.Text = "";
                Salary_ID.Focus();
                MessageBox.Show("ALL__CLEARED__!!!");
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SALARY",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        
        
        }

        private void Delete_Salary_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet27.SALARY' table. You can move, or remove it, as needed.
            this.sALARYTableAdapter.Fill(this.transport_Mgmt_SystemDataSet27.SALARY);



        }

       
        private void Emp_ID_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(Emp_ID.Text=="")
            {
                MessageBox.Show("PLEASE_FILL_UP_SALARY_ID");
            }
            else
            {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SALARY WHERE Salary_ID='" + Salary_ID.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Emp_ID.Text = dt.Rows[0][1].ToString();
            con.Close();
            }
        }
    }
}
