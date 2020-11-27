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
    public partial class Delete_Vehicle_Paper_Details : Form
    {
        public Delete_Vehicle_Paper_Details()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Vehicle_ID.Text == "" || Vehicle_No.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {
                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM Vehicle_Paper WHERE Vehicle_ID='" + Vehicle_ID.Text + "' and Vehicle_Number='" + Vehicle_No.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();

                Vehicle_ID.Text = "";
                Vehicle_No.Text = "";
                Vehicle_ID.Focus();

                MessageBox.Show("DATA_DELETED_SUCCESSFULLY___!!!");

            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Vehicle_ID.Text="";
            Vehicle_No.Text="";
            Vehicle_ID.Focus();

            MessageBox.Show("DATA_DELETED_SUCCESSFULLY___!!!");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda=new SqlDataAdapter("SELECT * FROM VEHICLE_PAPER",con);
            DataTable dt=new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource=dt;
            con.Close();

        }

        private void Vehicle_No_MouseClick(object sender, MouseEventArgs e)
        {
            if(Vehicle_No.Text=="")
            {
                MessageBox.Show("PLEASE_FILL_VEHICLE_DATA__!!!");
            }
            else
            {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE_PAPER WHERE Vehicle_ID='" + Vehicle_ID.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vehicle_No.Text = dt.Rows[0][1].ToString();
            con.Close();
            }

        }

        private void Delete_Vehicle_Paper_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet31.VEHICLE_PAPER' table. You can move, or remove it, as needed.
            this.vEHICLE_PAPERTableAdapter.Fill(this.transport_Mgmt_SystemDataSet31.VEHICLE_PAPER);

        }

       
    }
}
