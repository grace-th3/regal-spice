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
    public partial class Passwords : Form
    {
        public Passwords()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwords_Load(object sender, EventArgs e)
        {

        }

        string correctpassword = Properties.Settings.Default.currentPassword;
       



        private void changeButton_Click(object sender, EventArgs e)
        {
            string enteredPassword = textBox1.Text;
            string newPassword = textBox2.Text;
            string confirmedPassword = textBox3.Text;

            //if (correctpassword == enteredPassword)
            //{

                if (newPassword == confirmedPassword)
                {
                    Properties.Settings.Default.currentPassword = newPassword;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Successfully changed password!");
                }
                
                else
                {
                    
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Passwords do not match.");
                }
            //}

            //else
            //{
            //    MessageBox.Show("The current password is incorrect");
            //}
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
