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
    public partial class Update_Vehicle_Paper_Detail : Form
    {
        public Update_Vehicle_Paper_Detail()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void Edit_Vehicle_Paper_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet11.VEHICLE_PAPER' table. You can move, or remove it, as needed.
            this.vEHICLE_PAPERTableAdapter.Fill(this.transport_Mgmt_SystemDataSet11.VEHICLE_PAPER);
            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Vehicle_ID FROM VEHICLE", con);
            SqlDataReader dr = scd.ExecuteReader();
            while (dr.Read())
            {
                Vehicle_ID.Items.Add(dr[0]);
            }
            con.Close();
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if(Vehicle_ID.Text=="")
            {
                MessageBox.Show(" PLZ_FILL_RECOMMENDED_DATA__!!");

            }
            else
            {
               
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE_PAPER WHERE Vehicle_ID='"+Vehicle_ID.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
              Vehicle_No.Text=dt.Rows[0][1].ToString();
              Insurance_Date.Text=dt.Rows[0][2].ToString();
              PUC_Date.Text=dt.Rows[0][3].ToString();
              Fitness_Date.Text=dt.Rows[0][4].ToString();
              Tax_Date.Text=dt.Rows[0][5].ToString();
          Permit_Date.Text=dt.Rows[0][6].ToString();
          Permit_Type.Text=dt.Rows[0][7].ToString();
          Date.Text=dt.Rows[0][8].ToString();

          con.Close();
          MessageBox.Show("SEARCH_SUCCESSFULLY_!!!");

        
            }
        
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if(Insurance_Date.Text==""||PUC_Date.Text==""||Fitness_Date.Text==""||Tax_Date.Text==""||Permit_Date.Text=="")
            {
                MessageBox.Show(" PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("UPDATE VEHICLE_PAPER SET Insurance_Date='"+Insurance_Date.Text+"',PUC_Date='"+PUC_Date.Text+"',Fitness_Date='"+Fitness_Date.Text+"',Tax_Date='"+Tax_Date.Text+"',Permit_Date='"+Permit_Date.Text+"',Date='"+Date.Text+"' WHERE Vehicle_ID='"+Vehicle_ID.Text+"'",con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();

            Vehicle_ID.Text = "";
            Vehicle_No.Text = "";
            Insurance_Date.Text = "";
            PUC_Date.Text = "";
            Fitness_Date.Text = "";
            Tax_Date.Text = "";
            Permit_Date.Text = "";
            Permit_Type.Text = "";
            Date.Text = "";

            Vehicle_ID.Focus();

            MessageBox.Show("UPDATE_SUCCESSFULLY___!!!");
            }

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Vehicle_ID.Text = "";
            Vehicle_No.Text = "";
            Insurance_Date.Text = "";
            PUC_Date.Text = "";
            Fitness_Date.Text = "";
            Tax_Date.Text = "";
            Permit_Date.Text = "";
            Permit_Type.Text = "";
            Date.Text = "";

            Vehicle_ID.Focus();

            MessageBox.Show("ALL_CLEAR_SUCCESSFULLY___!!!");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE_PAPER", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
