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
    public partial class Delete_Biling_Detail_Form : Form
    {
        public Delete_Biling_Detail_Form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Biling_Detail_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet23.Billing_Detail' table. You can move, or remove it, as needed.
            this.billing_DetailTableAdapter.Fill(this.transport_Mgmt_SystemDataSet23.Billing_Detail);
           
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Bill_No.Text == "" || Vehicle_ID.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {
                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM Billing_Detail WHERE Bill_No='" + Bill_No.Text + "' and Vehicle_ID='" + Vehicle_ID.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();

                Bill_No.Focus();

                Bill_No.Text = "";
                Vehicle_ID.Text ="";

                MessageBox.Show("DATA_DELETED_SUCCESSFULLY__!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

            Bill_No.Text = "";
            Vehicle_ID.Text = "";

            Bill_No.Focus();

            MessageBox.Show("ALL_CLEARED__!!");
        

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Billing_Detail",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
                con.Close();

   }

       

        private void Vehicle_ID_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (Bill_No.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Billing_Detail WHERE Bill_No='" + Bill_No.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Vehicle_ID.Text = dt.Rows[0][1].ToString();
                con.Close();
            }
           }
    }
}
