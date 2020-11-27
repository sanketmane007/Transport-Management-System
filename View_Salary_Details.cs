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
    public partial class View_Salary_Details : Form
    {
        public View_Salary_Details()
        {
            InitializeComponent();
        }

        private void View_Salary_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_Mgmt_SystemDataSet20.SALARY' table. You can move, or remove it, as needed.
            this.sALARYTableAdapter.Fill(this.transport_Mgmt_SystemDataSet20.SALARY);

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
