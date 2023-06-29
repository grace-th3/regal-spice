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
    public partial class startupForm : Form
    {
        public startupForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
        }


        //validating password
        private void button1_Click(object sender, EventArgs e)
        {
            string desiredValue = Properties.Settings.Default.currentPassword; // The desired value to compare against//
            
            if (passwordBox.Text == desiredValue)
            {
                this.Hide();
                mainMenu form3 = new mainMenu();
                form3.Show();
            }
            else
            {
               
                label1.Visible = true;
                label1.Location = new Point(373, 460);
            }
        }

    }
}
