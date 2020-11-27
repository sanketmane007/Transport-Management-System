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
    public partial class Add_Voucher_Entry : Form
    {
        public Add_Voucher_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

       

        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;

        private void Add_Voucher_Entry_Load(object sender, EventArgs e)
        {
           

            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from VOUCHER";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Voucher_ID.Text = "" + count;
            co.Close();


            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Vehicle_ID FROM VEHICLE",con);
            SqlDataReader sdr = scd.ExecuteReader();
            while (sdr.Read())
            {
                Emp_ID.Items.Add(sdr[0]);
            }
            con.Close();

        }

       

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Voucher_ID.Text == "" || Voucher_No.Text == "" || Voucher_Date.Text == "" || Description.Text == "" || Voucher_Name.Text == "" || Amount.Text == "" || Emp_ID.Text == "" || Date.Text == "")
            {
                MessageBox.Show("PLZ_FILL_UP_ALL_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO VOUCHER(Voucher_ID,Voucher_No,Voucher_Date,Description,Voucher_Name,Amount,Emp_ID,Date)VALUES('" + Voucher_ID.Text + "','" + Voucher_No.Text + "','" + Voucher_Date.Text + "','" + Description.Text + "','" + Voucher_Name.Text + "','" + Amount.Text + "','" + Emp_ID.Text + "','" + Date.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Voucher_ID.Text = "";
                Voucher_No.Text = "";
                Voucher_Date.Text = "";
                Description.Text = "";
                Voucher_Name.Text = "";
                Amount.Text = "";
                Emp_ID.Text = "";
                Date.Text = "";

                Voucher_Date.Focus();

                MessageBox.Show("SAVED_sUCCESSFULLY!!!");
                Add_Voucher_Entry ds = new Add_Voucher_Entry();
                this.Dispose(false);
                ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

            //Voucher_ID.Text = "";
            Voucher_No.Text = "";
            Voucher_Date.Text = "";
            Description.Text = "";
            Voucher_Name.Text = "";
            Amount.Text = "";
            Emp_ID.Text = "";
            Date.Text = "";

            Voucher_Date.Focus();

            MessageBox.Show("ALL_CLEARED__");
       
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            Description.MaxLength = 70;
            if (Description.TextLength == 70)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_70_digits__");
            }
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void Voucher_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Voucher_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Voucher_No.MaxLength = 6;
            if (Voucher_No.TextLength == 6)
            {
                MessageBox.Show("Maximum Length is 6 number only__!!!");
            }
            
 
        }
    }
}
