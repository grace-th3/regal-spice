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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            populateReceipt();
        }

        private void populateReceipt()
        {
           
            orderNumber.Text = Program.orderNum;

            foreach (Dish dish in Program.orderedItems)
            {
                listView1.Items.Add(Environment.NewLine + dish.name + "   " + dish.price.ToString());
            }

            commentReceipt.Text = ("Comment:" + "" + Program.comments);
           
            
            dateandtime.Text = Program.orderTime.ToString();
            
            totalPaid.Text = ("Total paid:" + " " + "$" + Program.stringNum.ToString());

            sumTotal.Text = ("Total due:" + " " + "$" + Program.sumTot.ToString());
            changeDue.Text = ("Total change:" + " " + "$" + Program.changeReq.ToString());

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm form1 = new orderForm();
            form1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printer unavailable. Please connect printer first.");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu form3 = new mainMenu();
            form3.Show();
        }

    }
}
