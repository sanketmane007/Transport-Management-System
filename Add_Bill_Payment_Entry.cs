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
    public partial class Add_Bill_Payment_Entry : Form
    {
        public Add_Bill_Payment_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
       

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Bill_No.Text== "" || Party_ID.Text == "" || AOC.Text == ""|| Ac_No.Text == "" || Ch_No.Text== "" ||DOW.Text== "" ||Bank_Name.Text== "")
            {
                MessageBox.Show("PLEASE_FILLUP _ALL_DATA!!!");
                Bill_No.Focus();
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Bill_Payment(Bill_No,Party_ID,Amount_Of_Check,Account_No,Check_No,Date_Of_Withdrawn,Bank_Name,Date)VALUES('" + Bill_No.Text + "','" + Party_ID.Text + "','" + AOC.Text + "','" + Ac_No.Text + "','" + Ch_No.Text + "','" + DOW.Text + "','" + Bank_Name.Text + "','" + Date.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Bill_No.Text = "";
                Party_ID.Text = "";
                AOC.Text = "";
                Ac_No.Text = "";
                Ch_No.Text = "";
                DOW.Text = "";
                Bank_Name.Text = "";
                Date.Text = "";

                Bill_No.Focus();

                MessageBox.Show("SAVED_SUCCESSFULLY");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Bill_No.Text = "";
            Party_ID.Text = "";
            AOC.Text = "";
            Ac_No.Text = "";
            Ch_No.Text = "";
            DOW.Text = "";
            Bank_Name.Text = "";
            Date.Text = "";

            Bill_No.Focus();

            MessageBox.Show("ALL_CLEARED!__");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Bill_Payment_Entry_Load(object sender, EventArgs e)
        {
            

            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Bill_No FROM Billing_Detail", con);
            SqlDataReader dr =sc.ExecuteReader();
            while (dr.Read())
            {
                Bill_No.Items.Add(dr[0]);
            }
            con.Close();

            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Party_ID FROM PARTY",con);
            SqlDataReader sdr = scd.ExecuteReader();
            while (sdr.Read())
            {
                Party_ID.Items.Add(sdr[0]);
            }
            con.Close();


        }

        private void AOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Ch_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ch_No.MaxLength = 7;
            if (Ch_No.TextLength == 7)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 7 NUMBERS__");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Ch_No_Leave(object sender, EventArgs e)
        {
            if (Ch_No.TextLength < 7)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }
    }
}
