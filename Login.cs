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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void btn1_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("PLZ_FILL_THE_ALL_DATA___!!!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False;");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*)from Registration where Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    MessageBox.Show("LOGIN DONE");
                    Transport_Management t = new Transport_Management();
                    t.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct USERNAME and PASSWORD");
                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_username.Focus();
                }




            }
        }

        private void btn3_registration_Click(object sender, EventArgs e)
        {

            this.Hide();
            Registration f = new Registration();
            f.Show();               

        }

        private void btn2_reset_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_username.Focus();
        }

        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {

            txt_password.MaxLength = 8;
            if (txt_password.TextLength == 8)
            {
                MessageBox.Show("MAXIMUM LENGTH IS_8_NUMBERS__");
            }
        }

    }
}
