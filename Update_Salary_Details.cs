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
    public partial class Update_Salary_Details : Form
    {
        public Update_Salary_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");

        

      
        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Salary_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SALARY WHERE Salary_ID='" + Salary_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Emp_ID.Text = dt.Rows[0][1].ToString();
                DOJ.Text = dt.Rows[0][2].ToString();
                DOR.Text = dt.Rows[0][3].ToString();
                Basic_Pay.Text = dt.Rows[0][4].ToString();
                Deduction.Text = dt.Rows[0][5].ToString();
                ESC.Text = dt.Rows[0][6].ToString();
                Date.Text = dt.Rows[0][7].ToString();

                con.Close();

                MessageBox.Show("SEARCH_SUCCESSFULLY!!!");
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Basic_Pay.Text == "" || Deduction.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE SALARY SET Emp_ID='" + Emp_ID.Text + "',Date_Of_Joining='" + DOJ.Text + "',Date_Of_Retirement='" + DOR.Text + "',Basic_Pay='" + Basic_Pay.Text + "',Deduction='" + Deduction.Text + "',E_Salary_Code='" + ESC.Text + "' WHERE Salary_ID='" + Salary_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("UPDATED_SUCCESSFULLY!!");

                Salary_ID.Text = "";
                Emp_ID.Text = "";
                DOJ.Text = "";
                DOR.Text = "";
                Basic_Pay.Text = "";
                Deduction.Text = "";
                ESC.Text = "";
                Date.Text = "";

                Emp_ID.Focus();
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

            Salary_ID.Text = "";
            Emp_ID.Text = "";
            DOJ.Text = "";
            DOR.Text = "";
            Basic_Pay.Text = "";
            Deduction.Text = "";
            ESC.Text = "";
            Date.Text = "";

            Emp_ID.Focus();

            MessageBox.Show("All_CLEAR__");
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Salary_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet7.SALARY' table. You can move, or remove it, as needed.
            this.sALARYTableAdapter.Fill(this.transport_Mgmt_SystemDataSet7.SALARY);

            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Salary_ID FROM SALARY",con);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                Salary_ID.Items.Add(dr[0]);
            }
            con.Close();

        }

        private void Basic_Pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Basic_Pay.MaxLength = 20;
            if (Basic_Pay.TextLength == 20)
            {
                MessageBox.Show("THIS_IS_A_HIGH_LIMIT__!!!");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Deduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            Deduction.MaxLength = 20;
            if (Deduction.TextLength == 20)
            {
                MessageBox.Show("THIS_IS_A_HIGH_LIMIT__!!!");
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SALARY", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
