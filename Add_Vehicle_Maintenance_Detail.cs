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
    public partial class Add_Vehicle_Maintenance_Detail : Form
    {
        public Add_Vehicle_Maintenance_Detail()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");


        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;


        private void Add_Vehicle_Maintenance_Detail_Load(object sender, EventArgs e)
        {

           

            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from Vehicle_Maintenance";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Maintenance_ID.Text = "" + count;
            co.Close(); 
            
           
            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Vehicle_ID FROM VEHICLE", con);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read()) 
            {
                Vehicle_ID.Items.Add(dr[0]);
            }
            con.Close();
        }
 

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Maintenance_ID.Text == "" || Vehicle_ID.Text == "" || Vehicle_No.Text == "" || OCD.Text == "" || HGD.Text == "" || EWD.Text == "" || PWD.Text == "" || Extra_Work.Text == "" || Date.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_UP_ALL_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Vehicle_Maintenance(Maintenance_ID,Vehicle_ID,Vehicle_Number,Oil_Changing_Date,Half_Greasing_Date,Engine_Work_Date,Pump_Work_Date,Extra_Work,date)VALUES('" + Maintenance_ID.Text + "','" + Vehicle_ID.Text + "','" + Vehicle_No.Text + "','" + OCD.Text + "','" + HGD.Text + "','" + EWD.Text + "','" + PWD.Text + "','" + Extra_Work.Text + "','" + Date.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Maintenance_ID.Text = "";
                Vehicle_ID.Text = "";
                Vehicle_No.Text = "";
                OCD.Text = "";
                HGD.Text = "";
                EWD.Text = "";
                PWD.Text = "";
                Extra_Work.Text = "";
                Date.Text = "";

                Maintenance_ID.Focus();

                MessageBox.Show("SAVED_SUCCESSFULLY!!!");
                Add_Vehicle_Maintenance_Detail ds = new Add_Vehicle_Maintenance_Detail();
                this.Dispose(false);
                ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            //Maintenance_ID.Text = "";
            Vehicle_ID.Text = "";
            Vehicle_No.Text = "";
            OCD.Text = "";
            HGD.Text = "";
            EWD.Text = "";
            PWD.Text = "";
            Extra_Work.Text = "";
            Date.Text = "";

            Maintenance_ID.Focus();

            MessageBox.Show("ALL_CLEARED__");
      
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vehicle_No_MouseClick(object sender, MouseEventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE WHERE Vehicle_ID='"+Vehicle_ID.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vehicle_No.Text=dt.Rows[0][1].ToString();
            con.Close();
        }

        private void Vehicle_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vehicle_No.MaxLength = 9;
            if (Vehicle_No.TextLength == 9)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_9_digits__");
            }
        }

        private void Vehicle_No_Leave(object sender, EventArgs e)
        {
            if (Vehicle_No.TextLength < 9)
            {
                MessageBox.Show("PLZ_FILL_UP_Correctly__!!!");
            }
        }

        private void Extra_Work_KeyPress(object sender, KeyPressEventArgs e)
        {

            Vehicle_No.MaxLength = 70;
            if (Vehicle_No.TextLength == 70)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_70_digits__");
            }
        }

        }
}
