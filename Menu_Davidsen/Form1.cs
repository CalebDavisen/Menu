using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Davidsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void burgersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            burgerBox.Visible = true;
        }

        private void friesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            friBox.Visible = true;
        }

        private void drinksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drinkBox.Visible = true;
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (regularButton.Checked)
            {
                total += 4.19;
            }
            else if (cheeseButton.Checked)
            {
                total += 4.79;
            }
            else if (baconButton.Checked)
            {
                total += 4.79;
            }
            else if (baconCheeseButton.Checked)
            {
                total += 5.39;
            }

            if (smallButton.Checked)
            {
                total += 2.39;
            }
            else if (mediumButton.Checked)
            {
                total += 3.09;
            }
            else if (largeButton.Checked)
            {
                total += 4.99;
            }

            if (sodaButton.Checked)
            {
                total += 1.69;
            }
            else if (waterButton.Checked)
            {
                total += 1.49;
            }

            outputBox.Text = "$" + total;
        }
    }
}
