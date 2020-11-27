using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transport_mgmt
{
    public partial class View_Bill_Payment_Entries : Form
    {
        public View_Bill_Payment_Entries()
        {
            InitializeComponent();
        }

       

        private void View_Bill_Payment_Entries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet13.Bill_Payment' table. You can move, or remove it, as needed.
            this.bill_PaymentTableAdapter.Fill(this.transport_Mgmt_SystemDataSet13.Bill_Payment);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
