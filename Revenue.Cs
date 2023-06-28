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

        private void Revenue_Load(object sender, EventArgs e)
        {
            label2.Text = Program.total.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();

        }
    }
}

