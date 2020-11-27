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
    public partial class Delete_Bill_Payment_Entry : Form
    {
        public Delete_Bill_Payment_Entry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Bill_No.Text == "" || Party_ID.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {

                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM Bill_Payment WHERE Bill_No='" + Bill_No.Text + "' and Party_ID='" + Party_ID.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();

                Bill_No.Text = "";
                Party_ID.Text = "";
                Bill_No.Focus();
          
                MessageBox.Show("DELETE__SUCCESSFULLY__!!!");

            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {


            Bill_No.Text = "";
            Party_ID.Text = "";
            Bill_No.Focus();
            MessageBox.Show("ALL_CLEARED__!!!");

          }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Bill_Payment",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();

            }

        private void Delete_Bill_Payment_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet24.Bill_Payment' table. You can move, or remove it, as needed.
            this.bill_PaymentTableAdapter.Fill(this.transport_Mgmt_SystemDataSet24.Bill_Payment);
            
        
        }

       

        private void Party_ID_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(Bill_No.Text=="")
            {
                MessageBox.Show("PLEASE_FILL_UP_RECOMMENDED_DATA__!!!");
            }
            else
            {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Bill_Payment WHERE Bill_No='" + Bill_No.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Party_ID.Text = dt.Rows[0][1].ToString();
            con.Close();
            }
        }

        private void Party_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
