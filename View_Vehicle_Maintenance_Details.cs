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
    public partial class View_Vehicle_Maintenance_Details : Form
    {
        public View_Vehicle_Maintenance_Details()
        {
            InitializeComponent();
        }

        private void View_Vehicle_Maintenance_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet17.Vehicle_Maintenance' table. You can move, or remove it, as needed.
            this.vehicle_MaintenanceTableAdapter.Fill(this.transport_Mgmt_SystemDataSet17.Vehicle_Maintenance);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
