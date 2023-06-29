using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regal_spice
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void orderprocess_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm form1 = new orderForm();
            form1.Show();
        }


        private void revenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Revenue revenue = new Revenue();
            revenue.Show();
        }


        //go to settings
        private void settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        //go back to startup
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            startupForm start = new startupForm();
            start.Show();
        }
    }
}
