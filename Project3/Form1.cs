using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Exit button to close the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Mix button evaluates radio button conditions to change form background color
        
        private void mixButton_Click(object sender, EventArgs e)
        {
            //Regardless of order chosen if both buttons are selected red the background is changed to red
            if (firstRed.Checked && secondRed.Checked)
            {
                this.BackColor = Color.Red;
            }
            //I wanted to reduce the number of else if by nesting two conditions in one evaluation
            //This one determines if any combination of red or blue is selected the color purple is displayed
            else if ((firstRed.Checked && secondBlue.Checked) || (firstBlue.Checked && secondRed.Checked))
            {
                this.BackColor = Color.Purple;
            }
            //This one determines if any combination of red or yellow is selected the color orange is displayed
            else if ((firstRed.Checked && secondYellow.Checked) || (firstYellow.Checked && secondRed.Checked))
            {
                this.BackColor = Color.Orange;
            }
            //This one determines if any combination of blue or yellow is selected the color green is displayed
            else if ((firstBlue.Checked && secondYellow.Checked) || (firstYellow.Checked && secondBlue.Checked))
            {
                this.BackColor = Color.Green;
            }
            //Regardless of order chosen if both buttons are selected blue the background is changed to blue
            else if (firstBlue.Checked && secondBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }
            //If none of the above conditions are true then yellow must be chosen
            // for both groups and the background is changed to yellow
            else 
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}
