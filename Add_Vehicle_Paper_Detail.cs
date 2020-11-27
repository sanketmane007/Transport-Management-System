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
    public partial class Add_Vehicle_Paper_Detail : Form
    {
        public Add_Vehicle_Paper_Detail()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

       

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Vehicle_ID.Text == "" || Vehicle_No.Text == "" || Insurance_Date.Text == "" || PUC_Date.Text == "" || Fitness_Date.Text == "" || Tax_Date.Text == "" || Permit_Date.Text == "" || Permit_Type.Text == "" || Date.Text == "")
            {
                MessageBox.Show("PLZ FILL_UP_ALL_DATA__!!");
            }
            else
            {


                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO VEHICLE_PAPER(Vehicle_ID,Vehicle_Number,Insurance_Date,PUC_Date,Fitness_Date,Tax_Date,Permit_Date,Permit_Type,Date)VALUES('" + Vehicle_ID.Text + "','" + Vehicle_No.Text + "','" + Insurance_Date.Text + "','" + PUC_Date.Text + "','" + Fitness_Date.Text + "','" + Tax_Date.Text + "','" + Permit_Date.Text + "','" + Permit_Type.Text + "','" + Date.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Vehicle_ID.Text = "";
                Vehicle_No.Text = "";
                Insurance_Date.Text = "";
                PUC_Date.Text = "";
                Fitness_Date.Text = "";
                Tax_Date.Text = "";
                Permit_Type.Text = "";
                Permit_Type.Text = "";
                Date.Text = "";

                Vehicle_ID.Focus();
                MessageBox.Show("SAVED_SUCCESSFULLY!!!");
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
            Permit_Type.Text = "";
            Permit_Type.Text = "";
            Date.Text = "";

            Vehicle_ID.Focus();

            MessageBox.Show("ALL_CLEARED__");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Vehicle_Paper_Detail_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scd = new SqlCommand("SELECT Vehicle_ID FROM VEHICLE",con);
            SqlDataReader sdr = scd.ExecuteReader();
            while (sdr.Read())
            {
                Vehicle_ID.Items.Add(sdr[0]);
            }
            con.Close();

        }

        private void Vehicle_No_MouseClick(object sender, MouseEventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VEHICLE WHERE Vehicle_ID='" + Vehicle_ID.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vehicle_No.Text = dt.Rows[0][1].ToString();
            con.Close();
       


        }

        private void Permit_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            Permit_Type.MaxLength = 25;
            if (Permit_Type.TextLength == 25)
            {
                MessageBox.Show("THIS IS A HIGH LIMIT__!!!");
            }

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
}
