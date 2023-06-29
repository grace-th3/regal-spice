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
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            
        }

        //the actual display of revenue
        private void Revenue_Load(object sender, EventArgs e)
        {
            label2.Text = Properties.Settings.Default.totalRev.ToString();
        }


        //back to main menu
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu form3 = new mainMenu();
            form3.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

