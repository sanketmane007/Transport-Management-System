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
    public partial class Add_Vehicle_Daily_Entry : Form
    {
        public Add_Vehicle_Daily_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");



        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;

        private void Add_Trip_Load(object sender, EventArgs e)
        {

            Entry_ID.Text = DateTime.Now.ToString("dd/mm/yyyy");


            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from Vehicle_Daily_Entry";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Entry_ID.Text = "" + count;
            co.Close();
       



            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Vehicle_ID FROM VEHICLE",con);
            SqlDataReader dr = sc.ExecuteReader();
            while(dr.Read())
            {
                Vehicle_ID.Items.Add(dr[0]);
            }
            con.Close();


            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Party_ID FROM PARTY",con);
            SqlDataReader sdr = sc.ExecuteReader();
            while (sdr.Read())
            {
                Party_ID.Items.Add(sdr[0]);
            }
            con.Close();
        }

       
        

        
       
        private void Add_Vehicle_Daily_Entry_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Balance_MouseClick(object sender, MouseEventArgs e)
        {

            int a, b;
            a = int.Parse(Total.Text);
            b = int.Parse(Advance_Pay.Text);
            a = a - b;
            Balance.Text = a.ToString();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Entry_ID.Text == "" || Vehicle_ID.Text == "" || Challan_No.Text == "" || Container_No.Text == "" || Party_ID.Text == "" || Route.Text == "" || Date.Text == "" || Start_Place.Text == "" || End_Place.Text == "" || Total.Text == "" || Advance_Pay.Text == "" || Balance.Text == "")
            {
                MessageBox.Show("PLZ_FILL_ALL_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Vehicle_Daily_Entry (Entry_ID,Vehicle_ID,Challan_No,Container_No,Party_ID,Route,Date,Starting_Place,Ending_Place,Total,Advance_Pay,Balance)VALUES('" + Entry_ID.Text + "','" + Vehicle_ID.Text + "','" + Challan_No.Text + "','" + Container_No.Text + "','" + Party_ID.Text + "','" + Route.Text + "','" + Date.Text + "','" + Start_Place.Text + "','" + End_Place.Text + "','" + Total.Text + "','" + Advance_Pay.Text + "','" + Balance.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Entry_ID.Text = "";
                Vehicle_ID.Text = "";
                Challan_No.Text = "";
                Container_No.Text = "";
                Route.Text = "";
                Party_ID.Text = "";
                Date.Text = "";

                Start_Place.Text = "";

                End_Place.Text = "";
                Total.Text = "";
                Advance_Pay.Text = "";
                Balance.Text = "";

                Entry_ID.Focus();

                MessageBox.Show("SAVED_SUCCESSFULLY!!!!");

                Add_Vehicle_Daily_Entry ds = new Add_Vehicle_Daily_Entry();
                this.Dispose(false);
                ds.Show();


            
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            //Entry_ID.Text = "";
            Vehicle_ID.Text = "";
            Challan_No.Text = "";
            Container_No.Text = "";
            Party_ID.Text = "";
            Route.Text = "";
            Date.Text = "";
            
            Start_Place.Text = "";
            
            End_Place.Text = "";
            Total.Text = "";
            Advance_Pay.Text = "";
            Balance.Text = "";

            Entry_ID.Focus();

            MessageBox.Show("ALL_CLEARED__");
       
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void Start_Place_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void End_Place_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void Total_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

      
        private void Advance_Pay_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

       
        private void Balance_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Challan_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Challan_No.MaxLength = 10;
            if (Challan_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
 
        }

        private void Challan_No_Leave(object sender, EventArgs e)
        {
            if (Challan_No.TextLength < 4)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Container_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Container_No.MaxLength = 4;
            if (Container_No.TextLength == 4)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_4_NUMBERS__");
            }
        }

        private void Container_No_Leave(object sender, EventArgs e)
        {
            if (Container_No.TextLength < 4)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Route_KeyPress(object sender, KeyPressEventArgs e)
        {
            Container_No.MaxLength = 35;
            if (Container_No.TextLength == 35)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_35_NUMBERS__");
            }

        }

       

       
    }
}
