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
    public partial class View_Vehicle_Daily_Entry_Details : Form
    {
        public View_Vehicle_Daily_Entry_Details()
        {
            InitializeComponent();
        }

        private void View_Vehicle_Daily_Entry_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet19.Vehicle_Daily_Entry' table. You can move, or remove it, as needed.
            this.vehicle_Daily_EntryTableAdapter.Fill(this.transport_Mgmt_SystemDataSet19.Vehicle_Daily_Entry);

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
        }

       
    }
}
