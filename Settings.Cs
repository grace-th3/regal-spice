﻿using System;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        //to change password
        private void changePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Passwords passwords = new Passwords();
            passwords.Show();
        }

        //back to main menu
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu form3 = new mainMenu();
            form3.Show();
        }
    }
}
