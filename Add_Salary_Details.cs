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
    public partial class Add_Salary_Details : Form
    {
        public Add_Salary_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

        


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Salary_ID.Text == "" || Emp_ID.Text == "" || DOJ.Text == "" || DOR.Text == "" || Basic_Pay.Text == "" || Deduction.Text == "" || ESC.Text == "" || Date.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_FIELDS");
            }
            else
            {


                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO SALARY (Salary_ID,Emp_ID,Date_Of_Joining,Date_Of_Retirement,Basic_Pay,Deduction,E_Salary_Code,Date)VALUES('" + Salary_ID.Text + "','" + Emp_ID.Text + "','" + DOJ.Text + "','" + DOR.Text + "','" + Basic_Pay.Text + "','" + Deduction.Text + "','" + ESC.Text + "','" + Date.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Salary_ID.Text = "";
                Emp_ID.Text = "";
                DOJ.Text = "";
                DOR.Text = "";
                Basic_Pay.Text = "";
                Deduction.Text = "";
                ESC.Text = "";
                Date.Text = "";

                Salary_ID.Focus();

                MessageBox.Show("SAVED_SUCCESSFULLY!!!");

                Add_Salary_Details ds = new Add_Salary_Details();
                this.Dispose(false);
                ds.Show();



            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            //Salary_ID.Text = "";
            Emp_ID.Text = "";
            DOJ.Text = "";
            DOR.Text = "";
            Basic_Pay.Text = "";
            Deduction.Text = "";
            ESC.Text = "";
            Date.Text = "";

            Salary_ID.Focus();


            MessageBox.Show("ALL_CLEARED__");

        }


        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;

        private void Add_Salary_Details_Load(object sender, EventArgs e)
        {
            
            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from SALARY";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            Salary_ID.Text= "" + count;
            co.Close();




            con.Open();
            SqlCommand sc = new SqlCommand("select pid from Product_entry", con);
            SqlDataReader dr = sc.ExecuteReader();


            while (dr.Read())
            {

                Emp_ID.Items.Add(dr[0]);
            }
            con.Close();



        }

        private void Basic_Pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Deduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void ESC_KeyPress(object sender, KeyPressEventArgs e)
        {

            ESC.MaxLength = 10;
            if (ESC.TextLength == 10)
            {
                //MessageBox.Show("Maximum Length is 10 number only");
            }
            if (/*e.KeyChar < '0' ||*/ e.KeyChar > '9')
            {
                MessageBox.Show("This Entry can only contain numbers");
                e.KeyChar = (char)0;
            }
 
        }

        private void ESC_Leave(object sender, EventArgs e)
        {
            if (ESC.TextLength < 4)
            {
                MessageBox.Show("PLEASE_FIL_UP_CORRECTLY__!!");
            }
        }

       
    }
}
