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
    public partial class orderForm : Form
    {
        //a list of the table layout panels - ensures cleaner and more efficient code
        List<TableLayoutPanel> menuCategories = new List<TableLayoutPanel>();


        //a list of all the currently selected items
        List<Dish> orderedItems = new List<Dish>();

        //a list that populates the Dish.cs class
        List<Dish> menu = new List<Dish>();

        List<string> comments = new List<string>();
        private int orderNumber = 1;
        




        public orderForm()
        {
            InitializeComponent();
            populatemenuCategories();
            populateMenu();
            clearPanels();
            entreePanel.Visible = true;
            entreePanel.Location = new Point(100, 6);
            Properties.Settings.Default.myOrderCounter = orderNumber++;
        }

        private void labelText()
        {
            Properties.Settings.Default.myOrderCounter = orderNumber++;
            label1.Text = "Order " + orderNumber.ToString();
        }
        
        
        //populates the list of table layout panels with existing panels
        private void populatemenuCategories()
        {
            menuCategories.Add(ricebreadPanel);
            menuCategories.Add(curryPanel);
            menuCategories.Add(dessertdrinkPanel);
            menuCategories.Add(entreePanel);
            menuCategories.Add(sidesPanel);
        }


        //finds the required item in the class by using its name
        private Dish findItem(string itemName)
        {
            foreach (Dish theDish in menu)
            {
                if (theDish.name == itemName)
                {
                    return theDish;
                }
            }

            return null;
        }
        
        private void populateMenu()
        {
            //sides
            menu.Add(new Dish("Pappadum (2)", (decimal)1.10));
            menu.Add(new Dish("Cucumber Raita", (decimal)3.75));
            menu.Add(new Dish("Chutney (Lime, Mango, Tomato)", (decimal)2.99));
            menu.Add(new Dish("Fresh Herbs (Coriander, Mint)", (decimal)0.00));
            //entrees
            menu.Add(new Dish("Veg Samosa", (decimal) 7.50));
            menu.Add(new Dish("Onion Bhaji (2 pieces)", (decimal)7.50));
            menu.Add(new Dish("Pakora (Veg, Chicken)", (decimal)7.50));
            menu.Add(new Dish("Chicken Tikka (2 pieces)", (decimal)9.50));
            menu.Add(new Dish("Lamb Cutlet", (decimal)9.50));
            menu.Add(new Dish("Chilli Prawns", (decimal)9.50));
            menu.Add(new Dish("Paneer Tikka", (decimal)9.50));
            //curries
            menu.Add(new Dish("Butter Chicken", (decimal)15.70));
            menu.Add(new Dish("Chicken Saag", (decimal)15.70));
            menu.Add(new Dish("Beef Roganjosh", (decimal)16.70));
            menu.Add(new Dish("Chana Masala", (decimal)14.90));
            menu.Add(new Dish("Beef Vindaloo", (decimal)16.70));
            menu.Add(new Dish("Goat Curry", (decimal)16.70));
            menu.Add(new Dish("Chicken Tikka Masala", (decimal)15.70));
            menu.Add(new Dish("Kerala Prawn Curry", (decimal)19.50));
            menu.Add(new Dish("Dal Makhni", (decimal)14.90));
            menu.Add(new Dish("Kadai Paneer", (decimal)14.90));
            //rices and breads
            menu.Add(new Dish("Biryani (Chicken, Beef, Veg)", (decimal)17.50));
            menu.Add(new Dish("Basmati Rice (1 serve)", (decimal)4.70));
            menu.Add(new Dish("Naan (Cheese, Garlic, Butter)", (decimal)7.50));
            menu.Add(new Dish("Dosa (1 piece)", (decimal)5.40));
            menu.Add(new Dish("Roti (1 piece)", (decimal)4.70));
            menu.Add(new Dish("Poori (1 piece)", (decimal)6.49));
            menu.Add(new Dish("Coconut Rice (1 serve)", (decimal)6.75));
            menu.Add(new Dish("Masala Dosa", (decimal)15.70));
            //desserts
            menu.Add(new Dish("Gulab Jamun", (decimal)4.90));
            menu.Add(new Dish("Rasmalai", (decimal)4.90));
            menu.Add(new Dish("Payasam", (decimal)4.90));
            menu.Add(new Dish("Falooda", (decimal)7.10));
            menu.Add(new Dish("Kaju Katli (3 pieces)", (decimal)4.90));
            menu.Add(new Dish("Soft Drink", (decimal)3.90));
            menu.Add(new Dish("Mango Lassi", (decimal)4.00));


        }




        //makes all the currently visible panels false
        private void clearPanels ()
        {
            foreach (var thepanel in menuCategories)
            {
                thepanel.Visible = false;
            }
        }



        private void entreeButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            entreePanel.Visible = true;
            entreePanel.Location = new Point(100, 6);
            MakeButtonsVisible();

        }

        //refreshes the panels, makes the current panel visible and moves its location, the buttons are also made visible
        private void curryButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            curryPanel.Visible = true;
            curryPanel.Location = new Point(100, 6);
            MakeButtonsVisible();
        }

        private void riceButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            ricebreadPanel.Visible = true;
            ricebreadPanel.Location = new Point(100, 6);
            MakeButtonsVisible();

        }

        

        private void dessertButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            dessertdrinkPanel.Visible = true;
            dessertdrinkPanel.Location = new Point(100, 6);
            MakeButtonsVisible();
        }
        private void sidesButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            sidesPanel.Visible = true;
            sidesPanel.Location = new Point(100, 6);
            MakeButtonsVisible();

        }

        




        //makes the checkboxes visible in each panel
        private void MakeButtonsVisible()
        {
            foreach (var panel in menuCategories)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Button button)
                    {
                        button.Visible = true;
                    }
                }
            }
        }






        //clears the textbox and appends it with all the selected items + includes their prices
        private void refreshTextbox()
        {
            if (richTextBox1 != insertComment)
            {
                richTextBox1.Clear();
            }

            foreach (Dish dish in orderedItems)
            {
                //for (int i = 0; i < orderedItems.Count; i++)
                //{
                //    if (i == 0)
                //    {
                //        richTextBox1.AppendText(dish.name + dish.price.ToString());
                //    }

                //    else
                //    {
                //        richTextBox1.AppendText(Environment.NewLine + dish.name + dish.price.ToString());
                //    }

                //}
                richTextBox1.AppendText(Environment.NewLine + dish.name + dish.price.ToString());
            }
        }

        //finds the total price of all the selected items
        private void sumTotal()
        {
            var sum = orderedItems.Sum(item => item.price);
            richTextBox2.Clear();
            richTextBox2.AppendText(sum.ToString());
        }


        //gives change based on a $50 cash input <-- makes it easier for the waiter to provide change to notes
        private void fiftyChange_Click(object sender, EventArgs e)
        {
            var subtract = orderedItems.Sum(item => item.price);
            var result = 50 - subtract;

            if (result < 0)
            {
                DialogResult x  = MessageBox.Show("Invalid Value - Please enter an amount larger than the total price");
            }
            richTextBox2.Clear();
            richTextBox2.AppendText(result.ToString());
            


        }


        private void twentyChange_Click(object sender, EventArgs e)
        {
            var subtract = orderedItems.Sum(item => item.price);
            var result = 20 - subtract;
            richTextBox2.Clear();
            richTextBox2.AppendText(result.ToString());

        }

        private void fiveChange_Click(object sender, EventArgs e)
        {
            var subtract = orderedItems.Sum(item => item.price);
            var result = 5 - subtract;
            richTextBox2.Clear();
            richTextBox2.AppendText(result.ToString());

        }

        private void tenChange_Click(object sender, EventArgs e)
        {
            var subtract = orderedItems.Sum(item => item.price);
            var result = 10 - subtract;
            richTextBox2.Clear();
            richTextBox2.AppendText(result.ToString());

        }

        //
        private void button_Click(object sender, EventArgs e)
        {
            var myButton = (Button)sender;
            if (myButton == sender)
            {
                var menuItem = findItem(myButton.Text);
                orderedItems.Add(menuItem);
                refreshTextbox();
                sumTotal();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.AppendText("1");
        }

        //my current issue is that i need this to be displayed as $12 and also the entree panel isnt showing for some reason
        private void button10_Click(object sender, EventArgs e)
        {
   
            richTextBox2.Clear(); 
            richTextBox2.AppendText("2");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            orderedItems.Clear();
            comments.Clear();
            labelText();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            insertComment.Visible = true;
            insertComment.BringToFront();
            enterComment.Visible = true;
            enterComment.BringToFront();
            
            //crete _+showtextbox

        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            Console.WriteLine("Current pos is" + line);
        }

        //private void clear_Click(object sender, EventArgs e)
        //{
        //    if (clear == sender)
        //    {

        //    }
        //}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void enterComment_Click(object sender, EventArgs e)
        {
            string commentInput = commentBox.Text;
            comments.Add(commentInput);
            commentBox.AppendText(Environment.NewLine + "'" +insertComment.Text + "'");
            insertComment.Clear();
            insertComment.Visible = false;
            enterComment.Visible = false;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void entreePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualCas_Click(object sender, EventArgs e)
        {

        }
    }


}

