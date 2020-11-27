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
    public partial class Update_Vehicle_Daily_Entry : Form
    {
        public Update_Vehicle_Daily_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con=new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Entry_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehicle_Daily_Entry WHERE Entry_ID='" + Entry_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Vehicle_ID.Text = dt.Rows[0][1].ToString();
                Challan_No.Text = dt.Rows[0][2].ToString();
                Container_No.Text = dt.Rows[0][3].ToString();
                Party_ID.Text = dt.Rows[0][4].ToString();
                Route.Text = dt.Rows[0][5].ToString();
                Date.Text = dt.Rows[0][6].ToString();

                Start_Place.Text = dt.Rows[0][7].ToString();

                End_Place.Text = dt.Rows[0][8].ToString();
                Total.Text = dt.Rows[0][9].ToString();
                Advance_Pay.Text = dt.Rows[0][10].ToString();
                Balance.Text = dt.Rows[0][11].ToString();

                con.Close();

                MessageBox.Show("SEARCH_SUCCESSFULLY!!!");

            }
        }

        private void Update_Vehicle_Daily_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet9.Vehicle_Daily_Entry' table. You can move, or remove it, as needed.
            this.vehicle_Daily_EntryTableAdapter.Fill(this.transport_Mgmt_SystemDataSet9.Vehicle_Daily_Entry);

            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Entry_ID FROM Vehicle_Daily_Entry",con);
            SqlDataReader dr = sc.ExecuteReader();

            while(dr.Read())
            {
                Entry_ID.Items.Add(dr[0]);
            }
            con.Close();

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Total.Text == "" || Advance_Pay.Text == "" || Balance.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Vehicle_Daily_Entry SET Vehicle_ID='" + Vehicle_ID.Text + "',Challan_No='" + Challan_No.Text + "',Container_No='" + Container_No.Text + "',Party_ID='" + Party_ID.Text + "',Route='" + Route.Text + "',Date='" + Date.Text + "',Starting_Place='" + Start_Place.Text + "',Ending_Place='" + End_Place.Text + "',Total='" + Total.Text + "',Advance_Pay='" + Advance_Pay.Text + "',Balance='" + Balance.Text + "' WHERE Entry_ID='" + Entry_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Entry_ID.Text = "";
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

                MessageBox.Show("DATA_UPDATED_SUCCESSFULLY___!!!");
            }
        }

        private void Balance_MouseClick(object sender, MouseEventArgs e)
        {

            int a, b;
            a = int.Parse(Total.Text);
            b = int.Parse(Advance_Pay.Text);
            a = a - b;
            Balance.Text = a.ToString();
       
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Entry_ID.Text = "";
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

            MessageBox.Show("ALL_CLEARED___!!!");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehicle_Daily_Entry", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

       
        
    }
}
