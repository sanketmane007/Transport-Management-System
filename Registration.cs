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
    public partial class Registration : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        public Registration()
        {
            InitializeComponent();
        }



        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;

        private void Registration_Load(object sender, EventArgs e)
        {
            Reg_ID.Text = DateTime.Now.ToString("dd/mm/yyyy");


            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from Employees";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Reg_ID.Text = "" + count;
            co.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (Reg_ID.Text == "" || F_Name.Text == "" || L_Name.Text == "" || E_ID.Text == "" || A_E_ID.Text == "" || Mob_No.Text == "" || Add.Text == "" || Gender.Text == "" || B_ID.Text == "" || City.Text == "" || State.Text == "" || Country.Text == "" || Path.Text == "" || U_Name.Text == "" || Pass.Text == "" || C_Pass.Text == "" || Reg_Date.Text == "")
            {
                MessageBox.Show("PLZ_FILL_THE_ALL_DATA___!!!");
            }
            else
            {

                con.Open();
                

                SqlCommand sc = new SqlCommand("INSERT INTO Registration (Reg_ID,First_Name,Last_Name,Email_ID,Alternative_Email_ID,Mobile_No,Address,Gender,Birth_ID,City,State,Reg_Date,Country,Username,Password,Confirm_Password,Photo_Upload)VALUES(@Reg_ID,@F_Name,@L_Name,@E_ID,@A_E_ID,@Mob_No,@Add,@Gender,@B_ID,@City,@State,@Country,@Reg_Date,@U_Name,@Pass,@C_Pass,@Photo_Upload)", con);


                FileStream fs1 = new FileStream(Path.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] image = new byte[fs1.Length];
                fs1.Read(image, 0, Convert.ToInt32(fs1.Length));
                fs1.Close();
                SqlParameter pra = new SqlParameter("Photo_Upload", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);


                sc.Parameters.Add("@Reg_ID", Reg_ID.Text);
                sc.Parameters.Add("@F_Name", F_Name.Text);
                sc.Parameters.Add("@L_Name", L_Name.Text);
                sc.Parameters.Add("@E_ID", E_ID.Text);
                sc.Parameters.Add("@A_E_ID", A_E_ID.Text);
                sc.Parameters.Add("@Mob_No", Mob_No.Text);
                sc.Parameters.Add("@Add", Add.Text);
                sc.Parameters.Add("@Gender", Gender.Text);
                sc.Parameters.Add("@B_ID", B_ID.Text);
                sc.Parameters.Add("@City", City.Text);
                sc.Parameters.Add("@State", State.Text);
                sc.Parameters.Add("@Country", Country.Text);
                sc.Parameters.Add("@Reg_Date", Reg_Date.Text);
                sc.Parameters.Add("@U_Name", U_Name.Text);
                sc.Parameters.Add("@Pass", Pass.Text);
                sc.Parameters.Add("@C_Pass", C_Pass.Text);
                sc.Parameters.Add(pra);
                sc.ExecuteNonQuery();


                Reg_ID.Text = "";
                F_Name.Text = "";
                L_Name.Text = "";
                E_ID.Text = "";
                A_E_ID.Text = "";
                Mob_No.Text = "";
                Add.Text = "";
                Gender.Text = "";
                B_ID.Text = "";
                City.Text = "";
                State.Text = "";
                Reg_ID.Text = "";
                Country.Text = "";
                U_Name.Text = "";
                Pass.Text = "";
                C_Pass.Text = "";
                pictureBox1.Image = null;



                MessageBox.Show("Registration_Successfully!!_____");
                con.Close();
            }
        
        
        }

      
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();


        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            this.Hide();
            rg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                Path.Text = openFileDialog1.FileName;
            }

        }

        private void C_Pass_MouseLeave(object sender, EventArgs e)
        {

            if (Pass.Text == "" || C_Pass.Text == "")
            {
                MessageBox.Show("Please enter values");
                return;
            }
            if (Pass.Text != C_Pass.Text)
            {
                MessageBox.Show("confirm password not matching with new passsword");
                Pass.Focus();
                return;
            }

        }

        private void E_ID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void F_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void L_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

        private void A_E_ID_MouseClick(object sender, MouseEventArgs e)
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
            if (Mob_No.Text.Length < 10)
            {
                MessageBox.Show("Contact Number is NOT Valid, Please fill in a Correct form");
            }


        }

        private void U_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        
        }

        private void Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pass.MaxLength = 8;
            if (Pass.TextLength == 8)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 8 NUMBERS__");
            }

        }

        private void C_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Pass.MaxLength = 10;
            if (C_Pass.TextLength == 10)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 8 NUMBERS__");
            }

        }


        }
    }

