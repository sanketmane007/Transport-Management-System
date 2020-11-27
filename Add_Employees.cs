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
    public partial class Add_Employees : Form
    {
        public Add_Employees()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

        
       
        private void SAVE_Click(object sender, EventArgs e)
        {

            if (status.Text == "" || F_Name.Text == "" || M_Name.Text == "" || L_Name.Text == "" || DOB.Text == "" || Gender.Text == "" || Religion.Text == "" || BG.Text == "" || A_No.Text == "" || DLN.Text == "" || present_add.Text == "" || State.Text == "" || District.Text == "" || City.Text == "" || Pincode.Text == "" || Phone_No.Text == "" || Mob_No.Text == "" || E_ID.Text == "" || A_E_ID.Text == "" || Entry_Date.Text == ""||Path.Text=="")
            {
                MessageBox.Show("please_Fill_Up_All_Fields__");

            }
            else
            {

                con.Open();
                SqlCommand sc = new SqlCommand("INSERT INTO Employees (Status,Emp_ID,First_Name,Middle_Name,Last_Name,Date_Of_Birth,Gender,Religion,Blood_Group,Adhar_No,Driving_Lic_No,Pancard_No,Present_Address,State,District,City,Pincode,Phone_No,Mobile_No,Email_ID,Alternative_Email_ID,Entry_Date,Photo_Upload)VALUES(@Status,@Emp_ID,@F_Name,@M_Name,@L_Name,@DOB,@Gender,@Religion,@BG,@A_No,@DLN,@P_No,@P_Add,@State,@District,@City,@Pincode,@Phone_No,@M_No,@E_ID,@AEI,@Entry_Date,@Photo_Upload)", con);


                FileStream fs1 = new FileStream(Path.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] image = new byte[fs1.Length];
                fs1.Read(image, 0, Convert.ToInt32(fs1.Length));
                fs1.Close();
                SqlParameter pra = new SqlParameter("Photo_Upload", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);


                sc.Parameters.Add("@Status", status.Text);
                sc.Parameters.Add("@Emp_ID", Emp_ID.Text);
                sc.Parameters.Add("F_Name", F_Name.Text);
                sc.Parameters.Add("M_Name", M_Name.Text);
                sc.Parameters.Add("L_Name", L_Name.Text);
                sc.Parameters.Add("DOB", DOB.Text);
                sc.Parameters.Add("@Gender", Gender.Text);
                sc.Parameters.Add("@Religion", Religion.Text);
                sc.Parameters.Add("@BG", BG.Text);
                sc.Parameters.Add("@A_No", A_No.Text);
                sc.Parameters.Add("@DLN", DLN.Text);
                sc.Parameters.Add("P_No", P_No.Text);
                sc.Parameters.Add("@P_Add", present_add.Text);
                sc.Parameters.Add("@State", District.Text);
                sc.Parameters.Add("@District", District.Text);
                sc.Parameters.Add("@City", City.Text);
                sc.Parameters.Add("@Pincode", Pincode.Text);
                sc.Parameters.Add("Phone_No", Phone_No.Text);
                sc.Parameters.Add("@M_No", Mob_No.Text);
                sc.Parameters.Add("@E_ID", E_ID.Text);
                sc.Parameters.Add("@AEI", A_E_ID.Text);
                sc.Parameters.Add("@Entry_Date", Entry_Date.Text);
                sc.Parameters.Add(pra);

                sc.ExecuteNonQuery();
                
                con.Close();


                con.Close();
                status.Text = "";
                F_Name.Text = "";
                M_Name.Text = "";
                L_Name.Text = "";
                DOB.Text = "";
                Gender.Text = "";
                Religion.Text = "";
                BG.Text = "";
                A_No.Text = "";
                DLN.Text = "";
                P_No.Text = "";
                present_add.Text = "";
                State.Text = "";
                District.Text = "";
                City.Text = "";
                Pincode.Text = "";
                Phone_No.Text = "";
                Mob_No.Text = "";
                E_ID.Text = "";
                A_E_ID.Text = "";
                Emp_ID.Text = "";
                Entry_Date.Text = "";
                Path.Text = "";
                Picturebox1.Image = null;
                status.Focus();
                MessageBox.Show("SAVE SUCCESSFILLY-!!!");

                Add_Employees ds = new Add_Employees();
                this.Dispose(false);
                ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            status.Text = "";
            F_Name.Text = "";
            M_Name.Text = "";
            L_Name.Text = "";
            DOB.Text = "";
            Gender.Text = "";
            Religion.Text = "";
            BG.Text = "";
            A_No.Text = "";
            DLN.Text = "";
            P_No.Text = "";
            present_add.Text = "";
            State.Text = "";
            District.Text = "";
            City.Text = "";
            Pincode.Text = "";
            Phone_No.Text = "";
            Mob_No.Text = "";
            E_ID.Text = "";
            A_E_ID.Text = "";
          //  Emp_ID.Text = "";
            Entry_Date.Text = "";
           Path.Text = "";
           Picturebox1.Image = null;


            status.Focus();
            MessageBox.Show("ALL_CLEARED__");
        
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
                
        }

        private void Choose_Path_Click(object sender, EventArgs e)
        { 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Picturebox1.Image = new Bitmap(openFileDialog1.FileName);
                Path.Text = openFileDialog1.FileName;
            }
            


        }


          string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;

        private void Add_Employees_Load(object sender, EventArgs e)
        {
            
       
            SqlConnection co=new SqlConnection(strconstring);
           
            str="select count(*) from Employees";
            com = new SqlCommand(str,co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar())+ 1;
            Emp_ID.Text = ""+count;
            co.Close();


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

        private void M_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Religion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void A_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            A_No.MaxLength = 12;
            if (A_No.TextLength == 12)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 12 NUMBERS__");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
 
        }

        private void A_No_Leave(object sender, EventArgs e)
        {
            if (A_No.TextLength < 12)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

       private void DLN_Leave(object sender, EventArgs e)
        {

            if (DLN.TextLength < 6)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void DLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLN.MaxLength = 6;
            if (DLN.TextLength ==6 )
            {
                MessageBox.Show("MAXIMUM LENGTH IS 6 NUMBERS__");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')                                            //only numberss
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Pincode_KeyPress(object sender, KeyPressEventArgs e)
        {

            Pincode.MaxLength = 6;
            if (Pincode.TextLength == 6)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 6 NUMBERS__");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
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

        private void Phone_No_MouseLeave(object sender, EventArgs e)
        {
            if (Phone_No.TextLength < 10)
            {
                MessageBox.Show("Minimum_Length_10__!!");
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

        private void E_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           
            }

        private void E_ID_Leave(object sender, EventArgs e)
        {
             if(!string.IsNullOrWhiteSpace(E_ID.Text))
                {
                   Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                   if (!reg.IsMatch(E_ID.Text))
                    {
                      MessageBox.Show("EMAIL_IS_NOT_VALID__!!");
                    }
                }
        }

        private void A_E_ID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(A_E_ID.Text))
            {
                Regex reg1 = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg1.IsMatch(A_E_ID.Text))
                {
                    MessageBox.Show("EMAIL_IS_NOT_VALID__!!");
                }
            }
        }

        private void P_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            P_No.MaxLength = 10;
            if (P_No.TextLength == 10)
            {
                MessageBox.Show("MAXIMUM LENGTH IS 10__");
            }
        }

        private void P_No_Leave(object sender, EventArgs e)
        {
            if (P_No.TextLength < 10)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        private void Pincode_Leave(object sender, EventArgs e)
        {
            if (Pincode.TextLength < 6)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

        
       
    }
}
