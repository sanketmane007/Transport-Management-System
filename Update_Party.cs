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
    public partial class Update_Party : Form
    {
        public Update_Party()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

        private void Edit_Party_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet6.PARTY' table. You can move, or remove it, as needed.
            this.pARTYTableAdapter.Fill(this.transport_Mgmt_SystemDataSet6.PARTY);

            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Party_ID FROM PARTY",con);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                Party_ID.Items.Add(dr[0]);
            }
            con.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Party_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PARTY WHERE Party_ID='" + Party_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Party_Name.Text = dt.Rows[0][1].ToString();
                H_O.Text = dt.Rows[0][2].ToString();
                State.Text = dt.Rows[0][3].ToString();
                City.Text = dt.Rows[0][4].ToString();
                Postcode.Text = dt.Rows[0][5].ToString();
                Tele_No.Text = dt.Rows[0][6].ToString();
                Mob_No.Text = dt.Rows[0][7].ToString();
                Fax_No.Text = dt.Rows[0][8].ToString();
                E_ID.Text = dt.Rows[0][9].ToString();
                A_E_ID.Text = dt.Rows[0][10].ToString();
                Website.Text = dt.Rows[0][11].ToString();
                Date.Text = dt.Rows[0][12].ToString();

                con.Close();
                MessageBox.Show("SEARCH_SUCCESSFULLY!!!");
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Tele_No.Text == "" || Mob_No.Text == "" || Fax_No.Text == "" || E_ID.Text == "" || A_E_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE PARTY SET Party_Name='" + Party_Name.Text + "',Head_Office='" + H_O.Text + "',State='" + City.Text + "',City='" + State.Text + "',Post_Code='" + Postcode.Text + "',Telephone_No='" + Tele_No.Text + "',Mobile_No='" + Mob_No + "',Fax_No='" + Fax_No.Text + "',Email_ID='" + E_ID.Text + "',Alternative_Email_ID='" + A_E_ID.Text + "',Website='" + Website.Text + "' WHERE Party_ID='" + Party_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Party_ID.Text = "";
                Party_Name.Text = "";
                H_O.Text = "";
                City.Text = "";
                State.Text = "";
                Postcode.Text = "";
                Tele_No.Text = "";
                Mob_No.Text = "";
                Fax_No.Text = "";
                E_ID.Text = "";
                A_E_ID.Text = "";
                Website.Text = "";

                Party_ID.Focus();

                MessageBox.Show("UPDATED SUCCESSFULLY!!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Party_ID.Text = "";
            Party_Name.Text = "";
            H_O.Text = "";
            City.Text = "";
            State.Text = "";
            Postcode.Text = "";
            Tele_No.Text = "";
            Mob_No.Text = "";
            Fax_No.Text = "";
            E_ID.Text = "";
            A_E_ID.Text = "";
            Website.Text = "";

            Party_ID.Focus();

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void Tele_No_Leave(object sender, EventArgs e)
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

        private void Mob_No_Leave(object sender, EventArgs e)
        {

            if (Mob_No.TextLength < 10)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Fax_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fax_No.MaxLength = 10;
            if (Fax_No.TextLength == 10)
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

            if (Fax_No.TextLength < 10)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void E_ID_Leave(object sender, EventArgs e)
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

        private void A_E_ID_Leave(object sender, EventArgs e)
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

        private void refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PARTY", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}
