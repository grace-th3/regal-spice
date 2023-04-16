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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Display a message box to prompt the user to select a curry item
                DialogResult result = MessageBox.Show("Please select a curry item.", "Curry Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // If the user clicked OK, display a message box that lists out the meats for the selected curry item
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("The meats for the selected curry item are: chicken, beef, lamb, and pork.", "Meats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            checkBox4.Visible = !checkBox4.Visible;

            if (checkBox4.Checked == true)
            {
                textBox2.Text = checkBox4.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
  


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
