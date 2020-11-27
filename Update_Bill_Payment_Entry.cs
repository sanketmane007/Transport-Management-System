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
    public partial class Update_Bill_Payment_Entry : Form
    {
        public Update_Bill_Payment_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

       
        private void Update_Bill_Payment_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet4.Bill_Payment' table. You can move, or remove it, as needed.
            this.bill_PaymentTableAdapter.Fill(this.transport_Mgmt_SystemDataSet4.Bill_Payment);

            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Bill_No from Bill_Payment",con);
            SqlDataReader dr = scd.ExecuteReader();
            while (dr.Read())
            {
                Bill_No.Items.Add(dr[0]);
            }
            con.Close();
        }

       

       

       

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Bill_No.Text == "")
            {
                MessageBox.Show("PLZ_FILL_THE_RECOMMENDED_DATA___!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Bill_Payment Where Bill_No='" + Bill_No.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Party_ID.Text = dt.Rows[0][1].ToString();
                AOC.Text = dt.Rows[0][2].ToString();
                Ac_No.Text = dt.Rows[0][3].ToString();
                Ch_NO.Text = dt.Rows[0][4].ToString();
                DOW.Text = dt.Rows[0][5].ToString();
                Bank_Name.Text = dt.Rows[0][6].ToString();
                Date.Text = dt.Rows[0][7].ToString();

                con.Close();
                MessageBox.Show("SEARCH_SUCCESSFULLY!!");
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (AOC.Text == "" || Ch_NO.Text == "")
            {
                MessageBox.Show("PLEASE_ENTER_RECOMMENDED_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Bill_Payment SET Amount_Of_Check='" + AOC.Text + "',Check_No='" + Ch_NO.Text + "' WHERE Bill_No='" + Bill_No.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                Bill_No.Text = "";
                Party_ID.Text = "";
                AOC.Text = "";
                Ac_No.Text = "";
                Ch_NO.Text = "";
                DOW.Text = "";
                Bank_Name.Text = "";
                Date.Text = "";
                Bill_No.Focus();         
                MessageBox.Show("Data_Updated!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Bill_No.Text = "";
            Party_ID.Text = "";
            AOC.Text = "";
            Ac_No.Text = "";
            Ch_NO.Text = "";
            DOW.Text = "";
            Bank_Name.Text = "";
            Date.Text = "";
            Bill_No.Focus();
            MessageBox.Show("ALL_CLEARED--!!!");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Ch_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ch_NO.MaxLength = 9;
            if (Ch_NO.TextLength == 9)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Bill_Payment", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
