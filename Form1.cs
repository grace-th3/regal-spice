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
        //a list of the table layout panels - ensures cleaner and more efficient code
        List<TableLayoutPanel> menuCategories = new List<TableLayoutPanel>();

        List<string> orderedList = new List<string>();


        List<Dish> menu = new List<Dish>();
        




        public Form1()
        {
            InitializeComponent();
            populatemenuCategories();
            populateMenu();
            clearPanels();
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
            menu.Add(new Dish("Onion Bhaji", (decimal)7.50));
            menu.Add(new Dish("Pakora", (decimal)7.50));
            menu.Add(new Dish("Chicken Tikka", (decimal)9.50));
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
            menu.Add(new Dish("Biriyani", (decimal)17.50));
            menu.Add(new Dish("Basmati Rice", (decimal)4.70));
            menu.Add(new Dish("Naan", (decimal)7.50));
            menu.Add(new Dish("Dosa", (decimal)5.40));
            menu.Add(new Dish("Roti", (decimal)4.70));
            menu.Add(new Dish("Poori", (decimal)6.49));
            menu.Add(new Dish("Coconut Rice", (decimal)6.75));
            menu.Add(new Dish("Masala Dosa", (decimal)15.70));
            //desserts
            menu.Add(new Dish("Gulab Jamun", (decimal)4.90));
            menu.Add(new Dish("Rasmalai", (decimal)4.90));
            menu.Add(new Dish("Payasam", (decimal)4.90));
            
        }



        //makes all the currently visible panels false
        private void clearPanels ()
        {
            foreach (var thepanel in menuCategories)
            {
                thepanel.Visible = false;
            }
        }

        private void clearText ()
        {
            
        }

        //clears the panels, allows the specific panel to be viewed and moves location
        private void entreeButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            entreePanel.Visible = true;
            entreePanel.Location = new Point(138, 6);
            MakeCheckboxesVisible();

        }

        private void curryButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            curryPanel.Visible = true;
            curryPanel.Location = new Point(100, 6);
            MakeCheckboxesVisible();
        }

        private void riceButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            ricebreadPanel.Visible = true;
            ricebreadPanel.Location = new Point(100, 6);
            MakeCheckboxesVisible();

        }

        

        private void dessertButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            dessertdrinkPanel.Visible = true;
            dessertdrinkPanel.Location = new Point(100, 6);
            MakeCheckboxesVisible();
        }
        private void sidesButton_Click(object sender, EventArgs e)
        {
            clearPanels();
            sidesPanel.Visible = true;
            sidesPanel.Location = new Point(100, 6);
            MakeCheckboxesVisible();

            foreach (CheckBox checkBox in sidesPanel.Controls)
            {
                if (checkBox.Checked)
                {
                    addnewItem();
                }
            }

        }

        



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mods");
        }


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }



        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }


        //makes the checkboxes visible in each panel
        private void MakeCheckboxesVisible()
        {
            foreach (var panel in menuCategories)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is CheckBox checkbox)
                    {
                        checkbox.Visible = true;
                    }
                }
            }
        }


        private void addnewItem()
        {
            orderedList.Clear();
            foreach (var panel in menuCategories)
            {
                foreach (CheckBox checkbox in panel.Controls)
                {
                    if (checkbox.Checked)
                    {
                        orderedList.Add(checkbox.Text);

                    }
      
                }
            }


            foreach (var item in orderedList)
            {
                richTextBox1.AppendText(item);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void biriyani_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mods");
        }

        private void entreePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void refreshOrder()
        {
            List<CheckBox> myCheckboxList = new List<CheckBox>();
            foreach (CheckBox checkbox in sidesPanel.Controls)
            {
                myCheckboxList.Append(checkbox);
            }

            foreach (CheckBox checkbox in entreePanel.Controls)
            {
                myCheckboxList.Append(checkbox);
            }

  
            foreach (CheckBox checkbox in curryPanel.Controls)
            {
                myCheckboxList.Append(checkbox);
            }

            foreach (CheckBox checkbox in dessertdrinkPanel.Controls)
            {
                myCheckboxList.Append(checkbox);
            }

            foreach (CheckBox checkbox in ricebreadPanel.Controls)
            {
                myCheckboxList.Append(checkbox);
            }

            foreach (CheckBox checkbox in myCheckboxList)
            {
                string x = checkbox.Name;
                var test = findItem("Pappadum (2)");
                richTextBox1.AppendText("                " + test.price.ToString());
                //need to make sure i cna append the text and clearit should work for all of it
            }
        }

        //private void sumTotal ()
        //{
            
        //}
        private void sidesPanel_Paint(object sender, PaintEventArgs e)
        {
            //List<CheckBox> myCheckboxList = new List<CheckBox>();
            //foreach (CheckBox checkbox in sidesPanel.Controls)
            //{
            //    myCheckboxList.Append(checkbox);
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
           
            if (checkBox4.Checked)
            {
                addnewItem();
                var test = findItem("Pappadum (2)");
                richTextBox1.AppendText("                " + test.price.ToString());

            }
        }

  



        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

