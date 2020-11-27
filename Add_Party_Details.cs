using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Transport_mgmt
{
    public partial class Add_Party_Details : Form
    {
        public Add_Party_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");



        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;

        private void Add_Party_Load(object sender, EventArgs e)
        {

            Party_ID.Text = DateTime.Now.ToString("dd/mm/yyyy");


            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from PARTY";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Party_ID.Text = "" + count;
            co.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Party_ID.Text == "" || Party_Name.Text == "" || H_O.Text == "" || State.Text == "" || City.Text == "" || Post_Code.Text == "" || Tele_No.Text == "" || Mob_No.Text == "" || Fax_No.Text == "" || E_ID.Text == "" || A_E_ID.Text == "" || Website.Text == "" || Date.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_FIELDS__!!");
            }
            else
            {


                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO PARTY (Party_ID,Party_Name,Head_Office,State,City,Post_Code,Telephone_No,Mobile_No,Fax_No,Email_ID,Alternative_Email_ID,Website)VALUES('" + Party_ID.Text + "','" + Party_Name.Text + "','" + H_O.Text + "','" + State.Text + "','" + City.Text + "','" + Post_Code.Text + "','" + Tele_No.Text + "','" + Mob_No.Text + "','" + Fax_No.Text + "','" + E_ID.Text + "','" + A_E_ID.Text + "','" + Website.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                Party_ID.Text = "";
                Party_Name.Text = "";
                H_O.Text = "";
                State.Text = "";
                City.Text = "";

                Post_Code.Text = "";
                Tele_No.Text = "";
                Mob_No.Text = "";
                Fax_No.Text = "";
                E_ID.Text = "";
                A_E_ID.Text = "";
                Website.Text = "";
                Party_ID.Focus();
                MessageBox.Show("SAVE SUCCESSFULLY!!!");

                Add_Party_Details ds = new Add_Party_Details();
                this.Dispose(false);
                ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            //Party_ID.Text = "";
            Party_Name.Text = "";
            H_O.Text = "";
            State.Text = "";
            City.Text = "";

            Post_Code.Text = "";
            Tele_No.Text = "";
            Mob_No.Text = "";
            Fax_No.Text = "";
            E_ID.Text = "";
            A_E_ID.Text = "";
            Website.Text = "";

            Party_ID.Focus();

            MessageBox.Show("ALL_CLEARED__");
        
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Party_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void City_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void State_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        
        private void Tele_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tele_No.MaxLength = 10;
            if (Tele_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
        
        }

        private void Tele_No_MouseLeave(object sender, EventArgs e)
        {
            if (Tele_No.TextLength < 10)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Mob_No_KeyPress(object sender, KeyPressEventArgs e)
        {

            Mob_No.MaxLength = 10;
            if (Mob_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
        }

        private void Mob_No_MouseLeave(object sender, EventArgs e)
        {
            if (Mob_No.TextLength < 10)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void E_ID_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(E_ID.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(E_ID.Text))
                {
                    MessageBox.Show("EMAIL_IS_NOT_VALID__!!");
                }
            }
        }

        private void A_E_ID_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(E_ID.Text))
            {
                Regex reg1 = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg1.IsMatch(E_ID.Text))
                {
                    MessageBox.Show("EMAIL_IS_NOT_VALID__!!");
                }
            }
        }

        private void Post_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
           Post_Code.MaxLength = 6;
            if (Post_Code.TextLength == 6)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 6 NUMBERS__");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')                                            //only numberss
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Post_Code_Leave(object sender, EventArgs e)
        {
            if (Post_Code.TextLength < 6)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Fax_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fax_No.MaxLength = 10;
            if (Mob_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
 
        }

        private void Fax_No_Leave(object sender, EventArgs e)
        {
            if (Fax_No.TextLength < 12)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Website_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tele_No.MaxLength = 20;
            if (Tele_No.TextLength == 20)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 20 NUMBERS__");
            }
        }
    }
}
