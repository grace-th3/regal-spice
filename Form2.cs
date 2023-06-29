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



        private void button1_Click(object sender, EventArgs e)
        {
            string desiredValue = Properties.Settings.Default.currentPassword; // The desired value to compare against//
            
            if (passwordBox.Text == desiredValue)
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                //attempts++;
                label1.Visible = true;
                label1.Location = new Point(373, 460);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
