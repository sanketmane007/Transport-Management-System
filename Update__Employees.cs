using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Transport_mgmt
{
    public partial class Update__Employees : Form
    {
        public Update__Employees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        
        private void Edit__Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.transport_Mgmt_SystemDataSet3.Employees);
            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Emp_ID FROM Employees", con);
            SqlDataReader dr = sc.ExecuteReader();

            while (dr.Read())
            {
                Emp_ID.Items.Add(dr[0]);
            }
            con.Close();

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Status.Text == "" || Emp_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_THE_RECOMMENDED_DATA___!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employees WHERE Status='" + Status.Text + "' and  Emp_ID='" + Emp_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                F_Name.Text = dt.Rows[0][2].ToString();
                M_Name.Text = dt.Rows[0][3].ToString();
                L_Name.Text = dt.Rows[0][4].ToString();
                DOB.Text = dt.Rows[0][5].ToString();
                Gender.Text = dt.Rows[0][6].ToString();
                Religion.Text = dt.Rows[0][7].ToString();
                BG.Text = dt.Rows[0][8].ToString();
                A_No.Text = dt.Rows[0][9].ToString();
                DLC.Text = dt.Rows[0][10].ToString();
                P_No.Text = dt.Rows[0][11].ToString();
                Present_Add.Text = dt.Rows[0][12].ToString();
                State.Text = dt.Rows[0][13].ToString();
                District.Text = dt.Rows[0][14].ToString();
                City.Text = dt.Rows[0][15].ToString();
                Pincode.Text = dt.Rows[0][16].ToString();
                Phone_No.Text = dt.Rows[0][17].ToString();
                Mob_No.Text = dt.Rows[0][18].ToString();
                E_ID.Text = dt.Rows[0][19].ToString();
                A_E_ID.Text = dt.Rows[0][20].ToString();
                Entry_Date.Text = dt.Rows[0][21].ToString();


                byte[] mydata = new byte[0];
                mydata = (byte[])dt.Rows[0][22];
                MemoryStream ms = new MemoryStream(mydata);

                pictureBox1.Image = Image.FromStream(ms);


                con.Close();
                MessageBox.Show("SEARCH_SUCCESSFULLY!!");

            }

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Present_Add.Text == "" || State.Text == "" || District.Text == "" || City.Text == "" || Pincode.Text == "" || Phone_No.Text == "" || Mob_No.Text == "" || E_ID.Text == "" || A_E_ID.Text == ""||Status.Text==""||Emp_ID.Text==""||Gender.Text=="")
            {
                MessageBox.Show("PLZ_FILL_UP_ALL_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Employees SET Present_Address='" + Present_Add.Text + "',State='" + State.Text + "',District='" + District.Text + "',City='" + City.Text + "',Pincode='" + Pincode.Text + "',Phone_No='" + Phone_No.Text + "',Mobile_No='" + Mob_No.Text + "',Email_ID='" + E_ID.Text + "',Alternative_Email_ID='" + A_E_ID.Text + "' WHERE Status='" + Status.Text + "' and Emp_ID='" + Emp_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();

                con.Close();

                Status.Text = "";
                Emp_ID.Text = "";
                F_Name.Text = "";
                M_Name.Text = "";
                L_Name.Text = "";
                DOB.Text = "";
                Gender.Text = "";
                Religion.Text = "";
                BG.Text = "";
                A_No.Text = "";
                DLC.Text = "";
                P_No.Text = "";
                Present_Add.Text = "";
                State.Text = "";
                District.Text = "";
                City.Text = "";
                Pincode.Text = "";
                Phone_No.Text = "";
                Mob_No.Text = "";
                E_ID.Text = "";
                A_E_ID.Text = "";
                Entry_Date.Text = "";

                Status.Focus();
                MessageBox.Show("UPDATED SUCCESSFULLY!!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Status.Text = "";
            Emp_ID.Text = "";
            F_Name.Text = "";
            M_Name.Text = "";
            L_Name.Text = "";
            DOB.Text = "";
            Gender.Text = "";
            Religion.Text = "";
            BG.Text = "";
            A_No.Text = "";
            DLC.Text = "";
            P_No.Text = "";
            Present_Add.Text = "";
            State.Text = "";
            District.Text = "";
            City.Text = "";
            Pincode.Text = "";
            Phone_No.Text = "";
            Mob_No.Text = "";
            E_ID.Text = "";
            A_E_ID.Text = "";
            Entry_Date.Text = "";

            Status.Focus();
            
            MessageBox.Show("ALL_CLEARED___");
       
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHOOSE_PATH_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Present_Add_KeyPress(object sender, KeyPressEventArgs e)
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

        private void District_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pincode.MaxLength = 6;
            if (Pincode.TextLength == 6)
            {
                //MessageBox.Show("Maximum Length is 6 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
 
        }

        private void Pincode_Leave(object sender, EventArgs e)
        {
            if (Pincode.TextLength < 6)
            {
                MessageBox.Show("PLEASE_FILL_UP_CORRECTLY__!!");
            }
        }

        private void Phone_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Phone_No.MaxLength = 10;
            if (Phone_No.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
 
        }

        private void Phone_No_Leave(object sender, EventArgs e)
        {
            if (Phone_No.TextLength < 10)
            {
                MessageBox.Show("PLEASE_FILL_UP_CORRECTLY__!!");
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
                MessageBox.Show("PLEASE_FILL_UP_CORRECTLY__!!");
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employees", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        
       

        

       
     }
}
