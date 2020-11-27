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
    public partial class Add_Vehicle_Details : Form
    {
        public Add_Vehicle_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        
        
       
       
       
        
        
       
        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Vehicle_ID.Text == "" || Trailer_No.Text == "" || Chasis_No.Text == "" || Engine_No.Text == "" || Model_No.Text == "" || Permit_No.Text == "" || Driver_Name.Text == "" || Conductor_Name.Text == "" || Route.Text == "")
            {
                MessageBox.Show("PLEASE_FILLALL_DATA__!!!");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO VEHICLE (Vehicle_ID,Trailer_No,Chasis_No,Engine_No,Model_No,Permit_No,Driver_Name,Conductor_Name,Route,Date)VALUES('" + Vehicle_ID.Text + "','" + Trailer_No.Text + "','" + Chasis_No.Text + "','" + Engine_No.Text + "','" + Model_No.Text + "','" + Permit_No.Text + "','" + Driver_Name.Text + "','" + Conductor_Name.Text + "','" + Route.Text + "','" + Date.Text + "')", con);
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
                Date.Text = "";


                Vehicle_ID.Focus();
                MessageBox.Show("SAVE SUCCESSFULLY-!!!!");

               Add_Vehicle_Details ds = new Add_Vehicle_Details();
                this.Dispose(false);
                ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            //Vehicle_ID.Text = "";
            Trailer_No.Text = "";
            Chasis_No.Text = "";
            Engine_No.Text = "";
            Model_No.Text = "";
            Permit_No.Text = "";
            Driver_Name.Text = "";
            Conductor_Name.Text = "";
            Route.Text = "";
            Date.Text = "";

            Vehicle_ID.Focus();

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

        private void Add_Vehicle_Details_Load(object sender, EventArgs e)
        {

            Vehicle_ID.Text = DateTime.Now.ToString("dd/mm/yyyy");


            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from VEHICLE";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Vehicle_ID.Text = "" + count;
            co.Close();
    
        }

        private void Driver_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void Trailer_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Trailer_No.MaxLength = 9;
            if (Trailer_No.TextLength == 9)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_9_digits__");
            }
        }

        private void Trailer_No_Leave(object sender, EventArgs e)
        {
            if (Trailer_No.TextLength < 9)
            {
                MessageBox.Show("PLZ_FILL_UP_Correctly__!!!");
            }
        }

        private void Chasis_No_Leave(object sender, EventArgs e)
        {
            if (Chasis_No.TextLength <6)
            {
                MessageBox.Show("PLZ_FILL_UP_Correctly__!!!");
            }
        }

        private void Chasis_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Chasis_No.MaxLength = 10;
            if (Chasis_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
        }

        private void Engine_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Engine_No.MaxLength = 10;
            if (Engine_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
 
        }

        private void Engine_No_Leave(object sender, EventArgs e)
        {
            if (Chasis_No.TextLength < 6)
            {
                MessageBox.Show("PLZ_FILL_UP_Correctly__!!!");
            }
        }
    }
}
