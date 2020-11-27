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
    public partial class Update_Voucher_Entry : Form
    {
        public Update_Voucher_Entry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void Update_Voucher_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet12.VOUCHER' table. You can move, or remove it, as needed.
            this.vOUCHERTableAdapter.Fill(this.transport_Mgmt_SystemDataSet12.VOUCHER);
            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Voucher_ID FROM VOUCHER", con);
            SqlDataReader dr = scd.ExecuteReader();
            while (dr.Read())
            {
                Voucher_ID.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Voucher_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VOUCHER WHERE Voucher_ID='" + Voucher_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Voucher_No.Text = dt.Rows[0][1].ToString();
                Voucher_Date.Text = dt.Rows[0][2].ToString();
                Description.Text = dt.Rows[0][3].ToString();
                Voucher_Name.Text = dt.Rows[0][4].ToString();
                Amount.Text = dt.Rows[0][5].ToString();
                Emp_ID.Text = dt.Rows[0][6].ToString();
                Date.Text = dt.Rows[0][7].ToString();

                con.Close();
                MessageBox.Show("SEARCH_SUCCESSFULLY___!!!");
            }
        }


        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Voucher_Date.Text == "" || Description.Text == "" || Amount.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE VOUCHER SET Voucher_Date='" + Voucher_Date.Text + "',Description='" + Description.Text + "',Amount='" + Amount.Text + "',Date='" + Date.Text + "' WHERE Voucher_ID='" + Voucher_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Voucher_ID.Text = "";
                Voucher_No.Text = "";
                Description.Text = "";

                Voucher_Name.Text = "";
                Amount.Text = "";
                Emp_ID.Text = "";
                Date.Text = "";

                Voucher_ID.Focus();

                MessageBox.Show("UPDATED_SUCCESSFULLY__!!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Voucher_ID.Text = "";
            Voucher_No.Text = "";
            Description.Text = "";

            Voucher_Name.Text = "";
            Amount.Text = "";
            Emp_ID.Text = "";
            Date.Text = "";

            Voucher_ID.Focus();

            MessageBox.Show("ALL_CLEARED__!!!");
       
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VOUCHER", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            Description.MaxLength = 70;
            if (Description.TextLength == 70)
            {
                MessageBox.Show("THIS_IS_A_HIGH_LIMIT__!!!");
            }
        }

       
    }
}
