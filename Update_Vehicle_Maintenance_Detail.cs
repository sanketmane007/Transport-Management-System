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
    public partial class Update_Vehicle_Maintenance_Detail : Form
    {
        public Update_Vehicle_Maintenance_Detail()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
       

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (OCD.Text == "" || HGD.Text == "" || EWD.Text == "" || PWD.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Vehicle_Maintenance SET Vehicle_ID='" + Vehicle_ID.Text + "',Vehicle_Number='" + Vehicle_No.Text + "',Oil_Changing_Date='" + OCD.Text + "',Half_Greasing_Date='" + HGD.Text + "',Pump_Work_Date='" + PWD.Text + "',Extra_Work='" + Extra_Work.Text + "',Date='" + Date.Text + "' WHERE Maintenance_ID='" + Maintenance_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("UPADTED_SUCCESSFULLY__!!!");

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


            }

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Maintenance_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehicle_Maintenance WHERE Maintenance_ID='" + Maintenance_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Vehicle_ID.Text = dt.Rows[0][1].ToString();

                Vehicle_No.Text = dt.Rows[0][2].ToString();

                OCD.Text = dt.Rows[0][3].ToString();
                HGD.Text = dt.Rows[0][4].ToString();
                EWD.Text = dt.Rows[0][5].ToString();
                PWD.Text = dt.Rows[0][6].ToString();
                Extra_Work.Text = dt.Rows[0][7].ToString();
                Date.Text = dt.Rows[0][8].ToString();

                con.Close();

                MessageBox.Show("SEARCH_SUCCESSFULLY__!!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("ALL_CLEARED___!!");
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void Update_Vehicle_Maintenance_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet10.Vehicle_Maintenance' table. You can move, or remove it, as needed.
            this.vehicle_MaintenanceTableAdapter.Fill(this.transport_Mgmt_SystemDataSet10.Vehicle_Maintenance);
            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Maintenance_ID FROM Vehicle_Maintenance",con);
            SqlDataReader dr = scd.ExecuteReader();
            while (dr.Read())
            {
                Maintenance_ID.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehicle_Maintenance", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
            
    }
}
