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
    public partial class Update_Vehicle : Form
    {
        public Update_Vehicle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
            
        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Vehicle_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE WHERE Vehicle_ID='" + Vehicle_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Trailer_No.Text = dt.Rows[0][1].ToString();
                Chasis_No.Text = dt.Rows[0][2].ToString();
                Engine_No.Text = dt.Rows[0][3].ToString();
                Model_No.Text = dt.Rows[0][4].ToString();
                Permit_No.Text = dt.Rows[0][5].ToString();
                Driver_Name.Text = dt.Rows[0][6].ToString();
                Conductor_Name.Text = dt.Rows[0][7].ToString();
                Route.Text = dt.Rows[0][8].ToString();
                Date.Text = dt.Rows[0][9].ToString();

                con.Close();
                MessageBox.Show("SEARCH_SUCCESSFULLY!!");

            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Driver_Name.Text == "" || Conductor_Name.Text == "" || Route.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE VEHICLE SET Trailer_No='" + Trailer_No.Text + "',Chasis_No='" + Chasis_No.Text + "',Engine_No='" + Engine_No.Text + "',Model_No='" + Model_No.Text + "',Permit_No='" + Permit_No.Text + "',Driver_Name='" + Driver_Name.Text + "',Conductor_Name='" + Conductor_Name.Text + "',Route='" + Route.Text + "' WHERE Vehicle_ID='" + Vehicle_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();

                con.Close();
                Trailer_No.Text = "";
                Chasis_No.Text = "";
                Engine_No.Text = "";
                Model_No.Text = "";
                Permit_No.Text = "";
                Driver_Name.Text = "";
                Conductor_Name.Text = "";
                Route.Text = "";
                Vehicle_ID.Text = "";
                Vehicle_ID.Focus();
                MessageBox.Show("RECORD UPDATED");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Vehicle_ID.Text = "";
            Trailer_No.Text = "";
            Chasis_No.Text = "";
            Engine_No.Text = "";
            Model_No.Text = "";
            Permit_No.Text = "";
            Driver_Name.Text = "";
            Conductor_Name.Text = "";
            Route.Text = "";

            Vehicle_ID.Focus();

            MessageBox.Show("CLEAR_SUCCESSFULLY__");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet8.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.transport_Mgmt_SystemDataSet8.VEHICLE);
            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Vehicle_ID FROM VEHICLE",con);
            SqlDataReader dr =sc.ExecuteReader();
            while (dr.Read())
            {
                Vehicle_ID.Items.Add(dr[0]);

            }
            con.Close();
        }

        private void Driver_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Driver_Name.MaxLength = 10;
            if (Driver_Name.TextLength ==10)
            {
                MessageBox.Show("THIS_IS_A_HIGH_LIMIT__!!!");
            }
 
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }

        }

        private void Conductor_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conductor_Name.MaxLength = 10;
            if (Conductor_Name.TextLength == 10)
            {
                MessageBox.Show("THIS_IS_A_HIGH_LIMIT__!!!");
            }
 
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }

        }

        private void Route_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conductor_Name.MaxLength = 30;
            if (Conductor_Name.TextLength == 30)
            {
                MessageBox.Show("THIS_IS_A_HIGH_LIMIT__!!!");
            }
 
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        
    }
}
 