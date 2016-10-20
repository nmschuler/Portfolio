/* Nick Schuler
 * Lab 6
 * Due November 2, 2014
 * CIS 199-01
 * This program has the user input radius, and calculates the area, surface area, and volume.
 *          Each of the 3 calculations are placed in their own methods. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(radiusInputTextBox.Text);
            if (radius > 0)
            {
                if (circleAreaRadioButton.Checked)
                {
                    answerOutputLabel.Text = "The area is " + CircleArea(radius).ToString("n2");
                }
                else if (sphereSARadioButton.Checked)
                {
                    answerOutputLabel.Text = "The surface area is " + SphereSA(radius).ToString("n2");
                }
                else if (sphereVolRadioButton.Checked)
                {
                    answerOutputLabel.Text = "The volume is " + SphereVolume(radius).ToString("n2");
                }
            }
            else
                MessageBox.Show("Enter a value greater than zero");
        }
        
        //Preconsitions: radius > 0
        //Postconditions: Takes radius and finds area of a circle
        private double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //Preconditions: radius > 0
        //Postconditions: Finds surface area of the sphere
        private double SphereSA(double radius)
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        //Preconditions: radius > 0 
        //Postconditions: finds volume of the sphere
        private double SphereVolume(double radius)
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }

       
    }
}
