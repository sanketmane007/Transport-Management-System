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
    public partial class Update_Billing_Detail_Form : Form
    {
        public Update_Billing_Detail_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SANKET\SANKET;Initial Catalog=Transport_Mgmt_System;Integrated Security=True;Pooling=False");
     

        private void SEARCH_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Billing_Detail WHERE Bill_No='" + Bill_No.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vehicle_ID.Text = dt.Rows[0][1].ToString();
            Party_ID.Text = dt.Rows[0][2].ToString();
            DOL.Text = dt.Rows[0][3].ToString();
            POL.Text = dt.Rows[0][4].ToString();
            POU.Text = dt.Rows[0][5].ToString();
            WIM.Text = dt.Rows[0][6].ToString();
            RPM.Text = dt.Rows[0][7].ToString();
            Total_Amount.Text = dt.Rows[0][8].ToString();
            Advance_Amount.Text = dt.Rows[0][9].ToString();
            Balance_Amount.Text = dt.Rows[0][10].ToString();
            Bill_Status.Text = dt.Rows[0][11].ToString();
            Material_Desc.Text = dt.Rows[0][12].ToString();
            Date.Text = dt.Rows[0][13].ToString();

            con.Close();

            MessageBox.Show("Search_Successfully!!!");

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Total_Amount.Text == "" || Advance_Amount.Text == "" || Balance_Amount.Text == "")
            {
                MessageBox.Show("PLZ_FILL_RECOMMENDED_DATA__!!!");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Billing_Detail SET Total_Amount='" + Total_Amount.Text + "',Advance_Amount='" + Advance_Amount.Text + "',Balance_Amount='" + Balance_Amount.Text + "' WHERE Bill_NO='" + Bill_No.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                Bill_No.Text = "";
                Vehicle_ID.Text = "";
                Party_ID.Text = "";
                DOL.Text = "";
                POL.Text = "";
                POU.Text = "";
                WIM.Text = "";
                RPM.Text = "";
                Total_Amount.Text = "";
                Advance_Amount.Text = "";
                Balance_Amount.Text = "";
                Bill_Status.Text = "";
                Material_Desc.Text = "";
                Date.Text = "";


                Bill_No.Focus();

                MessageBox.Show("UPDATE_SUCCESSFULLY!!!");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

            Bill_No.Text = "";
            Vehicle_ID.Text = "";
            Party_ID.Text = "";
            DOL.Text = "";
            POL.Text = "";
            POU.Text = "";
            WIM.Text = "";
            RPM.Text = "";
            Total_Amount.Text = "";
            Advance_Amount.Text = "";
            Balance_Amount.Text = "";
            Bill_Status.Text = "";
            Material_Desc.Text = "";
            Date.Text = "";


            Bill_No.Focus();

            MessageBox.Show("CLEAR_SUCCESSFULLY!!!");
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Billing_Detail_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet5.Billing_Detail' table. You can move, or remove it, as needed.
            this.billing_DetailTableAdapter.Fill(this.transport_Mgmt_SystemDataSet5.Billing_Detail);
            con.Open();
            SqlCommand sc = new SqlCommand("SELECT Bill_No from Billing_Detail",con);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                Bill_No.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void Total_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Advance_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void Balance_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a, b;
            a = int.Parse(Total_Amount.Text);
            b = int.Parse(Advance_Amount.Text);
            a = a - b;
            Balance_Amount.Text = a.ToString();

            
            
            
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("USE_ONLY_NUMBERS");
                e.KeyChar = (char)0;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Billing_Detail", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
