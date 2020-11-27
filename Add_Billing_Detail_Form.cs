using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Xml.Linq;



namespace Transport_mgmt
{
    public partial class Add_Billing_Detail_Form : Form
    {
        public Add_Billing_Detail_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Bill_No.Text == "" || Vehicle_ID.Text == "" || Party_ID.Text == "" || DOL.Text == "" || POL.Text == "" || POU.Text == "" || WIM.Text == "" || RPM.Text == "" || Total_Amount.Text == "" || Advance_Amount.Text == "" || Balance_Amount.Text == "" || Bill_Status.Text == "" || Material_Desc.Text == "" || Date.Text == "") 
            {
                MessageBox.Show("PLEASE_FILL_ALL_DATA");
                Bill_No.Focus();
            }
        
            else
            {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Billing_Detail(Bill_No,Vehicle_ID,Party_ID,Date_Of_Loading,Place_Of_Loading,Place_Of_Unloading,Weight_In_Matrictone,Rate_Per_Matrictone,Total_Amount,Advance_Amount,Balance_Amount,Bill_Status,Material_Description,Date)VALUES('" + Bill_No.Text + "','" + Vehicle_ID.Text + "','" + Party_ID.Text + "','" + DOL.Text + "','" + POL.Text + "','" + POU.Text + "','" + WIM.Text + "','" + RPM.Text + "','" + Total_Amount.Text + "','" + Advance_Amount.Text + "','" + Balance_Amount.Text + "','" + Bill_Status.Text + "','" + Material_Desc.Text + "','" + Date.Text + "')", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();

            Bill_No.Text = "";
            Vehicle_ID.Text = "";
            Party_ID.Text = "";
            DOL.Text = "";
            POL.Text = "";
            POU.Text = "";
            WIM.Text = "";
            RPM.Text = "";
            Total_Amount.Text = "";
            Advance_Amount.Text = "";
            Balance_Amount.Text = "";
            Bill_Status.Text = "";
            Material_Desc.Text = "";

            Date.Text = "";

            Bill_No.Focus();

            MessageBox.Show("SAVED SUCCESSFULLY!!!");
            Add_Billing_Detail_Form ds = new Add_Billing_Detail_Form();
            this.Dispose(false);
            ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            //Bill_No.Text = "";
            Vehicle_ID.Text = "";
            Party_ID.Text = "";
            DOL.Text = "";
            POL.Text = "";
            POU.Text = "";
            WIM.Text = "";
            RPM.Text = "";
            Total_Amount.Text = "";
            Advance_Amount.Text = "";
            Balance_Amount.Text = "";
            Date.Text = "";
            Bill_Status.Text = "";
            Material_Desc.Text = "";



            Bill_No.Focus();

            MessageBox.Show("ALL_CLEARED__");
      
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;
        private void Add_Billing_Detail_Form_Load(object sender, EventArgs e)
        {
            SqlConnection co=new SqlConnection(strconstring);
           
            str="select count(*) from Billing_Detail";
            com = new SqlCommand(str,co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar())+ 1;
            Bill_No.Text = ""+count;
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
            SqlDataReader sdr = scd.ExecuteReader();
            while(sdr.Read())
            {
                Party_ID.Items.Add(sdr[0]);
            }
            con.Close();

        }

        private void Balance_Amount_MouseClick(object sender, MouseEventArgs e)
        {
            int a, b;
            a = int.Parse(Total_Amount.Text);
            b = int.Parse(Advance_Amount.Text);
            a = a - b;
                Balance_Amount.Text=a.ToString();

        }

        private void POL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar!= (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }

        }

        private void POU_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void Bill_Status_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void WIM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }

        }

        private void RPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Total_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Advance_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Balance_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }
    }
}
