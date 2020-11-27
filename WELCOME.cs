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
    public partial class WELCOME : Form
    {
        public WELCOME()
        {
            InitializeComponent();
        }

        private void WELCOME_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 40;
        }
        int z=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            z=z+1;
            if(z>=100)
            {
                this.Hide();
                timer1.Enabled = false;
                Login l = new Login();
                l.Show();
            }
            pgb1.Value=z;

        }

        }
    }

