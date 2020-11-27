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
    public partial class Delete_Voucher_Entry : Form
    {
        public Delete_Voucher_Entry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");


        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Voucher_ID.Text == "" || Voucher_No.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {

                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM VOUCHER WHERE Voucher_ID='" + Voucher_ID.Text + " and Voucher_No='" + Voucher_No.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();

                Voucher_ID.Text = "";
                Voucher_No.Text = "";
                Voucher_ID.Focus();
                MessageBox.Show("DATA_DELETED_SUCCESSFULLY___!!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Voucher_ID.Text = "";
            Voucher_No.Text = "";
            Voucher_ID.Focus();
            MessageBox.Show("ALL_CLEARED___!!!");
     
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VOUCHER",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Delete_Voucher_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet32.VOUCHER' table. You can move, or remove it, as needed.
            this.vOUCHERTableAdapter.Fill(this.transport_Mgmt_SystemDataSet32.VOUCHER);

        }

        private void Voucher_No_MouseClick(object sender, MouseEventArgs e)
        {
            if (Voucher_No.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_VOUCHER_ID__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VOUCHER WHERE Voucher_ID='" + Voucher_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Voucher_No.Text = dt.Rows[0][1].ToString();
                con.Close();



            }
        }
    }
}
