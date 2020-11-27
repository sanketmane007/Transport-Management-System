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
    public partial class Delete_Vehicle_Daily_Entry : Form
    {
        public Delete_Vehicle_Daily_Entry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Entry_ID.Text == "" || Vehicle_ID.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {

                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM Vehicle_Daily_Entry WHERE Entry_ID='" + Entry_ID.Text + "' and Vehicle_ID='" + Vehicle_ID.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();
                 Entry_ID.Text = "";
                Vehicle_ID.Text = "";
                Entry_ID.Focus();

                MessageBox.Show("DATA_DELETED_SUCCESSFULLY__!!!");
            }
            }

        private void CLEAR_Click(object sender, EventArgs e)
        {

            Entry_ID.Text = "";
            Vehicle_ID.Text = "";
            Entry_ID.Focus();

            MessageBox.Show("ALL_CLEARED__!!!");
     
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehicle_Daily_Entry",con);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

       private void Vehicle_ID_MouseClick_1(object sender, MouseEventArgs e)
        {
           if(Vehicle_ID.Text=="")
           {
               MessageBox.Show("PLEASE_FILL_ENTRY_ID__!!!");
           }
           else
           {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehicle_Daily_Entry WHERE Entry_ID='" + Entry_ID.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vehicle_ID.Text = dt.Rows[0][1].ToString();
            con.Close();
           }
        }

        private void Delete_Vehicle_Daily_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet28.Vehicle_Daily_Entry' table. You can move, or remove it, as needed.
            this.vehicle_Daily_EntryTableAdapter.Fill(this.transport_Mgmt_SystemDataSet28.Vehicle_Daily_Entry);

        }
    }
}
