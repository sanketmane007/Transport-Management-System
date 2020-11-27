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
    public partial class Update_Emp_Daily_Entry : Form
    {
        public Update_Emp_Daily_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
        private void UPDATE_Click(object sender, EventArgs e)
        {

            if (Entry_ID.Text == "")
            {
                MessageBox.Show("PLZ_FILL_UP_RECOMMENDED_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Staff_Daily_Entry SET IN_Time='" + IN_Time.Text + "',OUT_Time='" + OUT_Time.Text + "' WHERE Entry_ID='" + Entry_ID.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Entry_ID.Text = "";
                Emp_ID.Text = "";
                Emp_Name.Text = "";
                Today_Date.Text = "";
                IN_Time.Text = "";
                OUT_Time.Text = "";

                Entry_ID.Focus();
            }
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Entry_ID.Text == "")
            {
                MessageBox.Show("DATA_SEARCH_SUCCESSFULLY_!!!");
                Entry_ID.Focus();

            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Staff_Daily_Entry WHERE Entry_ID='" + Entry_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Emp_ID.Text = dt.Rows[0][1].ToString();
                Emp_Name.Text = dt.Rows[0][2].ToString();
                Today_Date.Text = dt.Rows[0][3].ToString();
                IN_Time.Text = dt.Rows[0][4].ToString();
                OUT_Time.Text = dt.Rows[0][5].ToString();
            }
        }

        private void Update_Emp_Daily_Entry_Load(object sender, EventArgs e)
        {

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Entry_ID.Text = "";
            Emp_ID.Text = "";
            Emp_Name.Text = "";
            Today_Date.Text = "";
            IN_Time.Text = "";
            OUT_Time.Text = "";

            Entry_ID.Focus();
           
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Emp_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                if (e.KeyChar != (char)96)
                {
                    MessageBox.Show("This_entry_can_contain_only_alphabets__!!!");
                }
            }
        }

      }
}
