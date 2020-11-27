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
    public partial class View_Vehicle_Details : Form
    {
        public View_Vehicle_Details()
        {
            InitializeComponent();
        }

        private void View_Vehicle_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet18.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.transport_Mgmt_SystemDataSet18.VEHICLE);

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
