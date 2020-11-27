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
    public partial class Add_Emp_Daily_Entry : Form
    {
        public Add_Emp_Daily_Entry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");


        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Entry_ID.Text == "" || Emp_ID.Text == "" || Emp_Name.Text == "" || Today_Date.Text == "" || IN_Time.Text == "" || OUT_Time.Text == "")
            {
                MessageBox.Show("PLEASE_FILL_ALL_DATA__!!!");
                Entry_ID.Focus();
            }
            else
            {
               con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Staff_Daily_Entry(Entry_ID,Emp_ID,Emp_Name,Today_Date,IN_Time,OUT_Time)VALUES('" + Entry_ID.Text + "','" + Emp_ID.Text + "','" + Emp_Name.Text + "','" + Today_Date.Text + "','" + IN_Time.Text + "','" + OUT_Time.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Entry_ID.Text = "";
                Emp_ID.Text = "";
                Emp_Name.Text = "";
                Today_Date.Text = "";
                IN_Time.Text = "";
                OUT_Time.Text = "";

                Entry_ID.Focus();

                MessageBox.Show("DATA_SAVING_SUCCESSFULLY__!!!");
                Add_Emp_Daily_Entry ds = new Add_Emp_Daily_Entry();
                this.Dispose(false);
                ds.Show();


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            
            //Entry_ID.Text = "";
            Emp_ID.Text = "";
            Emp_Name.Text = "";
            Today_Date.Text = "";
            IN_Time.Text = "";
            OUT_Time.Text = "";

            Entry_ID.Focus();

            MessageBox.Show("ALL_CLEAR_SUCCESSFULLY__!!!");

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string strconstring = @"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False";
        string str;
        SqlCommand com;
        int count;
        private void Add_Emp_Daily_Entry_Load(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(strconstring);

            str = "select count(*) from Employees";
            com = new SqlCommand(str, co);
            co.Open();
            count = Convert.ToInt16(com.ExecuteScalar()) + 1;
           Entry_ID.Text = "" + count;
            co.Close();



            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Emp_ID FROM Employees", con);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                Emp_ID.Items.Add(dr[0]);
            }
            con.Close();

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

        private void Emp_Name_MouseClick(object sender, MouseEventArgs e)
        {
            if (Emp_ID.Text == "")
            {
                MessageBox.Show("Plz_fiLL_Recomended_Data__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * From Employees WHERE Emp_ID='" + Emp_ID.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Emp_Name.Text = dt.Rows[0][2].ToString();
                con.Close();
            }
        }

        private void Emp_Name_Leave(object sender, EventArgs e)
        {

        }

        private void Emp_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
