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
    public partial class Delete_Party_Details : Form
    {
        public Delete_Party_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Party_ID.Text == "" || Party_Name.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_RECOMMENDED_DATA_FIRST_!!");
            }
            else
            {


                con.Open();
                SqlCommand scd = new SqlCommand("DELETE FROM PARTY WHERE Party_ID='" + Party_ID.Text + "' and Party_Name='" + Party_Name.Text + "'", con);
                scd.ExecuteNonQuery();
                con.Close();
               Party_ID.Text = "";
                Party_Name.Text = "";
                Party_ID.Focus();

                MessageBox.Show("DATA_DELETED_SUCCESSFULLY__!!");
            }
            }

        private void CLEAR_Click(object sender, EventArgs e)
        {


            Party_ID.Text = "";
            Party_Name.Text = "";
            Party_ID.Focus();

            MessageBox.Show("ALL_DATA_CLEARED__!!");
       

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_VIEW_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PARTY",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        
        
        
        }

       private void Party_Name_MouseClick_1(object sender, MouseEventArgs e)
        {
           if(Party_ID.Text=="")
           {
               MessageBox.Show("PLEASE_FILL_UP_PARTY_ID__!!!");
           }
           else
           {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PARTY WHERE Party_ID='" + Party_ID.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Party_Name.Text = dt.Rows[0][1].ToString();
            con.Close();
           }
        }

       private void Delete_Party_Details_Load(object sender, EventArgs e)
       {
           // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet26.PARTY' table. You can move, or remove it, as needed.
           this.pARTYTableAdapter.Fill(this.transport_Mgmt_SystemDataSet26.PARTY);

       }
    }
}
